using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_ADO.NetDemo.Models
{
    public class StudentExt
    {
        //public StudentExt()
        //{
        //    ObjStudent = new Student();
        //    ObjClass = new StudentClass();
        //    ObjScore = new StudentScore();
        //}

        public Student ObjStudent { get; set; }
        public StudentClass ObjClass { get; set; }
        public StudentScore ObjScore { get; set; }
    }
}
