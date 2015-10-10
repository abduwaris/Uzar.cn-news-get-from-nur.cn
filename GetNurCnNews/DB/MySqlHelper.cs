
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
namespace GetNurCnNews
{
    public class MySqlHelper
    {
        //第一行为注释
        private static string ConStr;

        public static void SetConStr()
        {
            string strjosn = File.ReadAllText("log\\constr.log");
            DBModel db = JsonConvert.DeserializeObject<DBModel>(strjosn);
            MySqlConnectionStringBuilder msc = new MySqlConnectionStringBuilder();
            msc.CharacterSet = "utf8";
            msc.Server = db.Server;
            msc.Database = db.DataBase;
            msc.UserID = db.User;
            msc.Password = db.PassWord;
            ConStr = msc.GetConnectionString(!string.IsNullOrEmpty(db.PassWord));
            if (string.IsNullOrEmpty(db.PassWord))
            {
                ConStr = string.Format("Server={0};Database={1}; User={2};", db.Server, db.DataBase, db.User);
            }
            else
            {
                ConStr = string.Format("Server={0};Database={1}; User={2};Password={3};", db.Server, db.DataBase, db.User, db.PassWord);
            }
        }


        /// <summary>
        /// 判断数据库是否连接成功
        /// </summary>
        /// <param name="path">是否从日记文件中读取连接字符串</param>
        /// <returns></returns>
        public static bool IsOpen(bool b)
        {
            if (b)
            {
                SetConStr();
            }
            using (MySqlConnection con = new MySqlConnection(ConStr))
            {
                try
                {
                    con.Open();
                    return con.State == System.Data.ConnectionState.Open;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 判断数据库是否连接成功
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static bool IsOpen(DBModel db)
        {
            string str;
            //现这个连接字符串测试
            MySqlConnectionStringBuilder msc = new MySqlConnectionStringBuilder();
            msc.CharacterSet = "utf8";
            msc.Server = db.Server;
            msc.Database = db.DataBase;
            msc.UserID = db.User;
            msc.Password = db.PassWord;
            str = msc.GetConnectionString(!string.IsNullOrEmpty(db.PassWord));

            using (MySqlConnection con = new MySqlConnection(str))
            {
                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        //连接成功
                        //生成连接字符串
                        ConStr = str;
                        //写入到日记中
                        string dbjson = JsonConvert.SerializeObject(db);
                        if (!Directory.Exists("log")) Directory.CreateDirectory("log");
                        File.WriteAllText("log\\constr.log", dbjson, Encoding.UTF8);
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int Insert(string sql, params MySqlParameter[] param)
        {
            using (MySqlConnection con = new MySqlConnection(ConStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    if (param != null) cmd.Parameters.AddRange(param);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }


        public static object GetFirst(string sql, params MySqlParameter[] param)
        {
            using (MySqlConnection con = new MySqlConnection(ConStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    if (param != null) cmd.Parameters.AddRange(param);
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
