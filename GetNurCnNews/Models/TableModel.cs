using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetNurCnNews
{
    public class TableModel
    {
        /// <summary>
        /// 新闻在 nur 的ID
        /// </summary>
        public int NurID { get; set; }
        /// <summary>
        /// 新闻在线类别ID
        /// </summary>
        public int NurTypeID { get; set; }
        /// <summary>
        /// 新闻在线类别
        /// </summary>
        public string NurTypeTitle { get; set; }
        /// <summary>
        /// 本地类别ID
        /// </summary>
        public int LocalTypeID { get; set; }
        /// <summary>
        /// 本地类别
        /// </summary>
        public string LocalTypeTitle { get; set; }
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 新闻标题图片地址
        /// </summary>
        public string NewsLogoImg { get; set; }

        /// <summary>
        /// 是否选择
        /// </summary>
        public bool IsSelect { get; set; }

        /// <summary>
        /// 新闻内容
        /// </summary>
        public string NewsContent { get; set; }

        /// <summary>
        /// 描述文本
        /// </summary>
        public string Des { get; set; }

        /// <summary>
        /// 发表者
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 发布作者
        /// </summary>
        public string NickName { get; set; }

    }
}
