using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using DAL;
using Models;

namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {
        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        private List<Student> stuList;

        public FrmStudentManage()
        {
            InitializeComponent();
            List<StudentClass> classList = new List<StudentClass>();
            classList = objClassService.GetAllClass();
            this.cboClass.DataSource = classList;
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.SelectedIndex = -1;
        }
        //°´ÕÕ°à¼¶²éÑ¯
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex==-1)
            {
                MessageBox.Show("请选择班级", "提示信息");
                return;
            }
            try
            {
                stuList = objStudentService.GetStudentByClass(cboClass.Text.Trim());
                this.dgvStudentList.AutoGenerateColumns = false;
                this.dgvStudentList.DataSource = stuList;
                new Common.DataGridViewStyle().DgvStyle1(this.dgvStudentList);

            }
            catch (Exception ex)
            {

                MessageBox.Show("数据库操作错误，错误信息：" + ex.Message, "提示信息");
            }
                        
        }
        //¸ù¾ÝÑ§ºÅ²éÑ¯
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入学号", "提示信息");
                return;
            }
            if (!Common.DataValidate.IsInteger(txtStudentId.Text.Trim()))
            {
                MessageBox.Show("请输入数字学号", "提示信息");
                txtStudentId.SelectAll();
                txtStudentId.Focus();
                return;
            }
            try
            {
                Student objStudent = objStudentService.GetStudentByStudentId(txtStudentId.Text.Trim());
                stuList = new List<Student>();
                if (objStudent == null)
                {
                    MessageBox.Show("学员信息不存在", "查询提示");
                    this.txtStudentId.Focus();
                    this.txtStudentId.SelectAll();
                    return;
                }
                else
                {
                    FrmStudentInfo frmStudentInfo = new FrmStudentInfo(objStudent);
                    frmStudentInfo.Show();
                 
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("数据库操作错误，错误信息：" + ex.Message, "提示信息");
            }
        }
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtStudentId.Text.Trim().Length>0 && e.KeyValue == 13)
            {
                btnQueryById_Click(null, null);
            }
        }
        //Ë«»÷Ñ¡ÖÐµÄÑ§Ô±¶ÔÏó²¢ÏÔÊ¾ÏêÏ¸ÐÅÏ¢
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvStudentList.CurrentRow ==null)
            {
                return;
            }

            string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            try
            {
                Student objStudent = objStudentService.GetStudentByStudentId(studentId);

                    FrmStudentInfo frmStudentInfo = new FrmStudentInfo(objStudent);
                    frmStudentInfo.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show("数据库操作错误，错误信息：" + ex.Message, "提示信息");
            }
        }
        //ÐÞ¸ÄÑ§Ô±¶ÔÏó
        private void btnEidt_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("没有任何需要修改的学员信息", "提示信息");
                return;
            }
            if (this.dgvStudentList.CurrentRow==null)
            {
                MessageBox.Show("请选中需要修改的学员信息", "提示信息");
                return;
            }
            //获取学号
            string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            Student objStudent = objStudentService.GetStudentByStudentId(studentId);
        //    objStudent.StudentId = Convert.ToInt32( studentId);
            //显示要修改的学员信息窗口
            FrmEditStudent objFrm = new FrmEditStudent(objStudent);
            if (objFrm.ShowDialog()==DialogResult.OK)
            {
                btnQuery_Click(null, null);
            }
           
        
        }
        //É¾³ýÑ§Ô±¶ÔÏó
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("没有任何需要删除的学员信息", "提示信息");
                return;
            }
            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("请选中需要删除的学员信息", "提示信息");
                return;
            }
            //删除前确认
            DialogResult diaResult = MessageBox.Show("确实要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diaResult==DialogResult.Cancel)
            {
                return;
            }
            //获取学号
            string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            int result=0;
            try
            {
                result = objStudentService.DeleteStudent(studentId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("删除失败，错误信息为：" + ex.Message);
            }
            //    objStudent.StudentId = Convert.ToInt32( studentId);
            if (result == 1)
            {
                btnQuery_Click(null, null); //适用于少量数据
            }
        }
        //ÐÕÃû½µÐò
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0) return;
            this.stuList.Sort(new NameDESC());
            this.dgvStudentList.Refresh();
        }
        //Ñ§ºÅ½µÐò
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0) return;
            this.stuList.Sort(new StudentIdDESC());
            this.dgvStudentList.Refresh();
        }
        //Ìí¼ÓÐÐºÅ
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);


        }
        //´òÓ¡µ±Ç°Ñ§Ô±ÐÅÏ¢
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //如果没有列表显示，则不显示打印
            if (this.dgvStudentList.RowCount==0||this.dgvStudentList.CurrentRow==null) 
            {
                return;
            }
            //获取当前学号
            string stuId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            //根据学号获取学员对象
            Student student = objStudentService.GetStudentByStudentId(stuId);
            //调用excel模块实现打印预览
            ExcelPrint.PrintStudent objPrintStudent = new ExcelPrint.PrintStudent();
            objPrintStudent.ExecPrint(student);



        }

        //¹Ø±Õ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //µ¼³öµ½Excel
        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        #region 实现排序

        class NameDESC : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return y.StudentName.CompareTo(x.StudentName);
            }
        }

        class StudentIdDESC : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return y.StudentId.CompareTo(x.StudentId);
            }
        }




        #endregion

        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }
    }


}