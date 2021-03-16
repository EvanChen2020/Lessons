using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Models;
using DAL;

namespace StudentManager
{
    public partial class FrmEditStudent : Form
    {
        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();

        public FrmEditStudent()
        {
            InitializeComponent();
            List<StudentClass> classList = objClassService.GetAllClass();
            this.cboClassName.DataSource = classList;
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1;
        }

        public FrmEditStudent(Student objStudent):this()
        {
            this.txtStudentId.Text = objStudent.StudentId.ToString();
            this.txtStudentName.Text = objStudent.StudentName;
            this.rdoFemale.Checked = objStudent.Gender.ToString()=="男"? false:true;
            this.rdoMale.Checked = objStudent.Gender.ToString() == "男" ? true : false;
            //  this.lblBirthday.Text = objStudent.Birthday.ToShortDateString();
            this.dtpBirthday.Value= Convert.ToDateTime(objStudent.Birthday.ToShortDateString());
            this.cboClassName.Text = objStudent.ClassName;
            this.txtStudentIdNo.Text = objStudent.StudentIdNo;
            this.txtCardNo.Text = objStudent.CardNo;
            this.txtPhoneNumber.Text = objStudent.PhoneNumber;
            this.txtAddress.Text = objStudent.StudentAddress;
            //显示照片
            this.pbStu.Image = objStudent.StuImage.Length != 0 ?
                (Image)new Common.SerializeObjectToString().DeserializeObject(objStudent.StuImage) :
                Image.FromFile("default.png");

        }

        //Ìá½»ÐÞ¸Ä
        private void btnModify_Click(object sender, EventArgs e)
        {
            //数据验证（考勤卡号和身份证号需要特殊判断）

            #region 数据验证
            if (this.txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生姓名不能为空！", "提示信息");
                this.txtStudentName.Focus();
                return;

            }
            if (this.txtCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("考勤卡号不能为空！", "提示信息");
                this.txtCardNo.Focus();
                return;

            }
            if (!this.rdoFemale.Checked && !this.rdoMale.Checked)
            {
                MessageBox.Show("请选择学生性别！", "提示信息");
                return;

            }
            if (this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择性别！", "提示信息");
                return;

            }
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age > 35 || age < 18)
            {
                MessageBox.Show("年龄必须在28-35岁之间", "提示信息");
                return;
            }

            //身份证
            if (!Common.DataValidate.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证不符合要求！", "提示信息");
                this.txtStudentIdNo.Focus();
                return;
            }
            string birthday = Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd");

            if (!this.txtStudentIdNo.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("身份证与出生年月日不匹配！", "提示信息");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }


            if (objStudentService.IsCardNoExisted(txtCardNo.Text.Trim(),this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("考勤卡已存在！", "提示信息");
                this.txtCardNo.Focus();
                this.txtCardNo.SelectAll();
                return;
            }

            if (objStudentService.IsIdNoExisted(txtStudentIdNo.Text.Trim(), this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("身份证号已存在！", "提示信息");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }

            #endregion

            Student objStudent = new Student()
            {
                StudentId =Convert.ToInt32( this.txtStudentId.Text.Trim()),
                StudentName = this.txtStudentName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "男" : "女",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text.Trim()),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                ClassName = this.cboClassName.Text,
                StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                CardNo = this.txtCardNo.Text.Trim(),
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StudentAddress = this.txtAddress.Text.Trim(),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                StuImage = this.pbStu.Image != null ? new Common.SerializeObjectToString().SerializeObject(this.pbStu.Image) : ""
            };
            try
            {
              int result=  objStudentService.ModifyStudent(objStudent);
                if (result == 1)
                {
                    MessageBox.Show("修改成功", "提示信息");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("修改失败", "提示信息");
                    return;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("数据库操作异常，操作信息：" +ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Ñ¡ÔñÕÕÆ¬
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog objFileDialog = new OpenFileDialog();
            //DialogResult result = objFileDialog.ShowDialog();
            //if (result == DialogResult.OK)
            //    this.pbStu.Image = Image.FromFile(objFileDialog.FileName);

            OpenFileDialog objFileDialog = new OpenFileDialog();
            DialogResult result = objFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(objFileDialog.FileName);
            }
        }
    }
}