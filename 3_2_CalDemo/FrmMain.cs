//using _3_2_CalDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_2_VBDll;

namespace _3_2_CalDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

       
        private void btnStart_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(this.txtNun1.Text.Trim());
            int num2 = Convert.ToInt32(this.txtNum2.Text.Trim());
            int result = new CaculatorVB().Add(num1, num2);
            this.lblResult.Text = result.ToString();
        }
    }
}
