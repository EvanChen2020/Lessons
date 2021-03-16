namespace StudentManager
{
    partial class FrmScoreQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreQuery));
            this.dgvScoreList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQLServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
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
            this.dgvScoreList.Location = new System.Drawing.Point(12, 67);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            this.dgvScoreList.RowTemplate.Height = 23;
            this.dgvScoreList.Size = new System.Drawing.Size(485, 243);
            this.dgvScoreList.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(422, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(83, 22);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 21);
            this.cboClass.TabIndex = 10;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "学员班级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "按C#成绩快速浏览： C# >";
            // 
            // txtScore
            // 
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore.Location = new System.Drawing.Point(373, 22);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(68, 20);
            this.txtScore.TabIndex = 12;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 317);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(105, 25);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "显示全部成绩";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "分";
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
            // FrmScoreQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 350);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvScoreList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmScoreQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[考试成绩快速浏览]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmScoreQuery_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScoreList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLServer;
    }
}