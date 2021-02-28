using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using _3_3_Models;

namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        public FrmStudentInfo(StudentExt objStudent)
            :this()
        {
            //显示学员信息
            this.lblStudentName.Text = objStudent.StudentName;
            this.lblStudentIdNo.Text = objStudent.StudentIdNo.ToString();
            this.lblPhoneNumber.Text = objStudent.PhoneNumber;
            this.lblBirthday.Text = objStudent.BirthDay.ToShortDateString();
            this.lblAddress.Text = objStudent.StudentAddress;
            this.lblGender.Text = objStudent.Gender;
            this.lblClass.Text = objStudent.ClassName;
            this.lblCardNo.Text = objStudent.CardNo;
        }

        //¹Ø±Õ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}