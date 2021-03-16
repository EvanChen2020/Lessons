using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DAL;
using Models;

namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }
        public FrmStudentInfo(Student objStudent)
            :this()
        {
            this.lblStudentName.Text = objStudent.StudentName;
            this.lblGender.Text = objStudent.Gender;
          //  this.lblBirthday.Text = objStudent.Birthday.ToShortDateString();
            this.lblBirthday.Text = objStudent.Birthday.ToString("yyyy-MM-dd");
            this.lblClass.Text = objStudent.ClassName;
            this.lblStudentIdNo.Text = objStudent.StudentIdNo;
            this.lblCardNo.Text = objStudent.CardNo;
            this.lblPhoneNumber.Text = objStudent.PhoneNumber;
            this.lblAddress.Text = objStudent.StudentAddress;
            //????
            this.pbStu.Image = objStudent.StuImage.Length != 0 ?
                (Image)new Common.SerializeObjectToString().DeserializeObject(objStudent.StuImage) :
                Image.FromFile("default.png");

        }


        //¹Ø±Õ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}