namespace _2_3_StudentManagePro
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_PwdModify = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.studentManagementMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchImportStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.allProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDevelopEnvironmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStuManage = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.studentManagementMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_PwdModify,
            this.toolStripSeparator1,
            this.exitSystemToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.systemToolStripMenuItem.Text = "System(&S)";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.systemToolStripMenuItem_Click);
            // 
            // tsmi_PwdModify
            // 
            this.tsmi_PwdModify.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_PwdModify.Image")));
            this.tsmi_PwdModify.Name = "tsmi_PwdModify";
            this.tsmi_PwdModify.Size = new System.Drawing.Size(187, 22);
            this.tsmi_PwdModify.Text = "Change Password(&M)";
            this.tsmi_PwdModify.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // exitSystemToolStripMenuItem
            // 
            this.exitSystemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitSystemToolStripMenuItem.Image")));
            this.exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            this.exitSystemToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitSystemToolStripMenuItem.Text = "Exit System";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // studentManagementMToolStripMenuItem
            // 
            this.studentManagementMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentAToolStripMenuItem,
            this.batchImportStudentsToolStripMenuItem,
            this.toolStripSeparator2,
            this.studentInformationManagementToolStripMenuItem});
            this.studentManagementMToolStripMenuItem.Name = "studentManagementMToolStripMenuItem";
            this.studentManagementMToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.studentManagementMToolStripMenuItem.Text = "Student Management(&M)";
            // 
            // addStudentAToolStripMenuItem
            // 
            this.addStudentAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentAToolStripMenuItem.Image")));
            this.addStudentAToolStripMenuItem.Name = "addStudentAToolStripMenuItem";
            this.addStudentAToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.addStudentAToolStripMenuItem.Text = "Add Student(&A)";
            // 
            // batchImportStudentsToolStripMenuItem
            // 
            this.batchImportStudentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("batchImportStudentsToolStripMenuItem.Image")));
            this.batchImportStudentsToolStripMenuItem.Name = "batchImportStudentsToolStripMenuItem";
            this.batchImportStudentsToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.batchImportStudentsToolStripMenuItem.Text = "Batch Import Students(&I)";
            // 
            // studentInformationManagementToolStripMenuItem
            // 
            this.studentInformationManagementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentInformationManagementToolStripMenuItem.Image")));
            this.studentInformationManagementToolStripMenuItem.Name = "studentInformationManagementToolStripMenuItem";
            this.studentInformationManagementToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.studentInformationManagementToolStripMenuItem.Text = "Student Information Management";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(252, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cDevelopEnvironmentToolStripMenuItem,
            this.allProgramToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // allProgramToolStripMenuItem
            // 
            this.allProgramToolStripMenuItem.Name = "allProgramToolStripMenuItem";
            this.allProgramToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.allProgramToolStripMenuItem.Text = "All program";
            // 
            // cDevelopEnvironmentToolStripMenuItem
            // 
            this.cDevelopEnvironmentToolStripMenuItem.Name = "cDevelopEnvironmentToolStripMenuItem";
            this.cDevelopEnvironmentToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cDevelopEnvironmentToolStripMenuItem.Text = "C# develop environment";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "Version: V2.0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabel2.Text = "    Current user: XXX";
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
            this.spContainer.Panel1.Controls.Add(this.button8);
            this.spContainer.Panel1.Controls.Add(this.button7);
            this.spContainer.Panel1.Controls.Add(this.button6);
            this.spContainer.Panel1.Controls.Add(this.button5);
            this.spContainer.Panel1.Controls.Add(this.button4);
            this.spContainer.Panel1.Controls.Add(this.btnStuManage);
            this.spContainer.Panel1.Controls.Add(this.button2);
            this.spContainer.Panel1.Controls.Add(this.btnAddNewStudent);
            this.spContainer.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spContainer.Panel2.BackgroundImage")));
            this.spContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spContainer.Panel2.Controls.Add(this.label1);
            this.spContainer.Size = new System.Drawing.Size(1264, 683);
            this.spContainer.SplitterDistance = 280;
            this.spContainer.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(26, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewStudent.ImageIndex = 4;
            this.btnAddNewStudent.ImageList = this.imageList1;
            this.btnAddNewStudent.Location = new System.Drawing.Point(26, 181);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(95, 28);
            this.btnAddNewStudent.TabIndex = 1;
            this.btnAddNewStudent.Text = "Add Student";
            this.btnAddNewStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 8;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(147, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Batch imput";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnStuManage
            // 
            this.btnStuManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuManage.ImageIndex = 7;
            this.btnStuManage.ImageList = this.imageList1;
            this.btnStuManage.Location = new System.Drawing.Point(26, 236);
            this.btnStuManage.Name = "btnStuManage";
            this.btnStuManage.Size = new System.Drawing.Size(95, 28);
            this.btnStuManage.TabIndex = 1;
            this.btnStuManage.Text = "Stu manage";
            this.btnStuManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStuManage.UseVisualStyleBackColor = true;
            this.btnStuManage.Click += new System.EventHandler(this.btnStuManage_Click);
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 3;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(147, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "Working book";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 6;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(26, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 28);
            this.button5.TabIndex = 1;
            this.button5.Text = "Score analyze";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(147, 288);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "Score Check";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageIndex = 3;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(26, 635);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 28);
            this.button7.TabIndex = 1;
            this.button7.Text = "Modify pwd";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.ImageIndex = 2;
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(147, 635);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 28);
            this.button8.TabIndex = 1;
            this.button8.Text = "Exit System";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CHECKMRK.ICO");
            this.imageList1.Images.SetKeyName(1, "people.ico");
            this.imageList1.Images.SetKeyName(2, "exit.ico");
            this.imageList1.Images.SetKeyName(3, "UserPsw.ico");
            this.imageList1.Images.SetKeyName(4, "student.ico");
            this.imageList1.Images.SetKeyName(5, "lklLoginExit.ico");
            this.imageList1.Images.SetKeyName(6, "lklLogin.ICO");
            this.imageList1.Images.SetKeyName(7, "4.png");
            this.imageList1.Images.SetKeyName(8, "BOOKS01.ICO");
            this.imageList1.Images.SetKeyName(9, "App.ico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to use student management system";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            this.spContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_PwdModify;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem studentManagementMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchImportStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem studentInformationManagementToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem cDevelopEnvironmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStuManage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.Label label1;
    }
}

