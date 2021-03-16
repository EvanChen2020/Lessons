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
    public partial class FrmAddStudent : Form
    {
        //创建数据访问对象
        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        List<Student> stuList = new List<Student>();//用来保存新增学员对象

        public FrmAddStudent()
        {
            InitializeComponent();

           this.cboClassName.DataSource= objClassService.GetAllClass();
            this.cboClassName.DisplayMember = "ClassName";//设置下拉框显示文本
            this.cboClassName.ValueMember = "ClassId";//设置下拉框显示文本对应的value
            this.cboClassName.SelectedIndex = -1;

            this.dgvStudentList.AutoGenerateColumns = false;//禁止自动生成列
      
        }
        //Ìí¼ÓÐÂÑ§Ô±
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.txtStudentName.Text.Trim().Length==0)
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
            if (!this.rdoFemale.Checked&&!this.rdoMale.Checked)
            {
                MessageBox.Show("请选择学生性别！", "提示信息");
                return;

            }
            if (this.cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("请选择性别！", "提示信息");
                return;

            }
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age>35 || age<18)
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
            

            if (objStudentService.IsCardNoExised(txtCardNo.Text.Trim()))
            {
                MessageBox.Show("考勤卡已存在！", "提示信息");
                this.txtCardNo.Focus();
                this.txtCardNo.SelectAll();
                return;
            }

            if (objStudentService.IsIdNoExised(txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号已存在！", "提示信息");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }
            //验证考勤卡号必须是数字！！

            #endregion

            Student objStudent = new Student()
            {
                StudentName = this.txtStudentName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "男" : "女",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text.Trim()),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                ClassName=this.cboClassName.Text,
                StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                CardNo = this.txtCardNo.Text.Trim(),
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                StudentAddress = this.txtAddress.Text.Trim(),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                StuImage = this.pbStu.Image != null ? new Common.SerializeObjectToString().SerializeObject(this.pbStu.Image) : ""
            };
            //try
            {
                int studentId = objStudentService.AddStudent(objStudent); 
                if (studentId >1)
                {
                    //同步显示添加的学员
                    objStudent.StudentId = studentId;
                    this.stuList.Add(objStudent);
                    this.dgvStudentList.DataSource = null;
                    this.dgvStudentList.DataSource = stuList;
                    DialogResult dialogResult = MessageBox.Show("添加成功,继续？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                       // this.txtStudentName.Text = "";
                       // this.txtStudentName.Focus();
                       // this.rdoMale.Checked = false;
                       // this.rdoFemale.Checked = false;
                       // this.dtpBirthday.Text = "";
                       // this.cboClassName.SelectedIndex = -1;
                       // this.txtStudentIdNo.Text = "";
                       // this.txtCardNo.Text = "";
                       // this.txtPhoneNumber.Text = "";
                       // this.txtAddress.Text = "";
                        foreach (Control item in gbstuinfo.Controls)
                        {
                            if (item is TextBox)
                            {
                                ((TextBox)item).Text = "";
                            }
                            if (item is RadioButton)
                            {
                                ((RadioButton)item).Checked = false;
                            }
                            if (item is DateTimePicker)
                            {
                                ((DateTimePicker)item).Text = "";
                            }
                            if (item is ComboBox)
                            {
                                ((ComboBox)item).SelectedIndex = -1;
                            }
                        }
                        this.pbStu.Image = null;
                        this.txtStudentName.Focus();

                    }

                }
                else
                    MessageBox.Show("修改失败", "提示信息");
            }
            //catch (Exception ex)
            //{

            //    MessageBox.Show("修改失败，数据库操作错误："+ex.Message, "提示信息");
            //}
        }
        //¹Ø±Õ´°Ìå
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmAddStudent_KeyDown(object sender, KeyEventArgs e)
        {
       

        }
        //Ñ¡ÔñÐÂÕÕÆ¬
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog objFileDialog = new OpenFileDialog();
            DialogResult result = objFileDialog.ShowDialog();
            if (result==DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(objFileDialog.FileName);
            }
        }
        //Æô¶¯ÉãÏñÍ·
        private void btnStartVideo_Click(object sender, EventArgs e)
        {
         
        }
        //ÅÄÕÕ
        private void btnTake_Click(object sender, EventArgs e)
        {
        
        }
        //Çå³ýÕÕÆ¬
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pbStu.Image = null;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }
    }
}