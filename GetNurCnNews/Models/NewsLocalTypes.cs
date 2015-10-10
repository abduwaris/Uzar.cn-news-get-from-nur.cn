using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetNurCnNews
{
    public class NewsLocalTypesModel
    {
        public int TypeID { get; set; }
        public string TypeTitle { get; set; }

        public override string ToString()
        {
            return this.TypeTitle + " (" + this.TypeID + ")";
        }
    }
}
