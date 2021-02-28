using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _2_6_XML
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            XmlDocument objDoc = new XmlDocument(); // 1, create XML operation object
            objDoc.Load("StuScore.xml");//2, load object of xml file 
            XmlNode rootNode = objDoc.DocumentElement;//3,get root node of xml file
            List<Student> list = new List<Student>();//create list object
            foreach (XmlNode stuNode in rootNode.ChildNodes)//ergodic all nodes
            {
                if (stuNode.Name == "Student")
                {
                    Student objStu = new Student();
                    foreach (XmlNode subNode in stuNode)//ergodic all son nodes
                    {
                        switch (subNode.Name)
                        {
                            case "StuName":
                                objStu.StuName = subNode.InnerText;
                                break;
                            case "StuAge":
                                objStu.StuAge = Convert.ToInt32(subNode.InnerText);
                                break;
                            case "Gender":
                                objStu.Gender = subNode.InnerText;
                                break;
                            case "ClassName":
                                objStu.ClassName = subNode.InnerText;
                                break;

                            default:
                                break;
                        }
                    }
                    list.Add(objStu);
                }
            }
            this.dgvStuList.DataSource = list;
        }

        private void btnShowVersion_Click(object sender, EventArgs e)
        {
            XmlTextReader tReader = new XmlTextReader("StuScore.xml");
            string info = string.Empty;
            while (tReader.Read())
            {
                if (tReader.Name == "Version")
                {
                    info = "Version: " + tReader.GetAttribute("vNo") + "Public time: "
                        + tReader.GetAttribute("pTime");
                    break;
                }
                
            }
            MessageBox.Show(info, "Version information");
        }
    }
}
