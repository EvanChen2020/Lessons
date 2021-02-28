using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_ADO.NetDemo.Models
{
    /// <summary>
    /// 学生实体类
    /// </summary>
   public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public  string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public decimal StudentIdNo { get; set; }
        public int Age { get; set; }
        public string PhoeneNumber { get; set; }
        public string StudentAddress { get; set; }
        public int ClassId { get; set; }

    }
}
