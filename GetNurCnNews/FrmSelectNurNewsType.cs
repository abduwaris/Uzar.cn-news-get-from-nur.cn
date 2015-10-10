using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System.IO;

namespace GetNurCnNews
{
    public partial class FrmSelectNurNewsType : Form
    {
        List<NurNewsTypeModel> types;
        public FrmSelectNurNewsType()
        {
            InitializeComponent();
            types = new List<NurNewsTypeModel>();


        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSelectNurNewsType_Load(object sender, EventArgs e)
        {
            //添加默认类型
            NurNewsTypeModel nur = new NurNewsTypeModel();
            nur.TypeID = 7;
            nur.Title = "خەلىقئارا";
            types.Add(nur);

            nur = new NurNewsTypeModel();
            nur.TypeID = 16;
            nur.Title = "تەنتەربىيە";
            types.Add(nur);

            nur = new NurNewsTypeModel();
            nur.TypeID = 15;
            nur.Title = "تېخنىكا";
            types.Add(nur);

            nur = new NurNewsTypeModel();
            nur.TypeID = 12;
            nur.Title = "ئىقتىساد";
            types.Add(nur);

            nur = new NurNewsTypeModel();
            nur.TypeID = 10;
            nur.Title = "تاماشا";
            types.Add(nur);

            DataBingToSelectBox();

        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        void DataBingToSelectBox()
        {
            //将这些绑定到 选择列表中
            clbTypes.Items.Clear();
            foreach (var item in types)
            {
                clbTypes.Items.Add(item);
            }
        }

        /// <summary>
        /// ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {

            if (clbTypes.CheckedItems.Count <= 0)
            {
                new UgMessageBox("ئەڭ ئاز بولغاندا بىر تۈر بۇلىشى ھەم تاللىنىشى كىرەك!!!", Color.Red).ShowDialog();
                return;
            }
            //获取
            types.Clear();
            foreach (var item in clbTypes.CheckedItems)
            {
                types.Add(item as NurNewsTypeModel);
            }
            //赋值变量
            AllModel.NurNewsTypeList = types;
            //保存到日记文件中
            string jstr = JsonConvert.SerializeObject(types);
            File.WriteAllText("log\\nurnewstypes.log", jstr);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// 删除以选择项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clbTypes.CheckedItems.Count > 0)
            {
                System.Windows.Forms.ListBox.SelectedObjectCollection list = clbTypes.SelectedItems;
                //获取选择项
                foreach (var item in clbTypes.CheckedItems)
                {
                    NurNewsTypeModel tp = item as NurNewsTypeModel;
                    //删除集合中的
                    types = types.Where(n => n.TypeID != tp.TypeID).ToList();
                }
                //重新赋值集合
                DataBingToSelectBox();
            }
        }

        /// <summary>
        /// 添加新的类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtTypeID.Text, out id))
            {
                new UgMessageBox("نۇر تورىدىكى تۈر نۇمۇرى چۇقۇم سان بۇلىشى كىرەك، سان بولمىسا داۋاملىق مەشغۇلات قىلالمايسىز!!!", Color.Red).ShowDialog();
                return;
            }
            if (string.IsNullOrEmpty(txtTypeTitle.Text.Trim()))
            {
                new UgMessageBox("نۇر تورىدىكى خەۋەر نامى بوش قالمىسۇن، بۇ ئىككى سانداننى سېلىشتۇرۇش ئۈچۈن ئاساس بۇلىدۇ.", Color.Red).ShowDialog();
                return;
            }
            //检测网络状态
            if (!isConnected())
            {
                new UgMessageBox("تور ئۇلىنىشتا خاتالىق بار،تورغا ئۇلانمىسا سىز قوشقان بۇ تۈرنىڭ نۇر تورىدا مەۋجۇتلۇقىنى بىلگىلى بولمايدۇ، بۇنداق شارائىتتا نىمە قىلىشىڭىزنى سىز ئوبدان بىلىسىز", Color.Red).ShowDialog();
                return;
            }
            //判断该类别是否存在
            bool error = false;
            //获取 html
            //http://www.nur.cn/index.php?a=lists&catid=7
            string html = GetHtmlData("http://www.nur.cn/index.php?a=lists&catid=" + id);
            if (html == "")
            {
                error = true;
            }
            else
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                //获取body
                HtmlNode htmlNode = doc.DocumentNode;
                HtmlNode bodyNode = htmlNode.Element("html").Element("body");
                if (bodyNode == null)
                {
                    error = true;
                }
                else
                {
                    //获取 div
                    HtmlNode listNode = bodyNode.Elements("div").FirstOrDefault(n => n.GetAttributeValue("class", "") == "list_box");
                    if (listNode == null)
                    {
                        error = true;
                    }
                    else error = false;
                }
            }
            if (error)
            {
                new UgMessageBox("كەچۈرۈڭ!!! نۇر تورىدا بۇنداق تۈر مەۋجۇت ئەمەس، مەۋجۇت بولمىغان نەرسىنى سىز قانداق ساندانغا قۇشاسىز،ئەلۋەتتە قۇشالمايسىز، شۇڭا مەنمۇ بۇنى تۈر تىزىملىكىگە قۇشالمايمەن، خاپا بولماي قايتا سىناپ باقاملا، سىنىغانغا باج ئالمايمەن، خاتىرجەم سىناڭ", Color.Red).ShowDialog();
                return;
            }
            //判断是否在集合中已存在这个类别
            if (types.Where(p => p.TypeID == id).Count() > 0)
            {
                new UgMessageBox("بۇ تۈر ئاللىقاچان تاللانغان، كۆزىڭىزنى يۇغان ئېچىپ ئاۋۇ تىرناقنىڭ ئىچىگە ئوبدان قاراپ بېقىڭ، سىز تولداغان سان بامىكەن يا يوقمىكەن", Color.Red).ShowDialog();
                return;
            }
            //该类别存在,添加到集合中
            NurNewsTypeModel nur = new NurNewsTypeModel();
            nur.TypeID = id;
            nur.Title = txtTypeTitle.Text.Trim();
            types.Add(nur);
            DataBingToSelectBox();
            new UgMessageBox("بۇ تۈر نۇر تورىدا مەۋجۇت بولغانلىقى ئۈچۈن مۇۋاپىقىيەتلىك قوشۇلدى.", Color.Green).ShowDialog();
        }

        #region 检查网络状态

        //检测网络状态
        [DllImport("wininet.dll")]
        extern static bool InternetGetConnectedState(out int connectionDescription, int reservedValue);
        /// <summary>
        /// 检测网络状态
        /// </summary>
        bool isConnected()
        {
            int I = 0;
            bool state = InternetGetConnectedState(out I, 0);
            return state;
        }

        #endregion

        #region 获取 html

        /// <summary>
        /// 获取 html
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        string GetHtmlData(string url)
        {
            WebClient wb = new WebClient();
            try
            {
                byte[] buffer = wb.DownloadData(url);
                string html = System.Text.Encoding.UTF8.GetString(buffer);
                return html;
            }
            catch (Exception)
            {
                return "";
            }
        }

        #endregion

        private void FrmSelectNurNewsType_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
