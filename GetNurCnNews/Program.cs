using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Drawing;

namespace GetNurCnNews
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //测试
            //Application.Run(new FrmLoading());
            //特定变量
            bool hasLog = false;
            DialogResult dr = DialogResult.No;
            //先判断数据库配置文件是否存在
            //第一个窗口    数据库配置窗口
            if (File.Exists("log\\constr.log"))
            {
                try
                {
                    //获取数据
                    DBModel db = new DBModel();
                    db = JsonConvert.DeserializeObject<DBModel>(File.ReadAllText("log\\constr.log", Encoding.UTF8));
                    if (MySqlHelper.IsOpen(db))
                    {
                        hasLog = true;
                    }
                    else
                    {
                        new UgMessageBox("ئالدىنقى قېتىم ساقلانغان ساندان سەپلىمە خاتىرە ھۆججىتىدە خاتالىق بار", Color.Red).ShowDialog();
                    }
                }
                catch (Exception e)
                {
                    new UgMessageBox("ئالدىنقى قېتىم ساقلانغان ساندان سەپلىمە خاتىرە ھۆججىتىدە خاتالىق بار", Color.Red).ShowDialog();
                }
                hasLog = true;

            }
            //接受是否包含日记文件,不存在日记文件,循环执行
            if (!hasLog)
            {
                //循环显示数据库配置窗口
                while (dr != DialogResult.OK)
                {
                    //显示窗口
                    dr = new FrmDataBase().ShowDialog();
                }
            }
            //第一个窗口完了


            //第二个窗口     nur.cn 新闻类别配置窗口
            hasLog = false;
            dr = DialogResult.No;
            //是否存在nur.cn新闻类别日记文件
            if (File.Exists("log\\nurnewstypes.log"))
            {
                try
                {
                    //获取数据
                    List<NurNewsTypeModel> nurNewsTypes = new List<NurNewsTypeModel>();
                    nurNewsTypes = JsonConvert.DeserializeObject<List<NurNewsTypeModel>>(File.ReadAllText("log\\nurnewstypes.log", Encoding.UTF8));
                    //不发生错误
                    AllModel.NurNewsTypeList = nurNewsTypes;
                    hasLog = true;
                }
                catch (Exception e)
                {
                    new UgMessageBox("ئالدنقى قېتىمدا ساقلانغان نۇر تورى خەۋەر تۈرلىرى سەپلىمە ھۆججىتىدە خاتالىق بار", Color.Red).ShowDialog();
                }
            }

            if (!hasLog)
            {
                while (dr != DialogResult.OK)
                {
                    dr = new FrmSelectNurNewsType().ShowDialog();
                }
            }
            //第二个窗口完了
            //第三个窗口     本地新闻类别配置窗口
            hasLog = false;
            dr = DialogResult.No;
            if (File.Exists("log\\newslocaltypes.log"))
            {
                try
                {
                    //获取数据
                    List<NewsLocalTypesModel> newsLocalTypes = new List<NewsLocalTypesModel>();
                    newsLocalTypes = JsonConvert.DeserializeObject<List<NewsLocalTypesModel>>(File.ReadAllText("log\\newslocaltypes.log", Encoding.UTF8));
                    //不发生错误
                    AllModel.NewsLocalTypes = newsLocalTypes;
                    hasLog = true;
                }
                catch (Exception e)
                {
                    new UgMessageBox("ئالدنقى قېتىمدا ساقلانغان يەرلىك خەۋەر تۈرلىرى سەپلىمە ھۆججىتىدە خاتالىق بار", Color.Red).ShowDialog();
                }
            }
            if (!hasLog)
            {
                while (dr != DialogResult.OK)
                {
                    dr = new FrmLocalTypes().ShowDialog();
                }
            }
            //第三个窗口完了
            //第四个窗口     一对一配置窗口
            hasLog = false;
            dr = DialogResult.No;
            if (File.Exists("log\\twonewsmodels.log"))
            {
                try
                {
                    List<TwoNewsModel> tweNews = new List<TwoNewsModel>();
                    tweNews = JsonConvert.DeserializeObject<List<TwoNewsModel>>(File.ReadAllText("log\\twonewsmodels.log"));
                    //不发生错误
                    AllModel.News = tweNews;
                    hasLog = true;
                }
                catch (Exception e)
                {
                    new UgMessageBox("ئالدنقى قېتىمدا ساقلانغان خەۋەر تۈرلىرى سېلىشتۇرما ھۆججىتىدە خاتالىق بار", Color.Red).ShowDialog();
                }
            }
            if (!hasLog)
            {
                while (dr != DialogResult.OK)
                {
                    dr = new FrmNewsConfig().ShowDialog();
                }
            }
            //显示主窗口
            Application.Run(new FrmHome());

        }
    }
}
