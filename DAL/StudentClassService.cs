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
    /// 学生班级数据访问类
    /// </summary>
 public   class StudentClassService
    {
        public List<StudentClass> GetAllClass()
        {
            string sql = "select * from StudentClass ";
            List<StudentClass> list = new List<StudentClass>();
            try
            {
                SqlDataReader reader = SQLHelper.GetReader(sql);
                while (reader.Read())
                {
                    list.Add(new StudentClass()
                    {
                        ClassId = Convert.ToInt32(reader["ClassId"].ToString()),
                        ClassName = reader["ClassName"].ToString()
                    });
                }
                reader.Close();
                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取所有的班级
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllClasses()
        {
            string sql = "select ClassId,ClassName from StudentClass";
            return SQLHelper.GetDataSet(sql);
        }

    }
}
