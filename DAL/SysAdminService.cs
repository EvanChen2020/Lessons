using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    //管理员数据访问类
  public  class SysAdminService
    {
        //修饰符-》返回值-》参数
        /// <summary>
        /// 根据账号和密码登录
        /// </summary>
        /// <param name="objAdmin">包含账户和密码的对象</param>
        /// <returns></returns>
        //public SysAdmin AdminLogin(SysAdmin objAdmin)
        //{
        //    //SQL 语句编写
        //    string sql = "select AdminName from Admins where LoginId={0}" +
        //        " and LoginPwd='{1}' ";
        //    sql = string.Format(sql, objAdmin.LoginId, objAdmin.LoginPwd);

        //    //调用通用数据访问类
        //    try
        //    {
        //        SqlDataReader objReader = SQLHelper.GetReader(sql);
        //        if (objReader.Read())
        //        {
        //            objAdmin.AdminName = objReader["AdminName"].ToString();
        //        }
        //        else
        //            objAdmin = null;
        //        objReader.Close();
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Data base communication exception! information: " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    return objAdmin;
               
        //}

        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            string sql = "select AdminName from Admins where LoginId=@LoginId and LoginPwd=@LoginPwd";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginId",objAdmin.LoginId),
                new SqlParameter("@LoginPwd",objAdmin.LoginPwd)
            };
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql, param);
                if (objReader.Read())
                {
                    objAdmin.AdminName = objReader["AdminName"].ToString();
                }
                else
                    objAdmin = null;
                objReader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Data base communication exception! information: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return objAdmin;
        }

        public int ModifyPwd(SysAdmin objAdmin)
        {
            string sql = "update Admins set LoginPwd='{0}' where LoginId={1}";
            sql = string.Format(sql, objAdmin.LoginPwd,objAdmin.LoginId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("修改密码出现数据库访问错误：" + ex.Message);
            }
        }
    }
}
