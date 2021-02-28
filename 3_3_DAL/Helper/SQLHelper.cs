using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;//引入读取配置文件的命名空间


namespace _3_3_DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
 public  class SQLHelper
    {
        //private static string connString =
        //    "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        public readonly static  string connString =Common.StringSecurity.DESDecrypt(
            ConfigurationManager.ConnectionStrings["connString"].ToString());

        /// <summary>
        /// 执行增删改方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //将错误信息写入日志

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //将错误信息写入日志

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行结果集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //将错误信息写入日志
                conn.Close();
                throw ex;
            }
           
        }



    }
}
