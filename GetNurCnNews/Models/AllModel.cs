using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetNurCnNews
{
    public class AllModel
    {
        /// <summary>
        /// nur.cn 新闻类别集合
        /// </summary>
        public static List<NurNewsTypeModel> NurNewsTypeList { get; set; }

        /// <summary>
        /// 新闻一对一对象集合
        /// </summary>
        public static List<TwoNewsModel> News { get; set; }

        /// <summary>
        /// 本地新闻类别集合
        /// </summary>
        public static List<NewsLocalTypesModel> NewsLocalTypes { get; set; }
    }
}
