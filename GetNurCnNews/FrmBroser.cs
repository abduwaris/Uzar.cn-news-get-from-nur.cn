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
    public partial class FrmBroser : Form
    {
        /// <summary>
        /// 浏览器地址
        /// </summary>
        /// <param name="url"></param>
        public FrmBroser(string url, string title)
        {
            InitializeComponent();
            webBrowser1.Url = new Uri(url);
            this.Text = title;
        }
    }
}
