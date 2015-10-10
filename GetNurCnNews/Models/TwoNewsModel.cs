using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetNurCnNews
{
    /// <summary>
    /// 新闻一对一对象
    /// </summary>
    public class TwoNewsModel
    {
        /// <summary>
        /// 在线ID
        /// </summary>
        public int NurTypeID { get; set; }
        /// <summary>
        /// 在线标题
        /// </summary>
        public string NurTypeTitle { get; set; }
        /// <summary>
        /// 本地 ID
        /// </summary>
        public int LocalTypeID { get; set; }
        /// <summary>
        /// 本地 标题
        /// </summary>
        public string LocalTypeTitle { get; set; }
    }
}
