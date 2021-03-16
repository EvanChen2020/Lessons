using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _3_3_DAL;
using _3_3_Models;

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            //   string connString = _3_3_DAL.SQLHelper.connString;
            // connString = Common.StringSecurity.DESEncrypt(connString);
            //???????
            this.lblCurrentUser.Text = Program.objCurrentAdmin.AdminName;


        }


        ////ÏÔÊ¾Ìí¼ÓÑ§Ô±´°Ìå
        //private void tsmiAddStudent_Click(object sender, EventArgs e)
        //{
        //    FrmAddStudent objAddStudent = new FrmAddStudent();
        //    objAddStudent.ShowDialog();
        //}

        public static FrmAddStudent objFrmAddStudent = null;

        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            if (objFrmAddStudent==null)
            {
                objFrmAddStudent = new FrmAddStudent();
                 objFrmAddStudent.Show();
               // objFrmAddStudent.ShowDialog();
            }
            else
            {
                objFrmAddStudent.Activate();//??????????????
                objFrmAddStudent.WindowState = FormWindowState.Normal;
            }
            
        }

        public static FrmStudentManage objFrmStuManage = null;
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {
            if (objFrmStuManage == null)
            {
                objFrmStuManage = new FrmStudentManage();
                objFrmStuManage.Show();
                // objFrmAddStudent.ShowDialog();
            }
            else
            {
                objFrmStuManage.Activate();//??????????????
                objFrmStuManage.WindowState = FormWindowState.Normal;
            }
        }
        //显示成绩查询与分析窗口
        public static FrmScoreManage objFrmScoreManage = null;

        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            if (objFrmScoreManage == null)
            {
                objFrmScoreManage = new FrmScoreManage();
                objFrmScoreManage.Show();
                // objFrmAddStudent.ShowDialog();
            }
            else
            {
                objFrmScoreManage.Activate();//??????????????
                objFrmScoreManage.WindowState = FormWindowState.Normal;
            }
        }
        //ÍË³öÏµÍ³
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //成绩快速查询
        public static FrmScoreQuery objFrmScoreQuery = null;

        private void tsmiQuery_Click(object sender, EventArgs e)
        {
            if (objFrmScoreManage == null)
            {
                objFrmScoreQuery = new FrmScoreQuery();
                objFrmScoreQuery.Show();
                // objFrmAddStudent.ShowDialog();
            }
            else
            {
                objFrmScoreQuery.Activate();//??????????????
                objFrmScoreQuery.WindowState = FormWindowState.Normal;
            }
        }
        //修改密码
        public static FrmModifyPwd objFrmModifyPwd = null;

        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {
            if (objFrmScoreManage == null)
            {
                objFrmModifyPwd = new FrmModifyPwd();
                objFrmModifyPwd.Show();
                // objFrmAddStudent.ShowDialog();
            }
            else
            {
                objFrmModifyPwd.Activate();//??????????????
                objFrmModifyPwd.WindowState = FormWindowState.Normal;
            }
        }

        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }

        public static FrmAttendance objFrmAttendance = null;

        private void tsmi_Card_Click(object sender, EventArgs e)
        {
            if (objFrmAttendance == null)
            {
                objFrmAttendance = new FrmAttendance();
                objFrmAttendance.Show();
                // objFrmAddStudent.ShowDialog();
            }
            else
            {
                objFrmAttendance.Activate();//??????????????
                objFrmAttendance.WindowState = FormWindowState.Normal;
            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit?", "Exit Query", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result !=DialogResult.OK)
            {
                //????????
                e.Cancel = true;
            }
        }
    }
}