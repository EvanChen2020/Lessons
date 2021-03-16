using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 数据表访问类
    /// </summary>
   public class ScoreListService
    {
        //根据班级查询考试成绩（或全校成绩列表）
        //public List<Student> QueryScoreList(string className)
        //{
        //    string sql = "select Students.StudentId,StudentName,ClassName,Gender,CSharp,SQLServerDB" +
        //        " from Students" +
        //        " inner join StudentClass on Students.ClassId= StudentClass.ClassId " +
        //        "inner join ScoreList on ScoreList.StudentId= Students.StudentId";
        //    if (className!=null && className.Length!=0)
        //    {
        //        sql += string.Format(" where ClassName ='{0}'", className);
        //    }
        //    SqlDataReader objReader = SQLHelper.GetReader(sql);
        //    List<Student> stuList = new List<Student>();
        //    while (objReader.Read())
        //    {
        //        stuList.Add(new Student()
        //        {
        //            StudentId = Convert.ToInt32(objReader["StudentId"]),
        //            StudentName = objReader["StudentName"].ToString(),
        //            ClassName = objReader["ClassName"].ToString(),
        //            Gender = objReader["Gender"].ToString(),
        //            CSharp = Convert.ToInt32(objReader["CSharp"]),
        //            SQLServerDB = Convert.ToInt32(objReader["SQLServerDB"])
        //        });
        //    }
        //    objReader.Close();
        //    return stuList;

        //}

        public List<StudentExt> QueryScoreList(string className)
        {
            string sql = "select Students.StudentId,StudentName,ClassName,Gender,CSharp,SQLServerDB" +
                " from Students" +
                " inner join StudentClass on Students.ClassId= StudentClass.ClassId " +
                "inner join ScoreList on ScoreList.StudentId= Students.StudentId";
            if (className != null && className.Length != 0)
            {
                sql += string.Format(" where ClassName ='{0}'", className);
            }
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<StudentExt> stuList = new List<StudentExt>();
            while (objReader.Read())
            {
                stuList.Add(new StudentExt()
                {
                    StudentObj=new Student()
                    {
                        Gender = objReader["Gender"].ToString(),
                        StudentId = Convert.ToInt32(objReader["StudentId"]),
                        StudentName = objReader["StudentName"].ToString()
                    },
                    ClassObj=new StudentClass()
                    {
                        ClassName = objReader["ClassName"].ToString()
                    },
                    ScoreObj=new ScoreList()
                    {
                        CSharp = Convert.ToInt32(objReader["CSharp"]),
                        SQLServerDB = Convert.ToInt32(objReader["SQLServerDB"])
                    }
                });
            }
            objReader.Close();
            return stuList;

        }

        //根据班级统计考试成绩相关信息（或全校考试成绩统计）
        /// <summary>
        /// 查询统计结果
        /// </summary>
        /// <param name="classId"></param>
        /// <returns>返回统计结果</returns>
        public Dictionary<String,String>QueryScoreInfo(string classId)
        {
            //查询考试总人数，C#和DB平均分
            string sql = "select stuCount=count(*),avgCSharp=avg(CSharp),avgDB=avg(SQLServerDB) from ScoreList" +
                " inner join Students on Students.StudentId=ScoreList.StudentId";

            if (classId!=null&&classId.Length!=0)
            {
                sql += string.Format(" where ClassId={0}", classId);
            }
            sql += ";select absentCount=count(*) from Students where StudentId not in " +
                "(select StudentId from ScoreList)";

            //查询缺考总人数
            if (classId != null && classId.Length != 0)
            {
                sql += string.Format(" and ClassId={0}", classId);
            }
            SqlDataReader objReader= SQLHelper.GetReader(sql);
            Dictionary<string, string> scoreInfo = new Dictionary<string, string>();

            if (objReader.Read())
            {
                scoreInfo.Add("stuCount", objReader["stuCount"].ToString());
                scoreInfo.Add("avgCSharp", objReader["avgCSharp"].ToString());
                scoreInfo.Add("avgDB", objReader["avgDB"].ToString());
            }
            if (objReader.NextResult())
            {
                if (objReader.Read())
                {
                    scoreInfo.Add("absentCount", objReader["absentCount"].ToString());
                }
                
            }
            objReader.Close();
            return scoreInfo;
        }

        //根据班级查询缺考人员列表（或全校缺考人员列表）
        /// <summary>
        /// 根据班级查询缺考人员列表（或全校缺考人员列表）
        /// </summary>
        /// <param name="classId"></param>
        /// <returns>缺口人员姓名</returns>
        public List<string> QueryAbsentList(string classId)
        {
            //查询考试总人数，C#和DB平均分
            string sql = "select StudentName from Students where StudentId not in " +
                "(select StudentId from ScoreList)";

            //查询缺考总人数
            if (classId != null && classId.Length != 0)
            {
                sql += string.Format(" and ClassId={0}", classId);
            }
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<string> absentList = new List<string>();

            while (objReader.Read())
            {
                absentList.Add( objReader["StudentName"].ToString());
            }
            objReader.Close();
            return absentList;
        }



        #region 使用DataSet保存数据
        public DataSet GetAllScoreList()
        {
            string sql = "select Students.StudentId,StudentName,ClassName,Gender,PhoneNumber,Csharp,SQLServerDB " +
                "from Students inner join StudentClass on StudentClass.ClassId=Students.ClassId" +
                " inner join ScoreList on ScoreList.StudentId=Students.StudentId";
           return SQLHelper.GetDataSet(sql);
        }
        #endregion
    }
}
