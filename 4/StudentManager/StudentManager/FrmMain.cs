using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using DAL;
using Models;
using System.Linq;
using System.Reflection; //反射用的命名空间

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()

        {
            InitializeComponent();
            //显示当前用户
            this.lblCurrentUser.Text = Program.currentAdmin.AdminName;
            //显示主窗体背景
            this.spContainer.Panel2.BackgroundImage = Image.FromFile("mainbg.png");
            this.spContainer.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            //显示版本号
            this.lblVersion.Text = "版本号：" + ConfigurationManager.AppSettings["pversion"].ToString();

            //加载树形菜单
            LoadTvMenu();


            //权限的设定
        }

        private List<TVNode> nodeList = null;
        private MenuService objService = new MenuService();
        private void LoadTvMenu()
        {
            this.nodeList = objService.GetAllMenu();//加载所有的菜单节点信息
            //创建一个根节点：
            this.tvManu.Nodes.Clear();//清空所有的节点
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "学员管理系统";
            rootNode.Tag = "0";//默认值，实际开发中可以根据需要设置
            rootNode.ImageIndex = 0;//设置根节点显示的图片
            this.tvManu.Nodes.Add(rootNode);//将根节点添加到treeview根节点

            //基于递归方式添加所有子节点
            CreateChildNode(rootNode, "0");
            this.tvManu.Nodes[0].Expand();//将递归树一级目录展开
            this.tvManu.ExpandAll();

        }
        private void CreateChildNode(TreeNode parentNode, string preId)
        {
            //找到所有以该节点为父节点的子项
            var nodes = from list in this.nodeList
                           where list.ParentId.Equals(preId)
                           select list;

            //循环创建该节点的所有子节点
            foreach (var item in nodes)
            {
                //创建新的节点并设置属性
                TreeNode node = new TreeNode();
                node.Text = item.MenuName;
                node.Tag = item.MenuCode;
                //设置节点图标
                if (item.ParentId=="0")
                {
                    node.ImageIndex = 1;
                }
                else
                {
                    node.ImageIndex = 3;
                }
                parentNode.Nodes.Add(node); //父节点加入该子节点
                //调用递归实现子节点添加
                CreateChildNode(node, item.MenuId.ToString());
            }
        }

        private void tvManu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level==2)
            {
               Form objForm=  (Form)Assembly.Load("StudentManager").CreateInstance("StudentManager.Frm" + e.Node.Tag.ToString());
                OpenForm(objForm);
            }
        }

        #region 嵌入窗体显示

        private void CloseForm()
        {
            //判断右侧容器中是否已经存在窗体
            foreach (Control item in this.spContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                }
            }
        }

        private void OpenForm(Form objForm)
        {
            CloseForm();
            objForm.TopLevel = false;//将子窗体设置成非顶级空间
            objForm.FormBorderStyle = FormBorderStyle.None;//去掉窗体的边框
            objForm.Parent = this.spContainer.Panel2;//指定子窗体显示的容器
            objForm.Dock = DockStyle.Fill;//设置子窗体随着容器大小自动调整窗体大小
            objForm.Show();
        }
        //显示添加新学员窗体    
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            //嵌入的基本步骤
            OpenForm(new FrmAddStudent());

        }
        private void btnAddStu_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        //ÅúÁ¿µ¼ÈëÑ§Ô±ÐÅÏ¢
        private void tsmi_Import_Click(object sender, EventArgs e)
        {
            FrmImportData objForm = new FrmImportData();
            OpenForm(objForm);
        }
        private void btnImportStu_Click(object sender, EventArgs e)
        {
            tsmi_Import_Click(null, null);
        }
        //¿¼ÇÚ´ò¿¨      
        private void tsmi_Card_Click(object sender, EventArgs e)
        {
            FrmAttendance objForm = new FrmAttendance();
           OpenForm(objForm);
        }
        private void btnCard_Click(object sender, EventArgs e)
        {
            tsmi_Card_Click(null, null);
        }
        //³É¼¨¿ìËÙ²éÑ¯¡¾Ç¶ÈëÏÔÊ¾¡¿
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
            FrmScoreQuery objForm = new FrmScoreQuery();
            OpenForm(objForm);
        }
        private void btnScoreQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }
        //Ñ§Ô±¹ÜÀí¡¾Ç¶ÈëÏÔÊ¾¡¿
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {
            FrmStudentManage objForm = new FrmStudentManage();
            OpenForm(objForm);
        }
        private void btnStuManage_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        //ÏÔÊ¾³É¼¨²éÑ¯Óë·ÖÎö´°¿Ú    
        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm = new FrmScoreManage();
            OpenForm(objForm);
        }
        private void btnScoreAnalasys_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        //¿¼ÇÚ²éÑ¯
        private void tsmi_AQuery_Click(object sender, EventArgs e)
        {
            FrmAttendanceQuery objForm = new FrmAttendanceQuery();
           OpenForm(objForm);
        }
        private void btnAttendanceQuery_Click(object sender, EventArgs e)
        {
            tsmi_AQuery_Click(null, null);
        }

        #endregion

        #region ÍË³öÏµÍ³È·ÈÏ

        //ÍË³öÏµÍ³
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗？", "退出询问",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result!=DialogResult.OK)
            {
                e.Cancel = true;//告诉窗体事件关闭这个任务取消
            }
        
        }

        #endregion

        #region ÆäËû

        //ÃÜÂëÐÞ¸Ä
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objPwd = new FrmModifyPwd();
            objPwd.ShowDialog();
        }
        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        //ÕËºÅÇÐ»»
        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            FrmUserLogin objFrmLogin = new FrmUserLogin();
            objFrmLogin.Text = "[账号切换]";
            DialogResult result = objFrmLogin.ShowDialog();
            if (result==DialogResult.OK)
            {
                this.lblCurrentUser.Text = Program.currentAdmin.AdminName + "]";
            }

        }
        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }

        //·ÃÎÊ¹ÙÍø
        private void tsmi_linkxkt_Click(object sender, EventArgs e)
        {
         
        }
        private void btnGoXiketang_Click(object sender, EventArgs e)
        {
            tsmi_linkxkt_Click(null, null);
        }
        //ÏµÍ³Éý¼¶
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }



        #endregion

        //点击节点，切换图标
        private void tvManu_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void tvManu_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 2;
        }
    }
}