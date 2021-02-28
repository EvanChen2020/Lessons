﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace StudentManager
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

            //创建登录窗体
            FrmUserLogin objFrmLogin = new FrmUserLogin();
            DialogResult result= objFrmLogin.ShowDialog();
           //判读登录是否成功
            if (result==DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();//退出整个应用
            }
            
        }

        //定义一个全局变量保存用户对象
        public static _3_3_Models.SysAdmin objCurrentAdmin = null;

    }
}
