using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetNurCnNews
{
    public class AutomaticGet
    {
        /// <summary>
        /// 是否自动收集
        /// </summary>
        public bool IsAutomatic { get; set; }

        /// <summary>
        /// 每个几个小时一次自动启动收集新闻的 时间距
        /// </summary>
        public int InHours { get; set; }

        /// <summary>
        /// 已知类别中,每个类别寻找的最大页数
        /// </summary>
        public int MaxPageCount { get; set; }



    }
}
