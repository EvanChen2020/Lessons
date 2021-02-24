using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2_5_SaveInstance
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // package data
            Student objStudent = new Student()
            {
                Name = this.txtName.Text,
                Age = Convert.ToInt32(this.txtAge.Text.Trim()),
                Gender = this.txtGender.Text.Trim(),
                Birthday = Convert.ToDateTime(this.txtBirthday.Text.Trim())

            };

            //save to file
            // if you don't input the dir, that means it is the app dir
            FileStream fs = new FileStream("objStudent.obj", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            // write one line by one line
            sw.WriteLine(objStudent.Name);
            sw.WriteLine(objStudent.Age);
            sw.WriteLine(objStudent.Gender);
            sw.WriteLine(objStudent.Birthday);
            // close
            sw.Close();
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("objStudent.obj", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            //read line by line
            Student objStudeng = new Student()
            {
                Name = sr.ReadLine(),
                Age = Convert.ToInt32(sr.ReadLine()),
                Gender = sr.ReadLine(),
                Birthday = Convert.ToDateTime(sr.ReadLine())
            };
            // close
            sr.Close();
            fs.Close();
            //display
            this.txtName.Text = objStudeng.Name;
            this.txtAge.Text = objStudeng.Age.ToString();
            this.txtGender.Text = objStudeng.Gender;
            this.txtBirthday.Text = objStudeng.Birthday.ToShortDateString();
        }
    }
}
