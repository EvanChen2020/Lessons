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

    public partial class FrmAddStudent : Form
    {

        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        
        
        public FrmAddStudent()
        {
            InitializeComponent();
            //初始化班级下拉框
            this.cboClassName.DataSource = objClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1; // default we didn't select a class
        }

        //Ìí¼ÓÐÂÑ§Ô±
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region check input data
            if (this.txtStudentName.Text.Trim().Length==0)
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
            if (this.cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("Please select the Class!", "information");
                return;
            }
            if (this.txtStudentIdNo.Text.Trim().Length==0)
            {
                MessageBox.Show("Id number is empty!", "information");
                return;
            }
            if (!Common.DataValidate.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("Incorrect identity Number!","Data Vailidate check");
                this.txtStudentIdNo.Focus();
                return;
            }
            if (objStudentService.IsIdNoExisted(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("Id number exit!", "Data Vailidate check");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age<10||age>35)
            {
                MessageBox.Show("age must be between 18 and 35", "Data validate check");
                return;
            }
            #endregion

            #region create sutdent object
            Student objStudent = new Student()
            {
                StudentName = this.txtStudentName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "n" : "nv",
                BirthDay = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = Convert.ToInt64(this.txtStudentIdNo.Text.Trim()),
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StudentAddress = this.txtAddress.Text.Trim(),
                CardNo = this.txtCardNo.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year
            };
            #endregion

            #region call data base access function and insert object
            try
            {
                if (objStudentService.AddStudent(objStudent)==1)
                {
                    DialogResult result = MessageBox.Show("success! continue?", "information",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (result == DialogResult.Yes)
                    {
                        this.cboClassName.SelectedIndex = -1;
                        this.rdoFemale.Checked = false;
                        this.rdoMale.Checked = false;

                        foreach (Control item in this.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = "";
                            }
                        }
                        this.txtStudentName.Focus();
                    }
                    else
                        this.Close();

                }
                else
                {
                    MessageBox.Show("insert failed!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            #endregion
        }
        //¹Ø±Õ´°Ìå
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //´°ÌåÒÑ¾­±»¹Ø±Õ
        private void FrmAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAddStudent = null;//当窗体关闭后，将窗体在内存中清理掉
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}