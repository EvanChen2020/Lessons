using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_7_TeachDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void OpenNewFrm(Form newFrm)
        {
            foreach (Control item in this.splitContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            newFrm.TopLevel = false; //将子窗体设置成非顶级控件
                                     // newFrm.FormBorderStyle = FormBorderStyle.None;
            newFrm.Parent = this.splitContainer.Panel2;
            newFrm.Dock = DockStyle.Fill;// 根据父窗体改变大小

            newFrm.Show();
        }

    private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            
            OpenNewFrm(new FrmAddProduct());

        }
    }
}

