using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace DAL
{
  public  class MenuService
    {
        public List<TVNode> GetAllMenu()
        {
            string sql = "select MenuId,MenuName,MenuCode,ParentId from MenuList";
            List<TVNode> nodeList = new List<TVNode>();
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                nodeList.Add(new TVNode()
                {
                    MenuCode = objReader["MenuCode"].ToString(),
                    MenuId=Convert.ToInt32( objReader["MenuId"]),
                    MenuName=objReader["MenuName"].ToString(),
                    ParentId=objReader["ParentId"].ToString()

                });

            }
            objReader.Close();
            return nodeList;
        }

    }
}
