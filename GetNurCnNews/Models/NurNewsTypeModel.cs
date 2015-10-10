using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetNurCnNews
{
    /// <summary>
    /// 新闻类别模型
    /// </summary>
    public class NurNewsTypeModel
    {
        /// <summary>
        /// 新闻类别ID
        /// </summary>
        public int TypeID { get; set; }
        /// <summary>
        /// 新闻类别标题
        /// </summary>
        public string Title { get; set; }

        public override string ToString()
        {
            return this.Title + " (" + this.TypeID + ")";
        }
    }
}
