using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// reference namespace
using System.IO;

namespace _2_4_FrmFile
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // write into file
        private void btnWriteAll_Click(object sender, EventArgs e)
        {
            //[1] create file stream
            FileStream fs = new FileStream("C:\\Test\\myfile.txt", FileMode.Create);
            //[2] create write unit
            StreamWriter sw = new StreamWriter(fs);
            //[3] write date by stream
            sw.Write(this.txtContent.Text.Trim());
            //[4] close write unit
            sw.Close();
            //[5] close stream
            fs.Close();

        }

        // read file
        private void btnReadAll_Click(object sender, EventArgs e)
        {
            //[1] create file stream
            FileStream fs = new FileStream("C:\\Test\\myfile.txt", FileMode.Open);
            //[2] create reader unit
            // sometimes we don't know the encoding
           // StreamReader sw = new StreamReader(fs,Encoding.Default);
            StreamReader sr = new StreamReader(fs);
            //[3] read date by stream
            this.txtContent.Text = sr.ReadToEnd();
            //[4] close reader unit
            sr.Close();
            //[5] close stream
            fs.Close();
        }

        private void btnWriteLine_Click(object sender, EventArgs e)
        {
            //[1] create file stream
            FileStream fs = new FileStream("C:\\Test\\myfile.txt", FileMode.Append);
            //[2] create write unit
            StreamWriter sw = new StreamWriter(fs);
            //[3] write data one line by one line using stream
            sw.WriteLine(DateTime.Now.ToString() + "  [File operation right]");
            //[4] close write unit
            sw.Close();
            //[5] close stream
            fs.Close();
        }
        //delete file
        private void btnDel_Click(object sender, EventArgs e)
        {
            File.Delete(this.txtFrom.Text);

        }

        // Copy file
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtTo.Text.Trim()))
            {
                File.Delete(this.txtTo.Text);
            }
            if (File.Exists(this.txtFrom.Text.Trim()))
            {
                File.Copy(this.txtFrom.Text.Trim(), this.txtTo.Text.Trim());
            }
        }

        // remove file
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtTo.Text.Trim()))
            {
                File.Delete(this.txtTo.Text);
            }
            if (File.Exists(this.txtFrom.Text.Trim()))
            {
                File.Move(this.txtFrom.Text.Trim(), this.txtTo.Text.Trim());
            }
            else
            {
                MessageBox.Show("No file", "information");
            }
        }

        private void btnShowAllFiles_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("C:\\Temp");
            this.txtContent.Clear();
            foreach (var item in files)
            {
                this.txtContent.Text += item + "\r\n";
            }
        }

        private void btnShowSubDir_Click(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetDirectories("C:\\Temp");
            this.txtContent.Clear();
            foreach (var item in dirs)
            {
                this.txtContent.Text += item + "\r\n";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\Test\\Test2");
        }

        private void btnDelAllFiles_Click(object sender, EventArgs e)
        {
            //Directory.Delete("C:\\Test\\Test2");//request directory is empty

            //directoryInfo, can delete unempty directory
            DirectoryInfo dir = new DirectoryInfo("C:\\Test");
            dir.Delete(true);



        }
    }
}
