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
    public partial class FrmScoreManage : Form
    {

        private StudentClassService objClassService = new StudentClassService();
        private ScoreListService objScoreService = new ScoreListService();
      
        public FrmScoreManage()
        {
            InitializeComponent();
            this.cboClass.SelectedIndexChanged -= new EventHandler(this.cboClass_SelectedIndexChanged);
            //初始化班级下拉框
            this.cboClass.DataSource = objClassService.GetAllClasses();
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1; // default we didn't select a class

            this.cboClass.SelectedIndexChanged +=
              new EventHandler(this.cboClass_SelectedIndexChanged);

        }
        //¸ù¾Ý°à¼¶²éÑ¯      
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex==-1)
            {
                MessageBox.Show("Please select class", "information");
                return;
            }
           
            this.dgvScoreList.AutoGenerateColumns = false;
            this.dgvScoreList.DataSource = objScoreService.GetScoreList(this.cboClass.Text.Trim());
            this.gbStat.Text = "["+ this.cboClass.Text.Trim()+"]班级考试成绩统计";
            //查询并显示成绩统计
            Dictionary<string, string> dic = objScoreService.GetScoreInfoByClassId(this.cboClass.SelectedValue.ToString());
            this.lblAttendCount.Text = dic["stuCount"];
            this.lblCSharpAvg.Text = dic["avgCSharp"];
            this.lblCount.Text = dic["absentCount"];
            this.lblDBAvg.Text = dic["avgDB"];
            //显示缺考列表
            List<string> list = objScoreService.GetAbsentListByClassId(this.cboClass.SelectedValue.ToString());
            this.lblList.Items.Clear();
            // this.lblList.Items.AddRange(list.ToArray());
            if (list.Count == 0) this.lblList.Items.Add("No Student");
            else lblList.Items.AddRange(list.ToArray());

        }
        //¹Ø±Õ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Í³¼ÆÈ«Ð£¿¼ÊÔ³É¼¨
        private void btnStat_Click(object sender, EventArgs e)
        {
            this.gbStat.Text = "全校考试成绩统计";
            this.dgvScoreList.AutoGenerateColumns = false;
            this.dgvScoreList.DataSource = objScoreService.GetScoreList("");
            //查询并显示成绩统计
            Dictionary<string, string> dic = objScoreService.GetScoreInfo();
            this.lblAttendCount.Text = dic["stuCount"];
            this.lblCSharpAvg.Text = dic["avgCSharp"];
            this.lblCount.Text = dic["absentCount"];
            this.lblDBAvg.Text = dic["avgDB"];
            //显示缺考列表
            List<string> list = objScoreService.GetAbsentList();
            this.lblList.Items.Clear();
            this.lblList.Items.AddRange(list.ToArray());

        }

        private void FrmScoreManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmScoreManage = null;//当窗体关闭后，将窗体在内存中清理掉

        }
    }
}