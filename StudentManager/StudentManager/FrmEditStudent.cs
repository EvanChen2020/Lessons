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
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}