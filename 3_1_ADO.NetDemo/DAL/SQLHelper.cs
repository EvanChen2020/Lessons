using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace _3_1_ADO.NetDemo
{
    /// <summary>
    /// General Communicate with Data base
    /// </summary>
    class SQLHelper
    {
        private static string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        /// <summary>
        /// feedback signal result
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }

        /// <summary>
        /// update function
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        /// <summary>
        /// feed back a result collection
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return objReader;
        }
    }
}
