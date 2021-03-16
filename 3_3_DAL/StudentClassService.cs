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
  public  class StudentClassService
    {
        public List<StudentClass> GetAllClasses()
        {
            string sql = "select ClassName,ClassId from StudentClass";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<StudentClass> list = new List<StudentClass>();
            while (objReader.Read())
            {
                list.Add(new StudentClass()
                {
                    ClassId = Convert.ToInt32(objReader["ClassId"]),
                    ClassName = objReader["ClassName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 获取所有的班级（存放在数据集里面）
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllClass()
        {
            string sql = "select ClassId,ClassName from StudentClass";
            return SQLHelper.GetDataSet(sql);
        }
    }
}
