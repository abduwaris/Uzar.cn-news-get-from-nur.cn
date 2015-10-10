using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetNurCnNews
{
    public partial class FrmDataBase : Form
    {
        public FrmDataBase()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //验证控件内容
            if (!CheckInput())
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text ="بوش قالمىسۇن";
                return;
            }
            DBModel db = new DBModel();
            db.Server = txtHost.Text.Trim();
            db.DataBase = txtDataBase.Text.Trim();
            db.User = txtUserName.Text.Trim();
            db.PassWord = txtPassWord.Text;
            if (!MySqlHelper.IsOpen(db))
            {
                //连接失败
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "ساندانغا ئۇلانمىدى!~";
                return;
            }
            lblMsg.ForeColor = Color.Green;
            lblMsg.Text = "ساندانغا مۇۋاپىقىيەتلىك ئۇلاندى!~";
            System.Threading.Thread.Sleep(3000);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// 验证控件
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtHost.Text.Trim()) || string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtDataBase.Text.Trim()))
            {
                lblMsg.Text = "بوش قالمىسۇن";
                return false;
            }
            return true;
        }

        /// <summary>
        /// 验证是否
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
       {
            lblMsg.Text = "";
        }

       
    }
}
