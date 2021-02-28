using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _3_3_DAL;
using _3_3_Models;


namespace StudentManager
{
    public partial class FrmUserLogin : Form
    {
        //创建数据类访问对象
        private SysAdminService objAdminService = new SysAdminService();
       
        public FrmUserLogin()
        {
            InitializeComponent();
        }


        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //【1】数据验证
            if (this.txtLoginId.Text.Trim().Length==0)
            {
                MessageBox.Show("Please input your account!", "Login information");
                this.txtLoginId.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Trim().Length== 0)
            {
                MessageBox.Show("Please input your password!", "Login information");
                this.txtLoginPwd.Focus();
                return;
            }

            //【2】封装对象
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim()
            };

            //【3】 和后台交互，判断登录信息是否正确
            try
            {
                objAdmin = objAdminService.AdminLogin(objAdmin);
                if (objAdmin!=null)//如果登录成功
                {
                    //保存登录信息
                    Program.objCurrentAdmin = objAdmin;
                    //设置登录窗体的返回值
                    this.DialogResult = DialogResult.OK;
                    //关闭窗体
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Account or Password is Wrong!", "Login information");
                };

            }
            catch (Exception ex)
            {

                MessageBox.Show("Access data base exception, login failed! The reason is: " + ex.Message);
            }
           

        }
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 改善用户体验
        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                if (this.txtLoginId.Text.Trim().Length!=0)
                {
                    this.txtLoginPwd.Focus();//将当前的焦点跳转到密码框
                  //  this.txtLoginPwd.SelectAll();
                }
            }
            
        }
        private void txtLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (this.txtLoginPwd.Text.Trim().Length != 0)
                {
                    btnLogin_Click(null,null);//直接调用登录按钮的事件
                }
            }
        }
        #endregion


    }
}
