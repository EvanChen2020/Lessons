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
    public partial class FrmEditStudent : Form
    {
        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        
        public FrmEditStudent()
        {
            InitializeComponent();
            //初始化班级下拉框
            this.cboClassName.DataSource = objClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1; // default we didn't select a class

        }
        public FrmEditStudent(StudentExt objStudent)
            :this()
        {
            //显示学员信息
            this.txtStudentId.Text = objStudent.StudentId.ToString();
            this.txtStudentName.Text = objStudent.StudentName;
            this.txtStudentIdNo.Text = objStudent.StudentIdNo.ToString();
            this.txtPhoneNumber.Text = objStudent.PhoneNumber;
            this.dtpBirthday.Text = objStudent.BirthDay.ToShortDateString();
            this.txtAddress.Text = objStudent.StudentAddress;
            if (objStudent.Gender == "n") this.rdoMale.Checked = true;
            else this.rdoFemale.Checked = true;
  
            this.cboClassName.Text = objStudent.ClassName;
            this.txtCardNo.Text = objStudent.CardNo;
        }


        //Ìá½»ÐÞ¸Ä
        private void btnModify_Click(object sender, EventArgs e)
        {
            #region check input data

            if (this.txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student Name can't be empty!", "information");
                this.txtStudentName.Focus();
                return;
            }
            // others data check
            if (!this.rdoFemale.Checked && !this.rdoMale.Checked)
            {
                MessageBox.Show("Please select the gender!", "information");
                return;
            }
            if (this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Class!", "information");
                return;
            }
            if (this.txtStudentIdNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Id number is empty!", "information");
                return;
            }
            if (!Common.DataValidate.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("Incorrect identity Number!", "Data Vailidate check");
                this.txtStudentIdNo.Focus();
                return;
            }
          
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age < 10 || age > 35)
            {
                MessageBox.Show("age must be between 18 and 35", "Data validate check");
                return;
            }
            //判断身份证是否重复
            if (objStudentService.IsIdNoExisted(this.txtStudentIdNo.Text.Trim(),this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("the Id or student Id existed!", "information");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }

            #endregion

            #region create sutdent object
            Student objStudent = new Student()
            {
                StudentId = Convert.ToInt32(this.txtStudentId.Text.Trim()),
                StudentName = this.txtStudentName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "n" : "nv",
                BirthDay = Convert.ToDateTime (this.dtpBirthday.Text),
                StudentIdNo = Convert.ToInt64(this.txtStudentIdNo.Text.Trim()),
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StudentAddress = this.txtAddress.Text.Trim(),
                CardNo = this.txtCardNo.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year
            };
            #endregion

            #region communcate with data base
            try
            {
                if (objStudentService.ModifyStudent(objStudent) == 1)
                {
                    MessageBox.Show("modify success!", "information");
                    
                    this.DialogResult = DialogResult.OK;//返回修改成功的信息
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}