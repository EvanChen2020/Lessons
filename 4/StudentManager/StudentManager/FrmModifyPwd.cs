using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace StudentManager
{
    public partial class FrmModifyPwd : Form
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
        }
        //修改密码
       
        private void btnModify_Click(object sender, EventArgs e)
        {
            #region
            if (txtNewPwd.Text.Trim().Length<6)
            {
                MessageBox.Show("新密码不能少于6位", "提示信息");
                    return;
            }
            if (txtOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("老密码不能为空", "提示信息");
                txtOldPwd.Focus();
                    return;
            }
            if (txtNewPwd.Text.Trim() != txtNewPwdConfirm.Text.Trim())
            {
                MessageBox.Show("两次新密码不一致", "提示信息");
                    return;
            }
            if (this.txtOldPwd.Text.Trim()!=Program.currentAdmin.LoginPwd)
            {
                MessageBox.Show("请输入正确的密码", "提示信息");
                txtOldPwd.Focus();
                txtOldPwd.SelectAll();
                return;
            }
            #endregion
            SysAdminService objSysAdminService = new SysAdminService();
            try
            {
                int Result = objSysAdminService.ModifyPwd(new SysAdmin()
                {
                    LoginId = Program.currentAdmin.LoginId,
                    LoginPwd = txtNewPwd.Text.Trim()
                });
                if (Result == 1)
                {
                    MessageBox.Show("修改成功", "提示信息");
                    Program.currentAdmin.LoginPwd = txtNewPwd.Text.Trim();
                    this.Close();
                }
                else
                    MessageBox.Show("老密码错误", "提示信息");

            }
            catch (Exception ex)
            {

                MessageBox.Show("数据库通讯错误：" + ex.Message, "提示信息");
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
