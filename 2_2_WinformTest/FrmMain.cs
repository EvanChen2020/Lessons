using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_2_WinformTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            // give three buttons add  the same action event
            this.btnAndy.Click += new System.EventHandler(this.btn_TeacherClick);
            this.btnCarry.Click += new System.EventHandler(this.btn_TeacherClick);
            this.btnCoco.Click += new System.EventHandler(this.btn_TeacherClick);

        }

        //event reaction pulic function
        //sender is the source of action element
        private void btn_TeacherClick(object sender, EventArgs e)
        {
            string txt = ((Button)sender).Text;
            MessageBox.Show(txt+" Hello!!");
        }

        private void btnTestMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please input student name");
            MessageBox.Show("Please input student name", "check suggestion");
            MessageBox.Show("Please input student name", "check suggestion",
                MessageBoxButtons.OKCancel);
            MessageBox.Show("Please input student name", "check suggestion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            MessageBox.Show("Please input student name", "check suggestion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            MessageBox.Show("Please input student name", "check suggestion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            DialogResult result= MessageBox.Show("Please input student name", "check suggestion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                //user cancel the action
                MessageBox.Show("user cancel the action!");
            }
            else
            {
                // user continue the action
                MessageBox.Show("user continue the action!");

            }

        }
    }
}
