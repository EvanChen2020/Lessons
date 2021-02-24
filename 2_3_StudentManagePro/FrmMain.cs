using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_3_StudentManagePro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region close the pre-form and open new form in a container
        private void ClosePreForm()
        {
            // before openning the widow
            // check if the cantainer has a openning widow?
            foreach (Control item in this.spContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                }
            }
        }

        private void OpenForm(Form objFrm)
        {
            
            objFrm.TopLevel = false; // set son window as untop controller
            objFrm.WindowState = FormWindowState.Maximized;// set son window as max size
            objFrm.FormBorderStyle = FormBorderStyle.None;// cancel the border of form
            objFrm.Parent = this.spContainer.Panel2; // set son form display in special container
            objFrm.Show();
        }
        #endregion

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            //// before openning the widow
            //// check if the cantainer has a openning widow?
            //foreach (Control item in this.spContainer.Panel2.Controls)
            //{
            //    if (item is Form)
            //    {
            //        Form objControl = (Form)item;
            //        objControl.Close();
            //    }
            //}
            ClosePreForm(); // close existed form
           // Form objFrm = new FrmAddStudent();
            OpenForm(new FrmAddStudent());
        }

        private void btnStuManage_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenForm(new FrmStudentInformationManagement());
        }
    }
}
