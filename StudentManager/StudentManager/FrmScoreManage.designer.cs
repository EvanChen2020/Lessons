namespace StudentManager
{
    partial class FrmScoreManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreManage));
            this.dgvScoreList = new System.Windows.Forms.DataGridView();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStat = new System.Windows.Forms.GroupBox();
            this.lblDBAvg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCSharpAvg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAttendCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQLServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            this.gbStat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScoreList
            // 
            this.dgvScoreList.AllowUserToAddRows = false;
            this.dgvScoreList.AllowUserToDeleteRows = false;
            this.dgvScoreList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvScoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.ClassName,
            this.CSharp,
            this.SQLServer});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoreList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoreList.Location = new System.Drawing.Point(12, 48);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            this.dgvScoreList.RowTemplate.Height = 23;
            this.dgvScoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScoreList.Size = new System.Drawing.Size(485, 202);
            this.dgvScoreList.TabIndex = 7;
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(94, 10);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 21);
            this.cboClass.TabIndex = 0;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "学员班级：";
            // 
            // gbStat
            // 
            this.gbStat.Controls.Add(this.lblDBAvg);
            this.gbStat.Controls.Add(this.label8);
            this.gbStat.Controls.Add(this.lblCount);
            this.gbStat.Controls.Add(this.lblCSharpAvg);
            this.gbStat.Controls.Add(this.label4);
            this.gbStat.Controls.Add(this.label6);
            this.gbStat.Controls.Add(this.lblAttendCount);
            this.gbStat.Controls.Add(this.label3);
            this.gbStat.Location = new System.Drawing.Point(12, 254);
            this.gbStat.Name = "gbStat";
            this.gbStat.Size = new System.Drawing.Size(312, 104);
            this.gbStat.TabIndex = 10;
            this.gbStat.TabStop = false;
            this.gbStat.Text = "全校考试成绩统计";
            // 
            // lblDBAvg
            // 
            this.lblDBAvg.BackColor = System.Drawing.Color.White;
            this.lblDBAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDBAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDBAvg.Location = new System.Drawing.Point(242, 63);
            this.lblDBAvg.Name = "lblDBAvg";
            this.lblDBAvg.Size = new System.Drawing.Size(61, 25);
            this.lblDBAvg.TabIndex = 12;
            this.lblDBAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "DB平均分：";
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCount.Location = new System.Drawing.Point(242, 25);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(61, 25);
            this.lblCount.TabIndex = 12;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCSharpAvg
            // 
            this.lblCSharpAvg.BackColor = System.Drawing.Color.White;
            this.lblCSharpAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCSharpAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCSharpAvg.Location = new System.Drawing.Point(90, 63);
            this.lblCSharpAvg.Name = "lblCSharpAvg";
            this.lblCSharpAvg.Size = new System.Drawing.Size(61, 25);
            this.lblCSharpAvg.TabIndex = 12;
            this.lblCSharpAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "缺考总人数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "C#平均分：";
            // 
            // lblAttendCount
            // 
            this.lblAttendCount.BackColor = System.Drawing.Color.White;
            this.lblAttendCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttendCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAttendCount.Location = new System.Drawing.Point(90, 25);
            this.lblAttendCount.Name = "lblAttendCount";
            this.lblAttendCount.Size = new System.Drawing.Size(61, 25);
            this.lblAttendCount.TabIndex = 12;
            this.lblAttendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "参考总人数：";
            // 
            // lblList
            // 
            this.lblList.FormattingEnabled = true;
            this.lblList.Location = new System.Drawing.Point(16, 20);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(135, 69);
            this.lblList.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblList);
            this.groupBox2.Location = new System.Drawing.Point(330, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 104);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "缺考人员名单";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(415, 364);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(330, 8);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(167, 25);
            this.btnStat.TabIndex = 15;
            this.btnStat.Text = "统计全校考试信息";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 60;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // CSharp
            // 
            this.CSharp.DataPropertyName = "CSharp";
            this.CSharp.HeaderText = "C#成绩";
            this.CSharp.Name = "CSharp";
            this.CSharp.ReadOnly = true;
            this.CSharp.Width = 80;
            // 
            // SQLServer
            // 
            this.SQLServer.DataPropertyName = "SQLServer";
            this.SQLServer.HeaderText = "数据库成绩";
            this.SQLServer.Name = "SQLServer";
            this.SQLServer.ReadOnly = true;
            // 
            // FrmScoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 398);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbStat);
            this.Controls.Add(this.dgvScoreList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmScoreManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[成绩查询]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmScoreManage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            this.gbStat.ResumeLayout(false);
            this.gbStat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScoreList;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStat;
        private System.Windows.Forms.Label lblAttendCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDBAvg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCSharpAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lblList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLServer;
    }
}