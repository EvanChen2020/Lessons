using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_DAL
{
  public  class AttendanceService
    {
        public string AddRecord(string cardNo)
        {
            string sql = "insert into Attendance (CardNo) values('{0}')";
            sql = string.Format(sql, cardNo);
            try
            {
                SQLHelper.Update(sql);
                return "success";
            }
            catch (Exception ex)
            {

                return "Add record failed, please find help from admin!" + ex.Message;
            }
        }
    }
}
