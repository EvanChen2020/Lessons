namespace _2_4_FrmFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWriteLine = new System.Windows.Forms.Button();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.btnWriteAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelAllFiles = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnShowSubDir = new System.Windows.Forms.Button();
            this.btnShowAllFiles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 44);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(242, 511);
            this.txtContent.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWriteLine);
            this.groupBox1.Controls.Add(this.btnReadAll);
            this.groupBox1.Controls.Add(this.btnWriteAll);
            this.groupBox1.Location = new System.Drawing.Point(260, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text File Read and Write";
            // 
            // btnWriteLine
            // 
            this.btnWriteLine.Location = new System.Drawing.Point(282, 35);
            this.btnWriteLine.Name = "btnWriteLine";
            this.btnWriteLine.Size = new System.Drawing.Size(178, 31);
            this.btnWriteLine.TabIndex = 0;
            this.btnWriteLine.Text = "Simulate Writing System Log";
            this.btnWriteLine.UseVisualStyleBackColor = true;
            this.btnWriteLine.Click += new System.EventHandler(this.btnWriteLine_Click);
            // 
            // btnReadAll
            // 
            this.btnReadAll.Location = new System.Drawing.Point(142, 35);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(134, 31);
            this.btnReadAll.TabIndex = 0;
            this.btnReadAll.Text = "Read From Text File";
            this.btnReadAll.UseVisualStyleBackColor = true;
            this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
            // 
            // btnWriteAll
            // 
            this.btnWriteAll.Location = new System.Drawing.Point(15, 35);
            this.btnWriteAll.Name = "btnWriteAll";
            this.btnWriteAll.Size = new System.Drawing.Size(121, 31);
            this.btnWriteAll.TabIndex = 0;
            this.btnWriteAll.Text = "Write Text File";
            this.btnWriteAll.UseVisualStyleBackColor = true;
            this.btnWriteAll.Click += new System.EventHandler(this.btnWriteAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.txtFrom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(260, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Operation";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(319, 40);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(116, 22);
            this.txtTo.TabIndex = 1;
            this.txtTo.Text = "D:\\\\Test\\\\myfile.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Target File Path:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(282, 90);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 31);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Move File";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(155, 90);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(121, 31);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy File";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(9, 90);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(121, 31);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Delete File";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(100, 37);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(116, 22);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.Text = "C:\\\\Test\\\\myfile.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File Path:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelAllFiles);
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Controls.Add(this.btnShowSubDir);
            this.groupBox3.Controls.Add(this.btnShowAllFiles);
            this.groupBox3.Location = new System.Drawing.Point(260, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 143);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Path Operation";
            // 
            // btnDelAllFiles
            // 
            this.btnDelAllFiles.Location = new System.Drawing.Point(235, 92);
            this.btnDelAllFiles.Name = "btnDelAllFiles";
            this.btnDelAllFiles.Size = new System.Drawing.Size(231, 31);
            this.btnDelAllFiles.TabIndex = 0;
            this.btnDelAllFiles.Text = "Delete all path and file in defined path";
            this.btnDelAllFiles.UseVisualStyleBackColor = true;
            this.btnDelAllFiles.Click += new System.EventHandler(this.btnDelAllFiles_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(9, 92);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(220, 31);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create a subpath in defined path";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnShowSubDir
            // 
            this.btnShowSubDir.Location = new System.Drawing.Point(235, 31);
            this.btnShowSubDir.Name = "btnShowSubDir";
            this.btnShowSubDir.Size = new System.Drawing.Size(231, 31);
            this.btnShowSubDir.TabIndex = 0;
            this.btnShowSubDir.Text = "Display subpath in defined path";
            this.btnShowSubDir.UseVisualStyleBackColor = true;
            this.btnShowSubDir.Click += new System.EventHandler(this.btnShowSubDir_Click);
            // 
            // btnShowAllFiles
            // 
            this.btnShowAllFiles.Location = new System.Drawing.Point(9, 31);
            this.btnShowAllFiles.Name = "btnShowAllFiles";
            this.btnShowAllFiles.Size = new System.Drawing.Size(220, 31);
            this.btnShowAllFiles.TabIndex = 0;
            this.btnShowAllFiles.Text = "Display the all file in defined path";
            this.btnShowAllFiles.UseVisualStyleBackColor = true;
            this.btnShowAllFiles.Click += new System.EventHandler(this.btnShowAllFiles_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "File Operation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWriteLine;
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.Button btnWriteAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelAllFiles;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnShowSubDir;
        private System.Windows.Forms.Button btnShowAllFiles;
    }
}

