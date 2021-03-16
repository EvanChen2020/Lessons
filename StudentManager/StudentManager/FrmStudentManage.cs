using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using _3_3_DAL;
using _3_3_Models;

namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {
        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStuService = new StudentService();
       
        public FrmStudentManage()
        {
            InitializeComponent();
            //初始化班级下拉框
            this.cboClass.DataSource = objClassService.GetAllClasses();
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1; // default we didn't select a class

        }
        //°´ÕÕ°à¼¶²éÑ¯
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex==-1)
            {
                MessageBox.Show("please select class", "information");
                return;
            
            }
            this.dgvStudentList.Columns[3].DefaultCellStyle.Format = "yyy-MM-dd";
            this.dgvStudentList.AutoGenerateColumns = false;
            //执行查询
            this.dgvStudentList.DataSource = objStuService.GetStudentByClass(
                this.cboClass.Text);

        }
        //¸ù¾ÝÑ§ºÅ²éÑ¯
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            if (this.txtStudentId.Text.Trim().Length==0)
            {
                MessageBox.Show("please input student ID!","information");
                this.txtStudentId.Focus();
                return;
            }

            //进一步验证，用正则表达式验证学号必须是数字
            StudentExt objStudent = objStuService.GetStudentById(this.txtStudentId.Text.Trim());
            if (objStudent==null)
            {
                MessageBox.Show("No Student!", "Information");
            this.txtStudentId.Focus();
            }
            else
            {
                //在学员详细信息显示
                (new FrmStudentInfo(objStudent)).Show();
            }

        }
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13 && this.txtStudentId.Text.Trim().Length!=0)
            {
                btnQueryById_Click(null, null);
            }
        }
        //Ë«»÷Ñ¡ÖÐµÄÑ§Ô±¶ÔÏó²¢ÏÔÊ¾ÏêÏ¸ÐÅÏ¢
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvStudentList.CurrentRow!=null)
            {
                string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
                this.txtStudentId.Text = studentId;
                btnQueryById_Click(null, null);
            }
        }
        //ÐÞ¸ÄÑ§Ô±¶ÔÏó
        private void btnEidt_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("no student", "information");
            }
            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("Plese select one student", "information");
                return;
            }

            //获取学号
            string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            //获取要修改的学员详细信息
            StudentExt objStudent = objStuService.GetStudentById(studentId);
            //显示要修改的学员信息窗口
            FrmEditStudent objEditStudent = new FrmEditStudent(objStudent);
            DialogResult result = objEditStudent.ShowDialog();
            //判断修改是否成功
            if (result==DialogResult.OK)
            {
                btnQuery_Click(null, null);//同步刷新修改的信息（适合查询数据量小的情况）
            }

        }       
        //É¾³ýÑ§Ô±¶ÔÏó
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("no student", "information");
            }
            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("Plese select one student", "information");
                return;
            }
            string studentName = this.dgvStudentList.CurrentRow.Cells["StudentName"].Value.ToString();

            //删除确认
            DialogResult result = MessageBox.Show("Delete student {"+studentName+"}?", "Delete Query", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;

            //获取学号
            string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
          
            try
            {
                if (objStuService.DeleteStudentById(studentId)==1)
                {
                    btnQuery_Click(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"information");
            }
        }
        private void FrmSearchStudent_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        //¹Ø±Õ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStudentManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmStuManage = null;//当窗体关闭后，将窗体在内存中清理掉

        }

        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }

        private void tsmidDeleteStu_Click(object sender, EventArgs e)
        {
            btnDel_Click(null, null);
        }
    }
}