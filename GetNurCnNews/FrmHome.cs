using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using HtmlAgilityPack;
using System.Threading;

namespace GetNurCnNews
{
    public partial class FrmHome : Form
    {
        /// <summary>
        /// 当前页获取新闻集合
        /// </summary>
        List<NewsListModel> newsList;

        int typeID = 0;


        /// <summary>
        /// 以采集新闻ID和
        /// </summary>
        List<int> idList;

        /// <summary>
        /// 目录文件日记
        /// </summary>
        string folderPath = "";



        /// <summary>
        /// 获取或设置是否可以自动收集
        /// </summary>
        ///bool isAutomaticGet = false;


        public FrmHome()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            newsList = new List<NewsListModel>();
            idList = new List<int>();
            //如果日记文件已存在,加载集合
            if (File.Exists("log\\getedidlist.log"))
            {
                string[] idstr = File.ReadAllText("log\\getedidlist.log").Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string ids in idstr)
                {
                    int id;
                    if (int.TryParse(ids, out id) && !idList.Contains(id))
                    {
                        idList.Add(id);
                    }
                }
            }
            //是否存在目录日记文件
            if (File.Exists("log\\imagefolder.log"))
            {
                //判断是否存在目录
                string path = File.ReadAllText("log\\imagefolder.log", Encoding.UTF8);
                if (Directory.Exists(path))
                {
                    btnFolder.Enabled = false;
                    txtFolder.Text = path;
                    folderPath = path;
                }
            }
            //自动收集日记文件是否存在
            //if (File.Exists("log\\automaticget.logo"))
            //{
            //    try
            //    {
            //        AutomaticGet auto = JsonConvert.DeserializeObject<AutomaticGet>(File.ReadAllText("log\\automaticget.logo"));
            //        if (auto.IsAutomatic)
            //        {
            //            //是自动收集
            //            //开一个线程来承担一下操作
            //            Thread th = new Thread(BeginAutomaticGet);
            //            th.IsBackground = true;
            //            th.Start();
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        isAutomaticGet = false;
            //    }
            //}
        }


        #region 全自动获取过程
        /// <summary>
        /// 开始全自动获取页面
        /// </summary>
        void BeginAutomaticGet()
        {
            //将所有的影响自动收集过程的控件锁定掉
            btnFolder.Enabled = false;
            btnGetSelectedNews.Enabled = false;
        }

        #endregion











        /// <summary>
        /// 选择指定目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFolder_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }
        /// <summary>
        /// 选择指定目录
        /// </summary>
        void SelectFolder()
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowNewFolderButton = true;
            if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFolder.Text = fb.SelectedPath;
                folderPath = fb.SelectedPath;
                btnFolder.Enabled = false;
                //写入到日记中
                File.WriteAllText("log\\imagefolder.log", fb.SelectedPath, Encoding.UTF8);
            }
        }


        /// <summary>
        /// 回复出厂设置,删除所有的配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmFactory_Click(object sender, EventArgs e)
        {
            //删除数据库配置文件
            if (File.Exists("log\\constr.log"))
            {
                File.Delete("log\\constr.log");
            }
            //删除其他配置文件
            if (File.Exists("log\\nurnewstypes.log"))
            {
                File.Delete("log\\nurnewstypes.log");
            }
            if (File.Exists("log\\newslocaltypes.log"))
            {
                File.Delete("log\\newslocaltypes.log");
            }
            if (File.Exists("log\\twonewsmodels.log"))
            {
                File.Delete("log\\twonewsmodels.log");
            }
            if (File.Exists("log\\getedidlist.log"))
            {
                File.Delete("log\\getedidlist.log");
            }
            if (File.Exists("log\\imagefolder.log"))
            {
                File.Delete("log\\imagefolder.log");
            }
            //重启系统
            Application.Restart();
        }

        /// <summary>
        /// 删除数据库配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmDataBaseReset_Click(object sender, EventArgs e)
        {
            //删除数据库配置文件
            if (File.Exists("log\\constr.log"))
            {
                File.Delete("log\\constr.log");
            }
            //重启系统
            Application.Restart();
        }


        /// <summary>
        /// 从网络获取数据
        /// </summary>
        /// <returns></returns>
        List<NewsListModel> GetHtmlData(int pageIndex)
        {

            string postData = "json=tur&mid=" + typeID + "&page=" + pageIndex + "&rnd=0.1139371762983501";
            byte[] dataArray = Encoding.UTF8.GetBytes(postData);
            //创建请求
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://m.nur.cn/do.php?do=ajax");
            request.Method = "POST";
            request.ContentLength = dataArray.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Referer = "http://m.nur.cn/do.php?do=tur&mid=" + typeID;
            //创建输入流
            Stream dataStream = null;
            try
            {
                dataStream = request.GetRequestStream();
            }
            catch (Exception)
            {
                return null;//连接服务器失败
            }
            //发送请求
            dataStream.Write(dataArray, 0, dataArray.Length);
            dataStream.Close();
            //读取返回消息
            string res = string.Empty;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                res = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception ex)
            {
                return null;//连接服务器失败
            }


            return JsonConvert.DeserializeObject<List<NewsListModel>>(res);
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHome_Load(object sender, EventArgs e)
        {
            //设置ComboBox 的内容
            cmbNurTypes.Items.Clear();
            NurNewsTypeModel nur = new NurNewsTypeModel();
            nur.TypeID = 0;
            nur.Title = "نۇر تورىدىكى تۈرىنى تاللاڭ";
            cmbNurTypes.Items.Add(nur);
            cmbNurTypes.Items.AddRange(AllModel.NurNewsTypeList.ToArray());
            cmbNurTypes.SelectedIndex = 0;
        }

        /// <summary>
        /// 当选择项更改是
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNurTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNurTypes.SelectedIndex == 0)
            {
                //删除数据
                dgvShow.Rows.Clear();
                lblNurType.Text = "";
                lblPageIndex.Text = "0";
                btnPrevPage.Enabled = false;
                btnNextPage.Enabled = false;
                return;
            }
            //获取数据
            lblNurType.Text = (cmbNurTypes.SelectedItem as NurNewsTypeModel).Title;
            typeID = (cmbNurTypes.SelectedItem as NurNewsTypeModel).TypeID;
            lblPageIndex.Text = "1";
            DataBindToTable(1);
            dgvShow.Focus();
            //按钮参数
            btnPrevPage.Enabled = false;
            btnNextPage.Enabled = true;
            btnNextPage.Tag = 2;
            btnPrevPage.Tag = 0;

        }




        /// <summary>
        /// 数据绑定集合
        /// </summary>
        /// <param name="typeID"></param>
        /// <param name="pageIndex"></param>
        void DataBindToTable(int pageIndex)
        {
            dgvShow.Rows.Clear();
            newsList = GetHtmlData(pageIndex);
            if (newsList == null || newsList.Count <= 0)
            {
                new UgMessageBox("ئىرىشەلمىدى!", Color.Red).ShowDialog();
                return;
            }
            BindToTable();
        }

        /// <summary>
        /// 数据绑定,集合已知
        /// </summary>
        void BindToTable()
        {
            dgvShow.Rows.Clear();
            //替换数据
            //获取类别 ID
            TwoNewsModel twe = AllModel.News.FirstOrDefault(c => c.NurTypeID == typeID);
            foreach (NewsListModel news in newsList)
            {
                TableModel tm = new TableModel();
                tm.LocalTypeID = twe.LocalTypeID;
                tm.LocalTypeTitle = twe.LocalTypeTitle;
                tm.NewsLogoImg = news.thumb;
                tm.NurID = news.id;
                tm.NurTypeID = twe.NurTypeID;
                tm.NurTypeTitle = twe.NurTypeTitle;
                tm.Title = news.title;

                int index = dgvShow.Rows.Add();
                DataGridViewCheckBoxCell ckCell = new DataGridViewCheckBoxCell();
                ckCell.Tag = tm;
                dgvShow.Rows[index].Cells["Select"] = ckCell;
                //如果已经被添加了该新闻,不可以选择
                if (idList.Contains(tm.NurID))
                {
                    ckCell.ReadOnly = true;
                    dgvShow.Rows[index].DefaultCellStyle = new DataGridViewCellStyle() { ForeColor = Color.FromArgb(152, 152, 152) };
                }
                dgvShow.Rows[index].Cells["NurID"].Value = tm.NurID;
                dgvShow.Rows[index].Cells["NewsTitle"].Value = tm.Title;
                dgvShow.Rows[index].Cells["NurTypeTitle"].Value = tm.NurTypeTitle;
                dgvShow.Rows[index].Cells["NurTypeID"].Value = tm.NurTypeID;
                dgvShow.Rows[index].Cells["LocalTypeTitle"].Value = tm.LocalTypeTitle;
                dgvShow.Rows[index].Cells["LocalTypeID"].Value = tm.LocalTypeID;
                //添加浏览按钮
                DataGridViewButtonCell btnCell = new DataGridViewButtonCell();
                btnCell.Tag = tm;
                btnCell.Value = "كۆرۈش";
                dgvShow.Rows[index].Cells["Broser"] = btnCell;
                dgvShow.Rows[index].Cells["NewsLogoImg"].Value = tm.NewsLogoImg;
            }
        }

        /// <summary>
        /// 点击浏览按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShow.Columns[e.ColumnIndex].Name == "Broser")
            {
                //获取该按钮
                DataGridViewButtonCell btnCell = dgvShow.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                TableModel tm = btnCell.Tag as TableModel;
                //显示窗口
                string url = "http://m.nur.cn/do.php?do=show&mid=" + tm.NurID;
                new FrmBroser(url, tm.Title).ShowDialog();
            }
            else if (dgvShow.Columns[e.ColumnIndex].Name == "Select")
            {
                DataGridViewCheckBoxCell ckCell = dgvShow.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                if (ckCell.ReadOnly)
                {
                    TableModel tm = ckCell.Tag as TableModel;
                    new UgMessageBox("بۇ خەۋەر ئاللىبۇرۇن ساندانغا ساقلانغان، سانداندىكى ئۇچۇرلارنىڭ قايتىلانماسلىقى ئۈچۈن بۇ خەۋەرنى تاللىيالمايسىز! ئەگەر ساندانغا قايتا ساقلايمەن دىسىڭىز خاتىرە ھۆججىتىنى " + "log\\getedidlist.log" + " ئېچىپ،" + tm.NurID + " دىگەن ساننى ئۆچۈرۈپ ساقلاڭ، ئاندىن سىستىمىنى قايتا قوزغۇتۇپ سىناپ بېقىڭ!!!", Color.Red).ShowDialog();
                }
            }
        }

        /// <summary>
        /// 下一页按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int pageIndex = Convert.ToInt32(btnNextPage.Tag);
            if (!btnPrevPage.Enabled)
            {
                btnPrevPage.Enabled = true;
            }
            lblPageIndex.Text = pageIndex.ToString();
            btnPrevPage.Tag = pageIndex - 1;
            btnNextPage.Tag = pageIndex + 1;
            //获取类型ID
            NurNewsTypeModel tp = cmbNurTypes.SelectedItem as NurNewsTypeModel;
            typeID = tp.TypeID;
            DataBindToTable(pageIndex);
        }

        /// <summary>
        /// 上一页按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            int pageIndex = Convert.ToInt32(btnPrevPage.Tag);
            if (Convert.ToInt32(btnPrevPage.Tag) == 1)
            {
                btnPrevPage.Enabled = false;
            }
            lblPageIndex.Text = pageIndex.ToString();
            btnNextPage.Tag = pageIndex + 1;
            btnPrevPage.Tag = pageIndex - 1;
            //获取类型ID
            NurNewsTypeModel tp = cmbNurTypes.SelectedItem as NurNewsTypeModel;
            typeID = tp.TypeID;
            DataBindToTable(pageIndex);
        }

        /// <summary>
        /// 开始收集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetSelectedNews_Click(object sender, EventArgs e)
        {
            //判断是否有数据
            if (dgvShow.Rows.Count <= 0)
            {
                new UgMessageBox("ھېچقانداق ئۇچۇر يوق تۇرسا نىمىنى يىغماقچىتىڭىز؟", Color.Red).ShowDialog();
                return;
            }
            //已选择集合
            List<TableModel> tables = new List<TableModel>();
            TableModel table;
            //获取所有已选择的
            foreach (DataGridViewRow row in dgvShow.Rows)
            {
                DataGridViewCheckBoxCell col = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(col.Value))
                {
                    table = col.Tag as TableModel;
                    table.IsSelect = true;
                    tables.Add(table);
                }
            }
            //判断有没有选中
            if (tables.Count <= 0)
            {
                new UgMessageBox("مىنى سىناپ باقماقچىمىدىڭىز؟ مەن بىلىمەن، سىز تېخى ھېچنىمە تاللىمىدىڭىز!~", Color.Red).ShowDialog();
                return;
            }
            //ids集合中添加这些
            idList.AddRange(tables.Select(c => c.NurID));
            //写入到本地日记文件中
            File.WriteAllText("log\\getedidlist.log", string.Join<int>(":", idList));
            //开始写入操作
            //由于下载文件时间延迟,所以由现成来承担这些操作
            Thread th = new Thread(BeginWrite);
            th.IsBackground = true;
            th.Start(tables);

        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="tables"></param>
        private void BeginWrite(object obj)
        {

            List<TableModel> tables = obj as List<TableModel>;

            picLoad.Visible = true;

            Enable(false);

            List<int> idsError = new List<int>();
            foreach (TableModel table in tables)
            {
                //先将logo图片保存到本地
                //logo 图片格式
                //getimages/logo/{Month}/{FileName}
                string logoExe = Path.GetExtension(table.NewsLogoImg).TrimStart(new char[] { '.' });
                string newLogoFileName = Guid.NewGuid().ToString() + "." + logoExe;
                string logoFilename = string.Format("image\\pic\\hawar\\{0}\\{1}\\{2}\\{3}", DateTime.Now.Year.ToString("0000"), DateTime.Now.Month.ToString("00"), DateTime.Now.Day.ToString("00"), newLogoFileName);
                if (!SaveImage(table.NewsLogoImg, logoFilename))
                {
                    idsError.Add(table.NurID);
                    continue;
                }
                //table.NewsLogoImg = "/" + logoFilename.Replace("\\", "/");
                table.NewsLogoImg = newLogoFileName;
                //获取新闻内容
                //生成标准 URL
                string url = "http://m.nur.cn/do.php?do=show&mid=" + table.NurID;
                string html = GetHtml(url);
                if (html == "")
                {
                    idsError.Add(table.NurID);
                    continue;
                }
                string des;
                string con = GetContent(html, out des);
                if (con == "")
                {
                    idsError.Add(table.NurID);
                    continue;
                }
                table.Des = des;
                table.NewsContent = con;
                //来源
                table.Source = GetSource(html);
                //作者
                table.NickName = GetAuthor(html);
                //把新闻内容中的图片保存到本地,并修改路径
                //内容图片路径格式
                //getimages/{Year}/{Week}/{FileName}

                //数据写入到数据库中
                Dal.Add(table);
            }
            //如果发生错误
            if (idsError.Count > 0)
            {
                idList = (from ids in idList
                          where !idsError.Contains(ids)
                          select ids).ToList();
                //写入到本地日记文件中
                File.WriteAllText("log\\getedidlist.log", string.Join<int>(":", idList));
            }
            //提示
            string msg = "بۇ قېتمدا جەمئى يىغىلغان خەۋەر:  " + (tables.Count - idsError.Count) + "  پارچە\r\n";
            msg += "مەغلۇب بولغىنى جەمئى :  " + idsError.Count + "  پارچە\r\n";
            Color c = idsError.Count == tables.Count ? Color.Red : (idsError.Count > 0 ? Color.Yellow : Color.Green);
            //设置为 false
            picLoad.Visible = false;
            //显示窗口
            new UgMessageBox(msg, c).ShowDialog();

            //重新绑定
            BindToTable();
            //生效控件
            Enable(true);
        }


        /// <summary>
        /// 失效和生效控件
        /// </summary>
        /// <param name="p"></param>
        private void Enable(bool p)
        {
            btnGetAll.Enabled = p;
            btnGetSelectedNews.Enabled = p;
            btnNextPage.Enabled = p;
            btnPrevPage.Enabled = p;
            cmbNurTypes.Enabled = p;
            menuHome.Enabled = p;
            if (p)
            {
                if (Convert.ToInt32(btnPrevPage.Tag) == 0)
                {
                    btnPrevPage.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 获取来源
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        string GetSource(string html)
        {
            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                var titleNode = doc.GetElementbyId("subtitle");
                string sour = titleNode.Elements("p").FirstOrDefault(p => p.GetAttributeValue("class", "") == "manba").InnerText;
                return sour ?? "";
            }
            catch (Exception)
            {

                return "";
            }
        }

        /// <summary>
        /// 获取发布者
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        string GetAuthor(string html)
        {
            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                var titleNode = doc.GetElementbyId("subtitle");
                string sour = titleNode.Elements("p").FirstOrDefault(p => p.GetAttributeValue("class", "") == "nickname").InnerText;
                return sour ?? "";
            }
            catch (Exception)
            {

                return "";
            }
        }

        /// <summary>
        /// 将内容分析,获取之内的所有图片,修改路径,并保存到本地
        /// </summary>
        /// <param name="html">包含内容的 html 字符串</param>
        /// <returns>返回有效的内容</returns>
        string GetContent(string html, out string des)
        {
            des = "";
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            //获取 body
            try
            {
                HtmlNode bodyNode = doc.DocumentNode.Element("html").Element("body");
                //获取 content
                HtmlNode contentNode = bodyNode.Elements("div").FirstOrDefault(c => c.GetAttributeValue("class", "") == "content");
                if (contentNode == null)
                {
                    return "";
                }
                //获取内容,取消最后一个 p
                contentNode.RemoveChild(contentNode.Elements("p").Last());
                //循环遍历 图片
                EachImages(contentNode);
                des = contentNode.InnerText;
                des = des.Length > 200 ? des.Substring(0, 200) : des;
                return contentNode.InnerHtml;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        /// <summary>
        /// 递归遍历内容中的图片
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        void EachImages(HtmlNode node)
        {
            if (node.Name == "img")
            {
                //图片
                string url = node.GetAttributeValue("src", "");
                if (url == "")
                {
                    return;
                }
                //if (url.StartsWith("s_") || url.StartsWith("S_"))
                //{
                //    url = url.Substring(2);
                //}          

                string urlPath = url.Replace("/", "\\");
                string picName = Path.GetFileName(urlPath);
                if (picName.StartsWith("s_") || picName.StartsWith("S_"))
                {
                    url = url.Replace(picName, picName.Substring(2));
                }



                //获取图片信息,生成新的路径
                //getimages/{Year}/{Week}/{FileName}
                string exe = Path.GetExtension(url).TrimStart(new char[] { '.' });
                string fileName = Guid.NewGuid().ToString() + "." + exe;
                //int day = DateTime.Now.Day;
                //相对路径
                string fullName = string.Format("getimages\\{0}\\{1}\\{2}\\{3}.{4}", DateTime.Now.Year.ToString("0000"), DateTime.Now.Month.ToString("00"), DateTime.Now.Day.ToString("00"), Guid.NewGuid().ToString(), exe);
                //网站 
                string urlNew = "/" + fullName.Replace("\\", "/");
                node.SetAttributeValue("src", urlNew);
                //保存到本地
                SaveImage(url, fullName);
            }
            else
            {
                //判断是否有子标签
                if (node.HasChildNodes)
                {
                    foreach (HtmlNode nn in node.ChildNodes)
                    {
                        EachImages(nn);
                    }
                }
            }
        }



        /// <summary>
        /// 图片文件爱你保存到本地
        /// </summary>
        /// <param name="url">图片路径</param>
        /// <param name="localPath"></param>
        /// <returns></returns>
        bool SaveImage(string url, string localPath)
        {
            //判断是否存在父目录
            if ((string.IsNullOrEmpty(folderPath)) || !Directory.Exists(folderPath))
            {
                //选择路径不匹配,重新选择
                new UgMessageBox("سىز تېخى رەسىم ساقلايدىغان مۇندەرىجىنى تاللىمىدىڭىز ياكى مۇندەرىجە نامى ئىناۋەتسىز، قايتا تاللاڭ!!!", Color.Red).ShowDialog();
                SelectFolder();
                return false;
            }
            //创建本地路径
            string path = string.Empty;
            //if (isLogo)
            //{
            //    path = folderPath.TrimEnd(new char[] { '\\' }) + "\\" + localPath;
            //}
            //else 
            path = folderPath.TrimEnd(new char[] { '\\' }) + "\\" + localPath;
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                //保存图片到本地
                WebClient wb = new WebClient();
                wb.BaseAddress = url;
                wb.DownloadFile(url, path);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }

        /// <summary>
        /// 获取网络数据
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        string GetHtml(string url)
        {
            WebClient wc = new WebClient();
            try
            {
                byte[] buffer = wc.DownloadData(url);
                return Encoding.UTF8.GetString(buffer);
            }
            catch (Exception e)
            {
                return "";
            }
        }

        /// <summary>
        /// 收集当前页中的所有内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            if (newsList == null || newsList.Count <= 0)
            {
                //没有数据
                new UgMessageBox("ھېچقانداق ئۇچۇر بولمىسا نىمىنى يىغماقچىتىڭىز؟", Color.Red).ShowDialog();
                return;
            }

            //已选择集合
            List<TableModel> tables = new List<TableModel>();
            TableModel table;
            //获取所有已选择的
            foreach (DataGridViewRow row in dgvShow.Rows)
            {
                DataGridViewCheckBoxCell col = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (!col.ReadOnly)
                {
                    table = col.Tag as TableModel;
                    table.IsSelect = true;
                    tables.Add(table);
                }
            }
            //判断有没有选中
            if (tables.Count <= 0)
            {
                new UgMessageBox("بۇ بەتتىكى بارلىق ئۇچۇرلار ساقلانغان، ساندانغا قايتا يېزىشقا بولمايدۇ!~!~", Color.Red).ShowDialog();
                return;
            }
            //ids集合中添加这些
            idList.AddRange(tables.Select(c => c.NurID));
            //写入到本地日记文件中
            File.WriteAllText("log\\getedidlist.log", string.Join<int>(":", idList));
            //开始写入操作
            //由于下载文件时间延迟,所以由现成来承担这些操作
            Thread th = new Thread(BeginWrite);
            th.IsBackground = true;
            th.Start(tables);

        }

        private void tsmToFactoryWithoutDB_Click(object sender, EventArgs e)
        {
            //删除其他配置文件
            if (File.Exists("log\\nurnewstypes.log"))
            {
                File.Delete("log\\nurnewstypes.log");
            }
            if (File.Exists("log\\newslocaltypes.log"))
            {
                File.Delete("log\\newslocaltypes.log");
            }
            if (File.Exists("log\\twonewsmodels.log"))
            {
                File.Delete("log\\twonewsmodels.log");
            }
            if (File.Exists("log\\getedidlist.log"))
            {
                File.Delete("log\\getedidlist.log");
            }
            if (File.Exists("log\\imagefolder.log"))
            {
                File.Delete("log\\imagefolder.log");
            }
            //重启系统
            Application.Restart();
        }


    }
}
