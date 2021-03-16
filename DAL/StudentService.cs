using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 学生数据访问类
    /// </summary>
  public  class StudentService
    {
        //判断身份证号是否存在
        public bool IsIdNoExised(string studentIdNo)
        {
            string sql = "select count(*) from Students where StudentIdNo={0} ";
            sql = string.Format(sql, studentIdNo);
            try
            {
                int result = (int)SQLHelper.GetSingleResult(sql);
                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool IsCardNoExised(string cardNo)
        {
            string sql = "select count(*) from Students where CardNo={0} ";
            sql = string.Format(sql, cardNo);
            try
            {
                int result = (int)SQLHelper.GetSingleResult(sql);
                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }


        /// <summary>
        /// 添加学员到数据库
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns>返回学院学号</returns>
        public int AddStudent(Student objStudent)
        {
            string sql = "insert into Students " +
                "(StudentName, Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,CardNo,ClassId,StuImage)";
            sql += " values('{0}','{1}','{2}',{3},{4},'{5}','{6}','{7}',{8},'{9}');select @@identity";
        sql =string.Format(sql, objStudent.StudentName, objStudent.Gender, objStudent.Birthday.ToString("yyyy-MM-dd"),
                objStudent.StudentIdNo, objStudent.Age, objStudent.PhoneNumber,
                objStudent.StudentAddress, objStudent.CardNo, objStudent.ClassId,objStudent.StuImage);

            try
            {
                return Convert.ToInt32( SQLHelper.GetSingleResult(sql));
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

        /// <summary>
        /// 根据班级查询学员列表
        /// </summary>
        /// <param name="className"></param>
        /// <returns>学员列表</returns>
        public List<Student> GetStudentByClass(string className)
        {
            string sql = "select StudentId, StudentName, Gender, Birthday, StudentIdNo, PhoneNumber, StudentAddress, ClassName from" +
                " Students";
            sql += " inner join StudentClass on Students.ClassId=StudentClass.ClassId";
            sql += " where ClassName='{0}'";
            SqlDataReader objReader = SQLHelper.GetReader(string.Format(sql,className));
            List<Student> stuList = new List<Student>();
            try
            {
                while (objReader.Read())
                {
                    stuList.Add(new Student()
                    {
                        StudentId = Convert.ToInt32(objReader["StudentId"]),
                        StudentName = objReader["StudentName"].ToString(),
                        Gender = objReader["Gender"].ToString(),
                        Birthday = Convert.ToDateTime(objReader["Birthday"]),
                        StudentIdNo = objReader["StudentIdNo"].ToString(),
                        PhoneNumber = objReader["PhoneNumber"].ToString(),
                        StudentAddress = objReader["StudentAddress"].ToString(),
                        ClassName = objReader["ClassName"].ToString()

                    });
                }
                objReader.Close();
                return stuList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                objReader.Close(); 
            }
        }


        /// <summary>
        /// 根据学号查询学员信息
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public Student GetStudentByStudentId(string studentId)
        {
            string whereSql = string.Format(" where StudentId={0}", studentId);
            return GetStudentByWhereSql(whereSql);
        }

        /// <summary>
        /// 根据卡号查询学员信息
        /// </summary>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        public Student GetStudentByCardNo(string cardNo)
        {
            string whereSql = string.Format(" where CardNo={0}", cardNo);
            return GetStudentByWhereSql(whereSql);
        }

        private Student GetStudentByWhereSql(string whereSql)
        {
            string sql = "select StudentId, StudentName, Gender, Birthday, StudentIdNo, " +
                "PhoneNumber, StudentAddress, ClassName, StudentAddress, CardNo, StuImage from" +
                " Students";
            sql += " inner join StudentClass on Students.ClassId=StudentClass.ClassId";
            sql += whereSql;
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            try
            {
                if (objReader.Read())
                {
                    return new Student()
                    {
                        StudentId = Convert.ToInt32(objReader["StudentId"]),
                        StudentName = objReader["StudentName"].ToString(),
                        Gender = objReader["Gender"].ToString(),
                        Birthday = Convert.ToDateTime(objReader["Birthday"]),
                        StudentIdNo = objReader["StudentIdNo"].ToString(),
                        PhoneNumber = objReader["PhoneNumber"].ToString(),
                        StudentAddress = objReader["StudentAddress"].ToString(),
                        ClassName = objReader["ClassName"].ToString(),
                        CardNo = objReader["CardNo"].ToString(),
                        StuImage = objReader["StuImage"] == null ? "" : objReader["StuImage"].ToString()


                    };
                }
                else return null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                objReader.Close();
            }
        }

        /// <summary>
        /// 修改学员对象
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public int ModifyStudent(Student objStudent)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update Students set StudentName='{0}', Gender='{1}', Birthday='{2}'");
            sqlBuilder.Append(" ,StudentIdNo={3}, PhoneNumber='{4}', StudentAddress='{5}', ClassId='{6}', " +
                "Age={7}, CardNo={8},StuImage='{9}' where StudentId= {10}");
            string sql = string.Format(sqlBuilder.ToString(), objStudent.StudentName,
                objStudent.Gender, objStudent.Birthday.ToString("yyyy-MM-dd"), objStudent.StudentIdNo, objStudent.PhoneNumber,
                objStudent.StudentAddress, objStudent.ClassId, objStudent.Age, objStudent.CardNo,
                objStudent.StuImage, objStudent.StudentId);
            try
            {
              int result=  SQLHelper.Update(sql);
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("数据库操作异常，信息为："+ex.Message);
            }
            
         
        }


        /// <summary>
        /// 修改学员时判断身份证号和其他学员是否重复
        /// </summary>
        /// <param name="studentIdNo"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public bool IsIdNoExisted(string newStudentIdNo, string studentId)
        {
            string sql = "select count(*) from Students where StudentIdNo={0} and StudentId<>{1} ";
            sql = string.Format(sql, newStudentIdNo, studentId);
            try
            {
                int result = (int)SQLHelper.GetSingleResult(sql);
                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        /// <summary>
        /// 修改学员时，判断是否与其他学员有相同的卡号
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public bool IsCardNoExisted(string newCardNo, string studentId)
        {
            string sql = "select count(*) from Students where CardNo={0} and StudentId<>{1} ";
            sql = string.Format(sql, newCardNo, studentId);
            try
            {
                int result = (int)SQLHelper.GetSingleResult(sql);
                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        #region 删除学员
        public int DeleteStudent(string studentId)
        {
            string sql = "delete from Students where StudentId=" + studentId;
            try
            {
                int result = SQLHelper.Update(sql);
                return result;
            }
            catch(SqlException ex)
            {
                if (ex.Number==547)
                {
                    throw new Exception("该学号被其他实体引用，不能直接删除学员。信息为" + ex.Message);
                }
                else
                {

                    throw new Exception("数据库操作异常，信息为：" + ex.Message);
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        #endregion

    }
}
