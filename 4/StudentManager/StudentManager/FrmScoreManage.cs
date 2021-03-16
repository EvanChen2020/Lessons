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
    public partial class FrmScoreManage : Form
    {
        private ScoreListService objScoreService = new ScoreListService();
        private Dictionary<string, string> scoreStastic = new Dictionary<string, string>();
        private List<string> nameList = new List<string>();

        public FrmScoreManage()
        {
            InitializeComponent();
            this.cboClass.SelectedIndexChanged -= new System.EventHandler(this.cboClass_SelectedIndexChanged);
            //绑定下拉框
            this.cboClass.DataSource = new StudentClassService().GetAllClass();
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);

            this.dgvScoreList.AutoGenerateColumns = false;
            new Common.DataGridViewStyle().DgvStyle1(this.dgvScoreList);
        }    
        
        private void QueryScore(string classId)
        {
           scoreStastic = objScoreService.QueryScoreInfo(classId);
            nameList = objScoreService.QueryAbsentList(classId);

            this.lblAttendCount.Text = scoreStastic["stuCount"];
            this.lblCount.Text = scoreStastic["absentCount"];
            this.lblCSharpAvg.Text = scoreStastic["avgCSharp"];
            this.lblDBAvg.Text = scoreStastic["avgDB"];

            //this.lblList.DataSource = null;
            // this.lblList.DataSource = nameList;

            this.lblList.Items.Clear();
            if (nameList.Count == 0)
            {
                this.lblList.Items.Add("没有缺考");

            }
            else
            {
                this.lblList.Items.AddRange(nameList.ToArray());
            }

        }

        //¸ù¾Ý°à¼¶²éÑ¯      
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex==-1)
            {
                MessageBox.Show("请选择要查询的班级！", "查询提示");
                    return;
            }
            //显示查询结果
            this.dgvScoreList.DataSource = objScoreService.QueryScoreList(this.cboClass.Text.Trim());

            QueryScore(this.cboClass.SelectedValue.ToString());


        }
        //¹Ø±Õ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Í³¼ÆÈ«Ð£¿¼ÊÔ³É¼¨
        private void btnStat_Click(object sender, EventArgs e)
        {
            //显示查询结果
            
            this.dgvScoreList.DataSource = objScoreService.QueryScoreList("");
            QueryScore("");

        }

        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Common.DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

    
     
        //Ñ¡Ôñ¿òÑ¡Ôñ¸Ä±ä´¦Àí
        private void dgvScoreList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
         
        }

        private void dgvScoreList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==0&&e.Value is Student)
            {
                e.Value = (e.Value as Student).StudentId;
            }
            if (e.ColumnIndex == 1 && e.Value is Student)
            {
                e.Value = (e.Value as Student).StudentName;
            }
            if (e.ColumnIndex == 2 && e.Value is Student)
            {
                e.Value = (e.Value as Student).Gender;
            }

            if (e.ColumnIndex == 3 && e.Value is StudentClass)
            {
                e.Value = (e.Value as StudentClass).ClassName;

            }

            if (e.ColumnIndex == 4 && e.Value is ScoreList)
            {
                e.Value = (e.Value as ScoreList).CSharp;
            }
            if (e.ColumnIndex == 5 && e.Value is ScoreList)
            {
                e.Value = (e.Value as ScoreList).SQLServerDB;
            }
        }
    }
}