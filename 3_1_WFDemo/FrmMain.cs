using _3_1_ADO.NetDemo.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_1_WFDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            StudentService objStuService = new StudentService();
            int class1 = objStuService.GetStuCountByClassId("1");
            int class2 = objStuService.GetStuCountByClassId("2");
            this.lblInfo.Text = string.Format("班级1总数：{0}, 班级2总数：{1}", class1, class2);
        }
    }
}
