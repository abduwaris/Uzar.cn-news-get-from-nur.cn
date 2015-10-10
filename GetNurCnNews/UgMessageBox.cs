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
    public partial class UgMessageBox : Form
    {
        public UgMessageBox(string msg,string title,Color titleColor)
        {
            InitializeComponent();
            txtMsg.Text = msg;
            lblTitle.Text = title;
            lblTitle.ForeColor = titleColor;
        }

        public UgMessageBox(string msg)
        {
            InitializeComponent();
        }

        public UgMessageBox(string msg, string title)
        {
            InitializeComponent();
            txtMsg.Text = msg;
            lblTitle.Text = title;
        }

        public UgMessageBox(string msg, Color titleColor)
        {
            InitializeComponent();
            txtMsg.Text = msg;
            lblTitle.ForeColor = titleColor;
        }
    }
}
