using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace GetNurCnNews
{
    public partial class FrmNewsConfig : Form
    {
        public FrmNewsConfig()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNewsConfig_Load(object sender, EventArgs e)
        {
            //从数据库中获取本地类别集合
            List<NewsLocalTypesModel> localTypes = AllModel.NewsLocalTypes;
            //获取新闻类别集合
            List<NurNewsTypeModel> types = AllModel.NurNewsTypeList;
            //创建控件
            int r = 1;
            foreach (NurNewsTypeModel nur in types)
            {
                //创建 nur.cn 类别 ComboBox
                ComboBox cmb = new ComboBox();
                cmb.Name = "cmbnur_" + r;
                cmb.Size = new Size(121, 26);
                cmb.Location = new Point(174, 26 + (r - 1) * 32);
                NurNewsTypeModel nurss = new NurNewsTypeModel();
                nurss.TypeID = 0;
                nurss.Title = "نۇردىكى تۈرىنى تاللاڭ";
                cmb.Items.Add(nurss);
                foreach (NurNewsTypeModel nurs in types)
                {
                    cmb.Items.Add(nurs);
                }
                cmb.SelectedIndex = 0;
                gbBox.Controls.Add(cmb);

                //创建 lable
                Label lb = new Label();
                lb.Name = "lbbbb_" + r;
                lb.Text = "=>";
                lb.Size = new Size(22, 18);
                lb.Location = new Point(146, 32 + (r - 1) * 32);
                gbBox.Controls.Add(lb);


                //创建本地类别 box
                ComboBox cmbb = new ComboBox();
                cmbb.Name = "cmblocal_" + r;
                cmbb.Location = new Point(16, 26 + (r - 1) * 32);
                cmbb.Size = new Size(121, 26);
                NewsLocalTypesModel mm = new NewsLocalTypesModel();
                mm.TypeID = 0;
                mm.TypeTitle = "يەرلىكتىكى تۈر نامىنى تاللاڭ";
                cmbb.Items.Add(mm);
                foreach (var item in localTypes)
                {
                    cmbb.Items.Add(item);
                }
                cmbb.SelectedIndex = 0;
                gbBox.Controls.Add(cmbb);
                r++;
            }
            //获取集合数量,设定窗体大小,间距为 32
            int count = types.Count;
            gbBox.Height = 26 + count * 32;
            //Ok 按钮坐标
            btnOK.Location = new Point(210, 52 + count * 32);
            //窗体大小
            this.Size = new Size(350, 145 + count * 32);
        }

        /// <summary>
        /// 开始按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //获取所有的ComboBox 控件
            System.Windows.Forms.Control.ControlCollection cc = gbBox.Controls;
            List<ComboBox> cmbs = new List<ComboBox>();
            foreach (var c in cc)
            {
                if (c is ComboBox)
                {
                    cmbs.Add(c as ComboBox);
                }
            }
            //获取所有来自nur的类别,并且有效的
            List<ComboBox> nurs = cmbs.Where(c => c.Name.StartsWith("cmbnur") && c.SelectedItem is NurNewsTypeModel && (c.SelectedItem as NurNewsTypeModel).TypeID != 0).ToList();
            List<ComboBox> locals = cmbs.Where(c => c.Name.StartsWith("cmblocal") && c.SelectedItem is NewsLocalTypesModel && (c.SelectedItem as NewsLocalTypesModel).TypeID != 0).ToList();
            if (nurs.Count <= 0 || locals.Count <= 0)
            {
                new UgMessageBox("سىز تېخى تۈر تاللىمىدىڭىز، قايتا تاللاڭ", Color.Red).ShowDialog();
                return;
            }
            List<int> ids = new List<int>();
            foreach (var item in nurs)
            {
                NurNewsTypeModel nn = item.SelectedItem as NurNewsTypeModel;
                ids.Add(nn.TypeID);
            }
            if (ids.Count > ids.Distinct().Count())
            {
                //确定有重复
                new UgMessageBox("نۇر تورى تۈر تىزىملىكىدە قايتىلانغان مەزمۇن بار، تەكشۈرۈڭ", Color.Red).ShowDialog();
                return;
            }
            //没有重复,本地类别可以重复

            //筛选所有的没有选择的想
            cmbs = cmbs.Where(c => c.SelectedIndex != 0).ToList();
            //一对一集合
            List<TwoNewsModel> tweList = new List<TwoNewsModel>();
            foreach (var item in nurs)
            {
                //来自 nur.cn
                NurNewsTypeModel nurType = item.SelectedItem as NurNewsTypeModel;
                string nurName = item.Name;
                string id = nurName.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)[1];
                //来自本地
                ComboBox cm = locals.FirstOrDefault(c => c.Name.Split(new char[] { '_' })[1] == id);
                if (cm != null)
                {
                    //添加到集合中
                    NewsLocalTypesModel localType = cm.SelectedItem as NewsLocalTypesModel;
                    TwoNewsModel tw = new TwoNewsModel();
                    tw.NurTypeID = nurType.TypeID;
                    tw.NurTypeTitle = nurType.Title;
                    tw.LocalTypeID = localType.TypeID;
                    tw.LocalTypeTitle = localType.TypeTitle;
                    tweList.Add(tw);
                }
            }
            if (tweList.Count <= 0)
            {
                //没有一对一
                new UgMessageBox("سىز تاللىغان تۈرلەر بىر-بىرىگە ماس ئەمەس، تەكشۈرۈڭ ياكى قايتا تاللاڭ", Color.Red).ShowDialog();
                return;
            }

            //完成
            AllModel.News = tweList;
            //判断两者是否相等
            if (AllModel.NurNewsTypeList.Count > tweList.Count)
            {
                //重新写入日记文件
                AllModel.NurNewsTypeList = (from tp in AllModel.NurNewsTypeList
                                           where tweList.Select(c => c.NurTypeID).Contains(tp.TypeID)
                                           select tp).ToList();

                string jss = JsonConvert.SerializeObject(AllModel.NurNewsTypeList);
                File.WriteAllText("log\\nurnewstypes.log", jss);
            }
            //写入到本地
            string js = JsonConvert.SerializeObject(tweList);
            File.WriteAllText("log\\twonewsmodels.log", js);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
