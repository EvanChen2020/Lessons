using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;


namespace StudentManager
{
    public partial class FrmImportData : Form
    {
        private List<Student> stuList = null;//用来保存学员对象
        private ImportDataFromExcel objImport = new ImportDataFromExcel();

        public FrmImportData()
        {
            InitializeComponent();
            dgvStudentList.AutoGenerateColumns = false;

        }
        private void btnChoseExcel_Click(object sender, EventArgs e)
        {
            //打开文件
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();
            if (result==DialogResult.OK)
            {
                string path = openFile.FileName;//获取Excel路径
                this.stuList = objImport.GetStudentByExcel(path);
                //显示数据
               // this.dgvStudentList.DataSource = null;
                this.dgvStudentList.DataSource = stuList;
            }
        }
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }
        //保存到数据库
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            //【1】验证数据（保证List集合中有数据）
            if (stuList== null|| stuList.Count==0)
            {
                MessageBox.Show("目前没有要导入的数据！", "导入提示");
                return;

            }

            //【2】遍历集合（方法1，每查询一个对象，就提交一次到数据；方法2，每遍历一次，就生成一条SQL语句，基于事务保存对象）
            try
            {
                if (objImport.Import(this.stuList))
                {
                    MessageBox.Show("数据导入成功！", "导入提示");
                    this.dgvStudentList.DataSource = null;
                    this.stuList.Clear();
                }
                else
                {
                    MessageBox.Show("数据导入失败！", "导入提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("数据导入失败！具体原因：" + ex.Message, "导入提示");
            }

        }
    }
}

