using _3_1_ADO.NetDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_ADO.NetDemo.DAL
{
    /// <summary>
    /// Student information communicate with Data base
    /// </summary>
   public class StudentService
    {
        ///// <summary>
        ///// add a new student
        ///// </summary>
        ///// <param name="stuName"></param>
        ///// <param name="gender"></param>
        ///// <param name="birthday"></param>
        ///// <param name="stuIdNo"></param>
        ///// <param name="age"></param>
        ///// <param name="phoneNumber"></param>
        ///// <param name="stuAddress"></param>
        ///// <param name="classId"></param>
        ///// <returns></returns>
        //    public int AddStudent(string stuName, string gender, DateTime birthday,
        //        string stuIdNo, int age, string phoneNumber, string stuAddress, int classId)
        //    {
        //        string sql = "insert into Students (StudentName,Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,ClassId) ";
        //        sql += " values('{0}','{1}','{2}',{3},{4},'{5}','{6}',{7})";
        //        sql = string.Format(sql, stuName, gender, birthday,
        //        stuIdNo, age, phoneNumber, stuAddress, classId);
        //        return SQLHelper.Update(sql);
        //    }

        //    public int GetStuCountByClassId(string classId)
        //    {
        //        string sql = "select Count(*) from Students where ClassId=" +
        //            classId;
        //        return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
        //    }
        //}

        public int AddStudent(Student objStudent)
        {
            string sql = "insert into Students (StudentName,Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,ClassId) ";
            sql += " values('{0}','{1}','{2}',{3},{4},'{5}','{6}',{7})";
            sql = string.Format(sql, objStudent.StudentName, objStudent.Gender, objStudent.Birthday,
            objStudent.StudentIdNo, objStudent.Age, objStudent.PhoeneNumber, objStudent.StudentAddress, objStudent.ClassId);
            return SQLHelper.Update(sql);
        }

        public int GetStuCountByClassId(string classId)
        {
            string sql = "select Count(*) from Students where ClassId=" +
                classId;
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
        }

        public Student GetStudentById(string studentId)
        {
            string sql = "select StudentName,Gender,Birthday,StudentIdNo,StudentAddress from Students where StudentId={0}";
            sql = string.Format(sql, studentId);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Student objStudent = null;
            if (objReader.Read())
            {
                //objStudent = new Student();
                //objStudent.StudentName = objReader["StudentName"].ToString();
                //objStudent.Gender = objReader["Gender"].ToString();
                //objStudent.Birthday = Convert.ToDateTime( objReader["Birthday"].ToString());
                //objStudent.StudentIdNo =Convert.ToDecimal( objReader["StudentIdNo"].ToString());
                //objStudent.StudentAddress = objReader["StudentAddress"].ToString();
                objStudent = new Student()
                {
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(objReader["Birthday"].ToString()),
                    StudentIdNo = Convert.ToDecimal(objReader["StudentIdNo"].ToString()),
                    StudentAddress = objReader["StudentAddress"].ToString()
                };
            }
            objReader.Close();
            return objStudent;
        }
        public List<Student> GetAllStudents()
        {
            string sql = "select StudentName,Gender,Birthday,StudentIdNo,StudentAddress from Students";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Student> stuList = new List<Student>();
            while (objReader.Read())
            {
                //Student objStudent = new Student()
                // {
                //     StudentName = objReader["StudentName"].ToString(),
                //     Gender = objReader["Gender"].ToString(),
                //     Birthday = Convert.ToDateTime(objReader["Birthday"].ToString()),
                //     StudentIdNo = Convert.ToDecimal(objReader["StudentIdNo"].ToString()),
                //     StudentAddress = objReader["StudentAddress"].ToString()
                // };
                // stuList.Add(objStudent);

                stuList.Add(new Student()
                {
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(objReader["Birthday"].ToString()),
                    StudentIdNo = Convert.ToDecimal(objReader["StudentIdNo"].ToString()),
                    StudentAddress = objReader["StudentAddress"].ToString()
                });
            }
            objReader.Close();
            return stuList;
        }
    
    
        public List<StudentExt> GetStudentExt()
        {
            string sql = "select Students.StudentId,StudentName,ClassName,CSharp,SQLServer from Students ";
            sql += "inner join StudentClass on StudentClass.ClassId=Students.ClassId ";
            sql += "inner join ScoreList on Students.StudentId=ScoreList.StudentId";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<StudentExt> extList = new List<StudentExt>();
            while (objReader.Read())
            {
                StudentExt ext = new StudentExt();
                ext.ObjStudent = new Student()
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = objReader["StudentName"].ToString()

                };
                ext.ObjClass = new StudentClass()
                {
                    ClassName = objReader["ClassName"].ToString()
                };

                ext.ObjScore = new StudentScore()
                {
                    CSharp = Convert.ToInt32(objReader["CSharp"]),
                    SQLServerDB = Convert.ToInt32(objReader["SQLServer"])
                };

                extList.Add(ext);

            }
            objReader.Close();

            return extList;


        }

        public List<StudentSimpleExt> GetStudentScore()
        {
            string sql = "select Students.StudentId,StudentName,";
            sql += "AvgScore=(CSharp+SQLServer)/2 ";
            sql += "from Students ";
            sql += "inner join StudentClass on StudentClass.ClassId=Students.ClassId ";
            sql += "inner join ScoreList on Students.StudentId=ScoreList.StudentId";
            List<StudentSimpleExt> extList = new List<StudentSimpleExt>();
            SqlDataReader objReader = null ;

            try
            {
                 objReader = SQLHelper.GetReader(sql);
           
                while (objReader.Read())
                {
                    extList.Add(new StudentSimpleExt()
                    {
                        StudentName = objReader["StudentName"].ToString(),
                        StudentId = Convert.ToInt32(objReader["StudentId"]),
                        AvgScore = Convert.ToInt32(objReader["AvgScore"])
                    });

                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               // return -1;
               //将异常信息保存在日志中。。。
               throw ex;
            }
            finally // don't care about exception, these code will be exceted
            {
                if (objReader != null)
                {
                    objReader.Close();
                    Console.WriteLine("objReader closed!");
                }
                
            }
        
            

            return extList;


        }
  
        public int DeleteStudentById(string studentId)
        {
            string sql = string.Format("delete from Students where StudentId={0}", studentId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("this student information are used in another table, can't delete it！");
                }
                else
                {
                    throw new Exception("data base operation has fault, can't delet it. error information is:：" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("data base operation has fault, can't delet it. error information is:：" + ex.Message);
            }
        }
    }

}
