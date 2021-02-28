using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_3_Models;
using System.Data;
using System.Data.SqlClient;

namespace _3_3_DAL
{
  /// <summary>
  /// 学员数据访问类
  /// </summary>
  public  class StudentService
    {
        #region insert student information
        /// <summary>
        /// check if the student id number is exit or not
        /// </summary>
        /// <param name="studentIdNo"></param>
        /// <returns></returns>
        public bool IsIdNoExisted(string studentIdNo)
        {
            string sql = "select count(*)from Students where StudentIdNo={0} ";
            sql = string.Format(sql, studentIdNo);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result > 0)
                return true;
            else return false;
           // return (1 == Convert.ToInt32(SQLHelper.GetSingleResult(sql)));
        }
        public bool IsIdNoExisted(string studentIdNo, string studentId)
        {
            string sql = "select count(*)from Students where StudentIdNo={0} and StudentId<>{1}";
            sql = string.Format(sql, studentIdNo, studentId);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result > 0)
                return true;
            else return false;
            // return (1 == Convert.ToInt32(SQLHelper.GetSingleResult(sql)));
        }

        /// <summary>
        /// insert student information
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public int AddStudent(Student objStudent)
        {
            //[1]编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into Students" +
                " (StudentName,Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,CardNo,ClassId)");
            sqlBuilder.Append(" values('{0}','{1}','{2}',{3},{4},'{5}','{6}','{7}','{8}')");
            //[2]解析对象
            string sql = string.Format(sqlBuilder.ToString(),
                objStudent.StudentName, objStudent.Gender, objStudent.BirthDay,
                objStudent.StudentIdNo, objStudent.Age, objStudent.PhoneNumber,
                objStudent.StudentAddress, objStudent.CardNo, objStudent.ClassId);

            //[3]提交到数据库
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                throw new Exception("Data base operation exception! the information is:" + ex.Message);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }


        #endregion

        #region 查询学员
        public List<StudentExt> GetStudentByClass(string className)
        {
            string sql = "select StudentName,StudentId,Gender,Birthday,ClassName from Students ";
            sql += " inner join StudentClass on Students.ClassId=StudentClass.ClassId ";
            sql += " where ClassName='{0}'";
            sql = string.Format(sql, className);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<StudentExt> list = new List<StudentExt>();
            while (objReader.Read())
            {
                list.Add(new StudentExt()
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    BirthDay = Convert.ToDateTime(objReader["Birthday"]),
                    ClassName= objReader["ClassName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 根据学号查询
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public StudentExt GetStudentById(string studentId)
        {
            string sql = "select StudentName,StudentId,Gender,Birthday,ClassName" +
                ",StudentIdNo,PhoneNumber,StudentAddress,CardNo from Students ";
            sql += " inner join StudentClass on Students.ClassId=StudentClass.ClassId ";
            sql += " where StudentId=" +studentId;
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            StudentExt objStudent = null;
            if (objReader.Read())
            {
                objStudent =new StudentExt()
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    BirthDay = Convert.ToDateTime(objReader["Birthday"]),
                    ClassName = objReader["ClassName"].ToString(),
                CardNo=objReader["CardNo"].ToString(),
                StudentIdNo=Convert.ToInt64( objReader["PhoneNumber"].ToString()),
                PhoneNumber=objReader["PhoneNumber"].ToString(),
                StudentAddress=objReader["StudentAddress"].ToString()
                
                
                
                };
            }
            objReader.Close();
            return objStudent;
        }
        #endregion

        #region  修改学员对象

        /// <summary>
        /// 修改学员对象
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public int ModifyStudent(Student objStudent)
        {
            StringBuilder sqlBuiler = new StringBuilder();
            sqlBuiler.Append("Update Students set StudentName='{0}',Gender='{1}'," +
                " Birthday={2},StudentIdNo={3},Age={4},PhoneNumber='{5}',StudentAddress='{6}'," +
                "CardNo='{7}',ClassId={8} ");
            sqlBuiler.Append("Where StudentId={9}");

            //[2]解析对象
            string sql = string.Format(sqlBuiler.ToString(),
                objStudent.StudentName, objStudent.Gender, objStudent.BirthDay,
                objStudent.StudentIdNo, objStudent.Age, objStudent.PhoneNumber,
                objStudent.StudentAddress, objStudent.CardNo, objStudent.ClassId);


            //[3]提交到数据库
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                throw new Exception("Data base operation exception! the information is:" + ex.Message);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        #endregion
    }
}
