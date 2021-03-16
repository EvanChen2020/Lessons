using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    /// <summary>
    /// 访问SQLServer数据通用类
    /// </summary>

    class SQLHelper
    {
        //定义连接字符串
       public static readonly string  connString= ConfigurationManager.ConnectionStrings["connString"].ToString();

        #region
        /// <summary>
        /// 执行增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        //public static int Update(string sql)
        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //     SqlCommand cmd = new SqlCommand(sql,conn);
        //    try
        //    {
        //        conn.Open();
        //        return cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        //将异常写入日志

        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        public static int Update(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //将异常写入日志
                        cmd.Dispose();
                        throw ex;
                    }
                }
            }        
        }

        public static int Update(string sql,SqlParameter[] param)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddRange(param);
                        //foreach (SqlParameter item in param)
                        //{
                        //    cmd.Parameters.Add(item);
                        //}
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //将异常写入日志
                        cmd.Dispose();
                        throw ex;
                    }
                }
            }
        }


        /// <summary>
        /// 执行单一结果查询
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
                //将异常写入日志

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行一个结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>返回一个SqlDataReader</returns>
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
                //将异常写入日志
                if (conn.State==ConnectionState.Open)
                    conn.Close();

                throw ex;
            }
            
        }


        /// <summary>
        /// 执行单一结果查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql,SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //将异常写入日志

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行一个结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>返回一个SqlDataReader</returns>
        public static SqlDataReader GetReader(string sql,SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //将异常写入日志
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                throw ex;
            }

        }

        /// <summary>
        /// 执行返回数据集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            //创建数据适配器对象
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                //将异常写入日志
       
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }


        /// <summary>
        /// 获取数据库服务器时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetServerTime()
        {
            return Convert.ToDateTime(GetSingleResult("select getdate()"));
        }
        #endregion



        /// <summary>
        /// 启用事务执行多条Sql语句
        /// </summary>
        /// <param name="sqlList"></param>
        /// <returns></returns>
        public static bool UpdateByTran(List<string> sqlList)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();//开启事务
                foreach (string itemSql in sqlList)
                {
                    cmd.CommandText = itemSql;
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();//提交事务（真正保存到数据库,同时自动清除事务）
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction!=null)
                {
                    cmd.Transaction.Rollback();//回滚事务（同时自动清除事务）
                }
                throw new Exception("调用事务方法 public static bool UpdateByTran(List<string> sqlList)时出错：" + ex.Message);
            }
            finally
            {
                if (cmd.Transaction!=null)  //这个是防止Transaction非空
                {
                    cmd.Transaction = null;//清除事务
                }
                conn.Close();
            }

        }
    }


}
