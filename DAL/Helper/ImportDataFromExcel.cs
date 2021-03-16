using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 从Excel中导入数据
    /// </summary>
   public class ImportDataFromExcel
    {
        /// <summary>
        /// 将选择的Excel数据表查询后封装成对象集合
        /// </summary>
        /// <param name="path">Excel文件路径</param>
        /// <returns></returns>
        public List<Student> GetStudentByExcel(string path)
        {
            List<Student> list = new List<Student>();
            string sql = "select*from [Student$]";
            DataSet ds = OleDbHelper.GetDataSet(sql, path);
            DataTable dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Student()
                {
                    StudentName = row["姓名"].ToString(),
                    Gender = row["性别"].ToString(),
                    PhoneNumber = row["电话号码"].ToString(),
                    Birthday = Convert.ToDateTime(row["出生日期"].ToString()),
                    StudentIdNo = row["身份证号"].ToString(),
                    Age = DateTime.Now.Year - Convert.ToDateTime(row["出生日期"].ToString()).Year,
                    CardNo = row["考勤卡号"].ToString(),
                    StudentAddress = row["家庭住址"].ToString(),
                    ClassId = Convert.ToInt32(row["班级编号"])
                }
                );
            }
            return list;
        }


        public bool Import(List<Student> list)
        {
            StringBuilder sqlBuilder = new StringBuilder("insert into Students " +
                "(StudentName, Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,CardNo,ClassId)");
            sqlBuilder.Append(" values('{0}','{1}','{2}',{3},{4},'{5}','{6}','{7}',{8}) ");

            List<string> sqlList = new List<string>();

            //【2】解析对象
            foreach (Student objStudent in list)
            {
                string   sql = string.Format(sqlBuilder.ToString(), objStudent.StudentName, 
                    objStudent.Gender, objStudent.Birthday.ToString("yyyy-MM-dd"),
                   objStudent.StudentIdNo, objStudent.Age, objStudent.PhoneNumber,
                   objStudent.StudentAddress, objStudent.CardNo, objStudent.ClassId);
               // SQLHelper.Update(sql);
                //将解析的SQL语句添加到集合
                sqlList.Add(sql);
            }

            //【3】将SQL语句集合提交到数据库
            return SQLHelper.UpdateByTran(sqlList);
        }
    }
}
