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
    public partial class FrmLocalTypes : Form
    {
        List<NewsLocalTypesModel> types;
        public FrmLocalTypes()
        {
            InitializeComponent();
            types = new List<NewsLocalTypesModel>();
        }

        private void FrmLocalTypes_Load(object sender, EventArgs e)
        {
            //新建几个类型
            int[] ids = { 2, 16, 17, 18, 19, 20, 21, 22, 23 };
            string[] ts = { "خەلىقئارا", "شىنجاڭ", "مەملىكەت", "تەنتەربىيە", "ئىقتىساد", "سەنئەت", "پەن - تېخنكا", "غەلىتە ئىشلار", "رەسملىك" };
            for (int i = 0; i < ids.Length; i++)
            {
                NewsLocalTypesModel mm = new NewsLocalTypesModel();
                mm.TypeID = ids[i];
                mm.TypeTitle = ts[i];
                types.Add(mm);
            }

            //绑定数据
            DataBindToListBox();
        }

        /// <summary>
        /// 数据库绑定
        /// </summary>
        void DataBindToListBox()
        {
            lbList.Items.Clear();
            foreach (var item in types)
            {
                lbList.Items.Add(item);
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtTypeID.Text.Trim(), out id))
            {
                new UgMessageBox("يەرلىكتىكى تۈر نۇمۇرى چۇقۇم سان بۇلىشى كىرەك،ھەم بوش قالماسلىقى كىرەك،سانلارنىڭ ئارىسىدا بۇش ئورۇن بارمۇ يوق قاراپ بېقىڭ!", Color.Red).ShowDialog();
                return;
            }
            if (string.IsNullOrEmpty(txtTypeTitle.Text.Trim()))
            {
                new UgMessageBox("تۇر نامى بوش قالمىسۇن، بۇ ئىككى تۈر نامىنى سېلىشتۇرۇش ئۈچۈن ئىشلىتىلىدۇ", Color.Red).ShowDialog();
                return;
            }
            //判断ID是否存在
            if (types.Where(t => t.TypeID == id).Count() > 0)
            {
                new UgMessageBox("بۇت تۈر ئاللىبۇرۇن قوشۇلغان، قايتا قوشالمايسىز!~", Color.Red).ShowDialog();
                return;
            }
            //可以添加
            NewsLocalTypesModel tp = new NewsLocalTypesModel();
            tp.TypeID = id;
            tp.TypeTitle = txtTypeTitle.Text.Trim();
            types.Add(tp);
            DataBindToListBox();
            new UgMessageBox("بۇ تۈر مۇۋاپىقىيەتلىك قوشۇلدى", Color.Green).ShowDialog();
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lbList.Items.Count <= 0)
            {
                new UgMessageBox("تۈر سانى ئەڭ ئاز بولغاندىمۇ بىر بۇلىشى كىرەك", Color.Red).ShowDialog();
                return;
            }
            //可以
            AllModel.NewsLocalTypes = types;
            //写入到日记文件中
            string jstr = JsonConvert.SerializeObject(types);
            File.WriteAllText("log\\newslocaltypes.log", jstr);
            new UgMessageBox("مۇۋاپىقىيەتلىك بولدى", Color.Red).ShowDialog();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// 删除集合项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbList.SelectedItems.Count > 0)
            {
                foreach (var item in lbList.SelectedItems)
                {
                    NewsLocalTypesModel nl = item as NewsLocalTypesModel;
                    types = types.Where(t => t.TypeID != nl.TypeID).ToList();
                }
                DataBindToListBox();
            }
        }
    }
}
