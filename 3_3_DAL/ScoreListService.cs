using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using _3_3_Models;

namespace _3_3_DAL
{
  public  class ScoreListService
    {
        #region 按照全校成绩查询
        /// <summary>
        /// 根据班级查询考试成绩列表
        /// 如果输入为null，则查询所有班级
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public List<StudentExt> GetScoreList(string className)
        {
            string sql = "select Students.StudentId,StudentName,ClassName,CSharp,SQLServer from Students  ";
            sql += " inner join ScoreList on Students.StudentId= Scorelist.StudentId ";
            sql += " inner join StudentClass on Students.ClassId= StudentClass.ClassId";
            if (className!=null&&className.Length!=0)
            {
                sql += string.Format(" where ClassName='{0}'", className);
            }
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<StudentExt> list = new List<StudentExt>();
            while(objReader.Read())
            {
                list.Add(new StudentExt()
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = objReader["StudentName"].ToString(),
                    ClassName = objReader["ClassName"].ToString(),
                    CSharp=Convert.ToInt32( objReader["CSharp"]),
                    SQLServer=Convert.ToInt32(objReader["SQLServer"])

                });
            }
            objReader.Close();
            return list;


        }

        /// <summary>
        /// 获取全部考试信息
        /// </summary>
        /// <returns></returns>
        public Dictionary<string,string> GetScoreInfo()
        {
            string sql = "select stuCount=count(*),avgCsharp=avg(CSharp)," +
                "avgDB=avg(SQLServer) from ScoreList;";
            sql += "select absentCount=count(*) from Students " +
                "where StudentId not in(select StudentId from ScoreList) ";
            Dictionary<string, string> scoreInfo = null;
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            if (objReader.Read())
            {
                scoreInfo = new Dictionary<string, string>();
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

        /// <summary>
        /// 获取所有未参加考试的学员名单
        /// </summary>
        /// <returns></returns>
        public List<string> GetAbsentList()
        {
            string sql = "select StudentName from Students where StudentId not in(select StudentId from ScoreList)";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<string> list = new List<string>();
            while (objReader.Read())
            {
                list.Add(objReader["StudentName"].ToString());
            }
            objReader.Close();
            return list;
        }

        #endregion

        #region 按照班级统计考试信息
        public Dictionary<string, string>GetScoreInfoByClassId(string classId)
        {
            string sql = "select stuCount=count(*),avgCSharp=avg(CSharp),avgDB=avg(SQLServer) from ScoreList ";
            sql += " inner join Students on Students.StudentId=ScoreList.StudentId where ClassId={0};";
            sql += " select absentCount=count(*) from Students where StudentId not in ";
            sql += " (select StudentId from ScoreList) and ClassId={1}";
            sql = string.Format(sql, classId, classId);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Dictionary<string, string> scoreInfo = null;
            if (objReader.Read())//读取考试成绩统计结果
            {
                scoreInfo = new Dictionary<string, string>();
                scoreInfo.Add("stuCount", objReader["stucount"].ToString());
                scoreInfo.Add("avgCSharp", objReader["avgCSharp"].ToString());
                scoreInfo.Add("avgDB", objReader["avgDB"].ToString());
            }
            if (objReader.NextResult())//读取缺考人数列表
            {
                if (objReader.Read())
                {
                    scoreInfo.Add("absentCount", objReader["absentCount"].ToString());
                }
            }
            objReader.Close();
            return scoreInfo;

        }


        /// <summary>
        /// 查询未参加考试的学生名单
        /// </summary>
        /// <returns></returns>
        public List<string> GetAbsentListByClassId(string classId)
        {
            string sql = "select StudentName from Students where StudentId not in ";
            sql += "(select StudentId from ScoreList) and ClassId={0}";
            sql = string.Format(sql, classId);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<string> list = new List<string>();
            while (objReader.Read())
            {
                list.Add(objReader["StudentName"].ToString());
            }
            objReader.Close();
            return list;
        }

        #endregion


        #region 基于数据集DataSet的数据查询
        /// <summary>
        /// 获取所有的考试信息（存储在DataSet中）
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllScoreList()
        {
            string sql = "select Students.StudentId,StudentName,ClassName,CSharp,SQLServer ";
            sql += " from Students";
            sql += " inner join StudentClass on StudentClass.ClassId=Students.ClassId ";
            sql += " inner join ScoreList on ScoreList.StudentId=Students.StudentId ";
            return SQLHelper.GetDataSet(sql);
        }
        #endregion

    }
}
