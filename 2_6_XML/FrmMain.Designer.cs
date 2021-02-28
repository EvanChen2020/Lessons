namespace _2_6_XML
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
            this.dgvStuList = new System.Windows.Forms.DataGridView();
            this.btnShowVersion = new System.Windows.Forms.Button();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStuList
            // 
            this.dgvStuList.AllowUserToAddRows = false;
            this.dgvStuList.AllowUserToDeleteRows = false;
            this.dgvStuList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age,
            this.gender,
            this.studentClass});
            this.dgvStuList.Location = new System.Drawing.Point(12, 28);
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.Size = new System.Drawing.Size(514, 214);
            this.dgvStuList.TabIndex = 0;
            // 
            // btnShowVersion
            // 
            this.btnShowVersion.Location = new System.Drawing.Point(12, 308);
            this.btnShowVersion.Name = "btnShowVersion";
            this.btnShowVersion.Size = new System.Drawing.Size(163, 23);
            this.btnShowVersion.TabIndex = 1;
            this.btnShowVersion.Text = "Show the Version";
            this.btnShowVersion.UseVisualStyleBackColor = true;
            this.btnShowVersion.Click += new System.EventHandler(this.btnShowVersion_Click);
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Location = new System.Drawing.Point(363, 308);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(163, 23);
            this.btnLoadXML.TabIndex = 1;
            this.btnLoadXML.Text = "Loading XML File";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // name
            // 
            this.name.DataPropertyName = "StuName";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // age
            // 
            this.age.DataPropertyName = "StuAge";
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "Gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // studentClass
            // 
            this.studentClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentClass.DataPropertyName = "ClassName";
            this.studentClass.HeaderText = "Class";
            this.studentClass.Name = "studentClass";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadXML);
            this.Controls.Add(this.btnShowVersion);
            this.Controls.Add(this.dgvStuList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "XML File Read Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStuList;
        private System.Windows.Forms.Button btnShowVersion;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentClass;
    }
}

