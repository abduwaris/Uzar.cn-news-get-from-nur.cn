using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GetNurCnNews
{
    public class Dal
    {
        public static int Add(TableModel table)
        {
            DateTime dt = new DateTime(1970, 1, 1, 12, 0, 0, 0);
            DateTime dl = DateTime.Now;
            int tick = Convert.ToInt32(((dl - dt).Ticks).ToString().Substring(0, 10));
            string sql = "Insert into `mrq_hawar`(`tur`,`turs`,`title`,`pic`,`date`,`text`,`jtext`,`author`,`url`) Values(@t,1,@tit,@p,@d,@txt,@jt,@a,@u)";
            MySqlParameter[] param = { 
                  new MySqlParameter("@t",table.LocalTypeID),
                  new MySqlParameter("@tit",table.Title),
                  new MySqlParameter("@p",table.NewsLogoImg),
                  new MySqlParameter("@d",tick),
                  new MySqlParameter("@txt",table.NewsContent),
                  new MySqlParameter("@jt",table.Des),
                  new MySqlParameter("@a",table.NickName),
                  new MySqlParameter("@u",table.Source)
                                     };
            return MySqlHelper.Insert(sql, param);
        }
    }
}
