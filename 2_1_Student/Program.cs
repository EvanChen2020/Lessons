using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Student
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     // create instance
        //     //Student stu = new Student();
        //     //stu.StudentName = "Evan";
        //     //stu.StudentId = 36;
        //     //Console.WriteLine(stu.GetStudent());
        //     //stu.Age = -10;
        //     //Console.WriteLine(stu.Age);
        //     Student objStudent = new Student();
        //     string info = objStudent.GetStudentInfo("Evan", 036, Convert.ToDateTime("1990-10-10"));
        //     Console.WriteLine(info);
        //
        //     Student objStudent2 = new Student();
        //     objStudent2.StudentName = "Kevin";
        //     objStudent2.StudentId = 37;
        //     objStudent2.Birthday = Convert.ToDateTime("1993-10-10");
        //     objStudent2.ShowStudentInfo();
        //
        //     Console.ReadLine();
        //
        //
        // }
        // static void Main(string[] args)
        // {
        //     Student objStudent = new Student()
        //     {
        //         Birthday = Convert.ToDateTime("1990-09-10"),
        //         StudentId = 36,
        //         StudentName = "Evan"
        //     };
        //     
        // }    

        //static void Main(string[] args)
        //{
        //    // create some student instance
        //    Student objStu1 = new Student(1001, "xiaowang");
        //    Student objStu2 = new Student(1002, "xiaoliu");
        //    Student objStu3 = new Student(1003, "xiaozhang");
        //    Student objStu4 = new Student(1004, "xiaoli");

        //    //create list instance
        //    List<Student> stuList = new List<Student>();
        //    stuList.Add(objStu1);
        //    stuList.Add(objStu2);
        //    stuList.Add(objStu3);
        //    stuList.Add(objStu4);

        //    // get element counts
        //    Console.WriteLine("elements totally : {0}", stuList.Count);
        //    //delete one element
        //    stuList.Remove(objStu3);
        //    stuList.RemoveAt(0);
        //    //insert one instance
        //    stuList.Insert(0, new Student(1005,"xiaobai"));
        //    stuList.Add(new Student()
        //    {
        //        StudentId = 1006,
        //        StudentName = "1006name"
        //    });
        //    //ergodic all element
        //    foreach (Student item in stuList)
        //    {
        //        Console.WriteLine(item.StudentName + "   " + item.StudentId); ;
        //    }


        //}
        //static void Main(string[] args)
        //{
        //    List<string> list = new List<string>(){
        //        "xiaowang","xiaoli","xiaozhang"
        //    };
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    List<Student> listStu = new List<Student>()
        //    {
        //        new Student(){StudentId=101,StudentName="xiaozhang"},
        //        new Student(){StudentId=102,StudentName="xiaoli"}
        //    };
        //    for (int i = 0; i < listStu.Count; i++)
        //    {
        //        Student stu = listStu[i];
        //        Console.WriteLine("name:{0} id:{1} ", stu.StudentId, stu.StudentName);
        //        ;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //       Student objStu1 = new Student(1001, "xiaowang");
        //       Student objStu2 = new Student(1002, "xiaoliu");
        //       Student objStu3 = new Student(1003, "xiaozhang");
        //       Student objStu4 = new Student(1004, "xiaoli");

        //    // create dictionary
        //    Dictionary<string, Student> stus = new Dictionary<string, Student>();
        //    stus.Add("xiaowang", objStu1);
        //    stus.Add("xiaoliu", objStu2);
        //    stus.Add("xiaozhang", objStu3);
        //    stus.Add("xiaoli", objStu4);

        //    // get the element
        //    Console.WriteLine(stus["xiaozhang"].StudentId);
        //    foreach (string key in stus.Keys)
        //    {
        //        Console.WriteLine(key);
        //    };
        //    Console.WriteLine("--------------------");
        //    foreach (Student value in stus.Values)
        //    {
        //        Console.WriteLine(value.StudentName+"\t"+value.StudentId);
        //    }



        //}

        //static void Main(string[] args)
        //{
        //    List<string> list = new List<string>()
        //    {
        //               "xiaowang","xiaozhang","xiaozhang","xiaoli"
        //            };
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("-----------sort---------");
        //    list.Sort();
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    list.Reverse();
        //    Console.WriteLine("---------reverse-----------");
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("---------age-----------");
        //    List<int> ageList = new List<int>() { 20, 25, 21, 26, 22, 27 };
        //    ageList.Sort();
        //    foreach (var item in ageList)
        //    {
        //        Console.WriteLine(item);
        //    }

        //       // create some student instance
        //       Student objStu1 = new Student(1001, "xiaowang");
        //       Student objStu2 = new Student(1002, "xiaoliu");
        //       Student objStu3 = new Student(1003, "xiaozhang");
        //       Student objStu4 = new Student(1004, "xiaoli");

        //       //create list instance
        //       List<Student> stuList = new List<Student>() { objStu1 , objStu2, objStu3, objStu4};
        //    stuList.Sort();
        //    foreach (var item in stuList)
        //    {
        //        Console.WriteLine(item.StudentName+"\t"+item.StudentId);
        //    }
        //}


        static void Main(string[] args)
        {
        

            // create some student instance
            Student objStu1 = new Student(1001, "xiaowang", 20);
            Student objStu2 = new Student(1002, "xiaoliu", 23);
            Student objStu3 = new Student(1003, "xiaozhang",18);
            Student objStu4 = new Student(1004, "xiaoli",50);

            //create list instance
            List<Student> stuList = new List<Student>() { objStu1, objStu2, objStu3, objStu4 };
            
            // default sort
            stuList.Sort();
            Console.WriteLine("-----------default sort--------");
            foreach (var item in stuList)
            {
                Console.WriteLine(item.StudentName + "\t" + item.StudentId);
            }

            // asc sort
            stuList.Sort(new StuNameASC());
            Console.WriteLine("-----------name increase sort--------");
            foreach (var item in stuList)
            {
                Console.WriteLine(item.StudentName + "\t" + item.Age + "\t" + item.StudentId);
            }
            // desc sort
            stuList.Sort(new StuNameDESC());
            Console.WriteLine("-----------name increase sort--------");
            foreach (var item in stuList)
            {
                Console.WriteLine(item.StudentName + "\t" + item.Age + "\t" + item.StudentId);
            }

            // asc sort
            stuList.Sort(new AgeASC());
            Console.WriteLine("-----------age increase sort--------");
            foreach (var item in stuList)
            {
                Console.WriteLine(item.StudentName + "\t" + item.Age+"\t" + item.StudentId);
            }
            // desc sort
            stuList.Sort(new AgeDESC());
            Console.WriteLine("-----------age increase sort--------");
            foreach (var item in stuList)
            {
                Console.WriteLine(item.StudentName + "\t" + item.Age + "\t" + item.StudentId);
            }
        }
    } 
}
