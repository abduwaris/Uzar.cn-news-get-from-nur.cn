using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetNurCnNews
{
    public class NewsModel
    {
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// nur.cn 上的 ID
        /// </summary>
        public int NurID { get; set; }
        /// <summary>
        /// nur.cn 类型ID
        /// </summary>
        public int NurTypeID { get; set; }

        /// <summary>
        /// Nur.Cn 类型名
        /// </summary>
        public string NurTypeTitle { get; set; }
        /// <summary>
        /// 新闻本地类型 ID
        /// </summary>
        public int LocalTypeID { get; set; }

        /// <summary>
        /// 本地类型 ID
        /// </summary>
        public string LocalTypeTitle { get; set; }

    }
}
