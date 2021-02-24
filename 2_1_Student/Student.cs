using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Student
{
    /// <summary>
    /// Student class
    /// </summary>
    class Student:IComparable<Student>//the deafualt sort function only has one solution
    {
        public Student()
        {
            this.StudentId = 36;
            this.StudentName = "Evan";
        }
        public Student(int stuId, string stuName)
        {
            this.StudentId = stuId;
            this.StudentName = stuName;
        }
        // public Student(int stuId, string stuName, int age)
        // {
        //     this.StudentId = stuId;
        //     this.StudentName = stuName;
        //     this.Age = age;
        // }

        public Student(int stuId, string stuName, int age)
            :this(stuId, stuName)
        {
           // this.StudentId = stuId;
           // this.StudentName = stuName;
            this.Age = age;
        }

        // statement: student name
        private string studentName = string.Empty;
        private int studentId ;
        private int age;
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        //property
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int Age
        {
            get { return age; }
            //  set { age = value; }
            set
            {
                if (value < 18)
                    age = 18;
                else
                    age = value;
            }
        }
        // function
        public string GetStudent()
        {
            string Info = string.Format("Name:{0} Id:{1}", studentName, studentId);
            return Info;
        }/// <summary>
        /// use input update the information
        /// </summary>
        /// <param name="stuName">student name</param>
        /// <param name="stuId">student id</param>
        /// <param name="birthday">student birthday</param>
        /// <returns>feed back full information of student </returns>
        public string GetStudentInfo(string stuName,int stuId,DateTime birthday)
        {
            this.Birthday = birthday;
            string Info = string.Format("Name: {0} ID : {1}", stuName, stuId);
            return Info;
        }/// <summary>
        /// show student information
        /// </summary>
        public void ShowStudentInfo()
        {
            string info = string.Format("Name: {0} ID: {1} Age: {2}", studentName, studentId, DateTime.Now.Year - Birthday.Year);
            Console.WriteLine(info);
        }

        int IComparable<Student>.CompareTo(Student other)
        {
            //decrease
         //   return other.studentId.CompareTo(this.studentId);

            // increase
            return this.studentId.CompareTo(other.studentId);
        }

        /// <summary>
        /// interface implement
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        // public int CompareTo(Student other)
        // {
        //     return other.studentId.CompareTo(this.studentId);
        // }
    }

    #region
    class StuNameASC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.StudentName.CompareTo(y.StudentName);
        }
    }
    class StuNameDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.StudentName.CompareTo(x.StudentName);
        }
    }

    class AgeASC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
    class AgeDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.Age.CompareTo(x.Age);
        }
    }
    #endregion
}
