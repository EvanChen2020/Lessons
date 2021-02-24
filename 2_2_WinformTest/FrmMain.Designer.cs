namespace _2_2_WinformTest
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
            this.BtnTest = new System.Windows.Forms.Button();
            this.btnAndy = new System.Windows.Forms.Button();
            this.btnCarry = new System.Windows.Forms.Button();
            this.btnCoco = new System.Windows.Forms.Button();
            this.btnTestMessageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(33, 187);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 0;
            this.BtnTest.Text = "Test Button Action";
            this.BtnTest.UseVisualStyleBackColor = true;
            // 
            // btnAndy
            // 
            this.btnAndy.Location = new System.Drawing.Point(257, 29);
            this.btnAndy.Name = "btnAndy";
            this.btnAndy.Size = new System.Drawing.Size(109, 34);
            this.btnAndy.TabIndex = 1;
            this.btnAndy.Text = "Andy Teacher";
            this.btnAndy.UseVisualStyleBackColor = true;
            // 
            // btnCarry
            // 
            this.btnCarry.Location = new System.Drawing.Point(257, 80);
            this.btnCarry.Name = "btnCarry";
            this.btnCarry.Size = new System.Drawing.Size(109, 34);
            this.btnCarry.TabIndex = 2;
            this.btnCarry.Text = "Carry Teacher";
            this.btnCarry.UseVisualStyleBackColor = true;
            // 
            // btnCoco
            // 
            this.btnCoco.Location = new System.Drawing.Point(257, 131);
            this.btnCoco.Name = "btnCoco";
            this.btnCoco.Size = new System.Drawing.Size(109, 34);
            this.btnCoco.TabIndex = 3;
            this.btnCoco.Text = "Coco Teacher";
            this.btnCoco.UseVisualStyleBackColor = true;
            // 
            // btnTestMessageBox
            // 
            this.btnTestMessageBox.Location = new System.Drawing.Point(12, 29);
            this.btnTestMessageBox.Name = "btnTestMessageBox";
            this.btnTestMessageBox.Size = new System.Drawing.Size(151, 54);
            this.btnTestMessageBox.TabIndex = 4;
            this.btnTestMessageBox.Text = "Test Message Box";
            this.btnTestMessageBox.UseVisualStyleBackColor = true;
            this.btnTestMessageBox.Click += new System.EventHandler(this.btnTestMessageBox_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(422, 239);
            this.Controls.Add(this.btnTestMessageBox);
            this.Controls.Add(this.btnCoco);
            this.Controls.Add(this.btnCarry);
            this.Controls.Add(this.btnAndy);
            this.Controls.Add(this.BtnTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button btnAndy;
        private System.Windows.Forms.Button btnCarry;
        private System.Windows.Forms.Button btnCoco;
        private System.Windows.Forms.Button btnTestMessageBox;
    }
}

