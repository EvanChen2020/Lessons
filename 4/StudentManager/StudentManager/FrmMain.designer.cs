﻿namespace StudentManager
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.学员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiManageStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryAndAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AttendanceQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Card = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_AQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_linkxkt = new System.Windows.Forms.ToolStripMenuItem();
            this.txmi_update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.tvManu = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnChangeAccount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.学员管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.tsmi_AttendanceQuery,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiModifyPwd,
            this.toolStripSeparator3,
            this.tmiClose});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.系统ToolStripMenuItem.Text = "系统(&S)";
            // 
            // tmiModifyPwd
            // 
            this.tmiModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tmiModifyPwd.Image")));
            this.tmiModifyPwd.Name = "tmiModifyPwd";
            this.tmiModifyPwd.Size = new System.Drawing.Size(139, 22);
            this.tmiModifyPwd.Text = "密码修改(&C)";
            this.tmiModifyPwd.Click += new System.EventHandler(this.tmiModifyPwd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // tmiClose
            // 
            this.tmiClose.Image = ((System.Drawing.Image)(resources.GetObject("tmiClose.Image")));
            this.tmiClose.Name = "tmiClose";
            this.tmiClose.Size = new System.Drawing.Size(139, 22);
            this.tmiClose.Text = "退出(&E)";
            this.tmiClose.Click += new System.EventHandler(this.tmiClose_Click);
            // 
            // 学员管理ToolStripMenuItem
            // 
            this.学员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStudent,
            this.tsmi_Import,
            this.toolStripSeparator2,
            this.tsmiManageStudent});
            this.学员管理ToolStripMenuItem.Name = "学员管理ToolStripMenuItem";
            this.学员管理ToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.学员管理ToolStripMenuItem.Text = "学员管理(&M)";
            // 
            // tsmiAddStudent
            // 
            this.tsmiAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddStudent.Image")));
            this.tsmiAddStudent.Name = "tsmiAddStudent";
            this.tsmiAddStudent.Size = new System.Drawing.Size(164, 22);
            this.tsmiAddStudent.Text = "添加学员(&A)";
            this.tsmiAddStudent.Click += new System.EventHandler(this.tsmiAddStudent_Click);
            // 
            // tsmi_Import
            // 
            this.tsmi_Import.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Import.Image")));
            this.tsmi_Import.Name = "tsmi_Import";
            this.tsmi_Import.Size = new System.Drawing.Size(164, 22);
            this.tsmi_Import.Text = "批量导入学员";
            this.tsmi_Import.Click += new System.EventHandler(this.tsmi_Import_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmiManageStudent
            // 
            this.tsmiManageStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsmiManageStudent.Image")));
            this.tsmiManageStudent.Name = "tsmiManageStudent";
            this.tsmiManageStudent.Size = new System.Drawing.Size(164, 22);
            this.tsmiManageStudent.Text = "学员信息管理(&Q)";
            this.tsmiManageStudent.Click += new System.EventHandler(this.tsmiManageStudent_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQueryAndAnalysis,
            this.toolStripSeparator1,
            this.tsmiQuery});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理(&J)";
            // 
            // tsmiQueryAndAnalysis
            // 
            this.tsmiQueryAndAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQueryAndAnalysis.Image")));
            this.tsmiQueryAndAnalysis.Name = "tsmiQueryAndAnalysis";
            this.tsmiQueryAndAnalysis.Size = new System.Drawing.Size(178, 22);
            this.tsmiQueryAndAnalysis.Text = "成绩查询与分析(&Q)";
            this.tsmiQueryAndAnalysis.Click += new System.EventHandler(this.tsmiQueryAndAnalysis_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // tsmiQuery
            // 
            this.tsmiQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQuery.Image")));
            this.tsmiQuery.Name = "tsmiQuery";
            this.tsmiQuery.Size = new System.Drawing.Size(178, 22);
            this.tsmiQuery.Text = "成绩快速查询(&S)";
            this.tsmiQuery.Click += new System.EventHandler(this.tsmiQuery_Click);
            // 
            // tsmi_AttendanceQuery
            // 
            this.tsmi_AttendanceQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Card,
            this.toolStripSeparator7,
            this.tsmi_AQuery});
            this.tsmi_AttendanceQuery.Name = "tsmi_AttendanceQuery";
            this.tsmi_AttendanceQuery.Size = new System.Drawing.Size(83, 20);
            this.tsmi_AttendanceQuery.Text = "考勤管理(&A)";
            // 
            // tsmi_Card
            // 
            this.tsmi_Card.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Card.Image")));
            this.tsmi_Card.Name = "tsmi_Card";
            this.tsmi_Card.Size = new System.Drawing.Size(137, 22);
            this.tsmi_Card.Text = "考勤打卡(&R)";
            this.tsmi_Card.Click += new System.EventHandler(this.tsmi_Card_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(134, 6);
            // 
            // tsmi_AQuery
            // 
            this.tsmi_AQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_AQuery.Image")));
            this.tsmi_AQuery.Name = "tsmi_AQuery";
            this.tsmi_AQuery.Size = new System.Drawing.Size(137, 22);
            this.tsmi_AQuery.Text = "考勤查询";
            this.tsmi_AQuery.Click += new System.EventHandler(this.tsmi_AQuery_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_linkxkt,
            this.txmi_update,
            this.toolStripSeparator8,
            this.tsmi_about});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmi_linkxkt
            // 
            this.tsmi_linkxkt.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_linkxkt.Image")));
            this.tsmi_linkxkt.Name = "tsmi_linkxkt";
            this.tsmi_linkxkt.Size = new System.Drawing.Size(140, 22);
            this.tsmi_linkxkt.Text = "访问官网(&X)";
            this.tsmi_linkxkt.Click += new System.EventHandler(this.tsmi_linkxkt_Click);
            // 
            // txmi_update
            // 
            this.txmi_update.Image = ((System.Drawing.Image)(resources.GetObject("txmi_update.Image")));
            this.txmi_update.Name = "txmi_update";
            this.txmi_update.Size = new System.Drawing.Size(140, 22);
            this.txmi_update.Text = "系统升级(&U)";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmi_about
            // 
            this.tsmi_about.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_about.Image")));
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(140, 22);
            this.tsmi_about.Text = "关于我们(&A)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersion,
            this.toolStripStatusLabel1,
            this.lblCurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 768);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(74, 17);
            this.lblVersion.Text = " 版本号：V2.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel1.Text = " [当前用登录户：";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(49, 17);
            this.lblCurrentUser.Text = "王晓军]";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // spContainer
            // 
            this.spContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 24);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.label4);
            this.spContainer.Panel1.Controls.Add(this.tvManu);
            this.spContainer.Panel1.Controls.Add(this.monthCalendar1);
            this.spContainer.Panel1.Controls.Add(this.btnChangeAccount);
            this.spContainer.Panel1.Controls.Add(this.btnExit);
            this.spContainer.Size = new System.Drawing.Size(1264, 744);
            this.spContainer.SplitterDistance = 246;
            this.spContainer.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "学员信息管理";
            // 
            // tvManu
            // 
            this.tvManu.ImageIndex = 0;
            this.tvManu.ImageList = this.imageList1;
            this.tvManu.Location = new System.Drawing.Point(10, 60);
            this.tvManu.Name = "tvManu";
            this.tvManu.SelectedImageIndex = 0;
            this.tvManu.Size = new System.Drawing.Size(207, 386);
            this.tvManu.TabIndex = 2;
            this.tvManu.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvManu_AfterCollapse);
            this.tvManu.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvManu_AfterExpand);
            this.tvManu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvManu_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BOOKS01.ICO");
            this.imageList1.Images.SetKeyName(1, "open.ico");
            this.imageList1.Images.SetKeyName(2, "turn.BMP");
            this.imageList1.Images.SetKeyName(3, "CustomerOrder.ico");
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 490);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // btnChangeAccount
            // 
            this.btnChangeAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeAccount.Image")));
            this.btnChangeAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeAccount.Location = new System.Drawing.Point(29, 665);
            this.btnChangeAccount.Name = "btnChangeAccount";
            this.btnChangeAccount.Size = new System.Drawing.Size(82, 44);
            this.btnChangeAccount.TabIndex = 1;
            this.btnChangeAccount.Text = "账号切换";
            this.btnChangeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeAccount.UseVisualStyleBackColor = true;
            this.btnChangeAccount.Click += new System.EventHandler(this.btnChangeAccount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(128, 665);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出系统";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 790);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[学员信息管理系统]--最适合初学者学习的实践项目";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmiModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem tmiClose;
        private System.Windows.Forms.ToolStripMenuItem 学员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageStudent;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryAndAnalysis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AttendanceQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Card;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AQuery;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_linkxkt;
        private System.Windows.Forms.ToolStripMenuItem txmi_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Import;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangeAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tvManu;
        private System.Windows.Forms.ImageList imageList1;
    }
}

