using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;


namespace StudentManager
{
    public partial class FrmUserLogin : Form
    {
        private SysAdminService objSysAdminService = new SysAdminService();
        public FrmUserLogin()
        {
            InitializeComponent();
        }


        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txtLoginId.Text.Trim().Length==0)
            {
                MessageBox.Show("Id is empty!", "information");
                this.txtLoginId.Focus();
                return;
            }
            if (!Common.DataValidate.IsInteger(this.txtLoginId.Text.Trim()))
            {
                MessageBox.Show("Id must be integer!", "information");
                this.txtLoginId.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Trim().Length==0)
            {
                MessageBox.Show("Password ie empty!", "information");
                this.txtLoginPwd.Focus();
                return;
            }
            //登录账号和密码不能包含危险字符（<>,)

            //封装对象
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim()
            };
            //和后台交互
            try
            {
              Program.currentAdmin=  objSysAdminService.AdminLogin(objAdmin);
                if (Program.currentAdmin!=null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ID or Password is wrong", "information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "communicate with data base exception");
            }

            //处理交互结果（需要保存数据、需要返回值等）
        }
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //改进用户体验
        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtLoginId.Text.Trim().Length!=0 && e.KeyValue==13 )
            {
                this.txtLoginPwd.Focus();
                this.txtLoginPwd.SelectAll();
            }
        }

        private void txtLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtLoginPwd.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
