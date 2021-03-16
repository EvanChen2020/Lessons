using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 考勤表访问类
    /// </summary>
  public  class AttendanceService
    {
        //public int AddRecord(string cardNo)
        //{
        //    string sql = string.Format("insert into Attendance (CardNo) values ('{0}')", cardNo);
        //    try
        //    {
        //      int result=  SQLHelper.Update(sql);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        /// <summary>
        /// 添加考勤记录
        /// </summary>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        public string AddRecord(string cardNo)
        {
            string sql = string.Format("insert into Attendance (CardNo) values ('{0}')", cardNo);
            try
            {
                int result = SQLHelper.Update(sql);
                if (result == 1)
                {
                    return "Success!";
                }
                else return "打开失败！系统出现问题，请联系管理员！";
              
            }
            catch (Exception ex)
            {

                return "打开失败！系统出现问题，请联系管理员！"+ex.Message;
            }
        }

        /// <summary>
        /// 获取学员总数（应到人数）
        /// </summary>
        /// <returns></returns>
        public int GetStudentCount()
        {
            string sql = "select count(*) from Students";
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
        }


        /// <summary>
        /// 获取当天已经签到的学员总数
        /// </summary>
        /// <returns></returns>
        public int GetSignStudents()
        {
            string sql = "select count(distinct CardNo) from Attendance where DTime between '{0}' and '{1}'";
            DateTime dt1 = Convert.ToDateTime(SQLHelper.GetServerTime().ToShortDateString());

            sql = string.Format(sql, dt1, dt1.AddDays(1.0));
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));

        }

        /// <summary>
        /// 获取当天已经签到的学员总数
        /// </summary>
        /// <returns></returns>
        public int GetSignStudents(DateTime beginTime)
        {
            string sql = "select count(distinct CardNo) from Attendance where DTime between '{0}' and '{1}'";

            sql = string.Format(sql, beginTime, beginTime.AddDays(1.0));
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));

        }

        //根据日期和姓名查询考勤信息
        public List<Student> GetStudentBySignDate(DateTime beginTime,DateTime endTime, string stuName)
        {
            string sql = "select DTime,StudentId,StudentName,Gender,ClassName,Attendance.CardNo from Students" +
                " inner join StudentClass on Students.ClassId=StudentClass.ClassId" +
                " inner join Attendance on Students.CardNo=Attendance.CardNo " +
                " where DTime between '{0}' and '{1}' ";
            sql = string.Format(sql, beginTime, endTime);
            if (stuName!=null && stuName.Length!=0)
            {
                sql += string.Format(" and StudentName='{0}'", stuName);
            }
            sql += " Order by DTime ASC";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Student> list = new List<Student>();
            while (objReader.Read())
            {
                list.Add(new Student()
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    CardNo = objReader["CardNo"].ToString(),
                    SignTime = Convert.ToDateTime(objReader["DTime"]),
                    ClassName = objReader["ClassName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }


    }
}
