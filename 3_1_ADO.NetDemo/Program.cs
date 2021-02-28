using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using _3_1_ADO.NetDemo.DAL;
using _3_1_ADO.NetDemo.Models;

namespace _3_1_ADO.NetDemo
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    // define connection string
        //    string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        //    //create connection obj
        //    SqlConnection conn = new SqlConnection(connString);
        //    //open conncetion
        //    conn.Open();
        //    // check if connection is open
        //    if (ConnectionState.Open == conn.State)
        //    {
        //        Console.WriteLine("Connection is Opened!");
        //    }

        //    //close connection
        //    conn.Close();
        //    if (ConnectionState.Closed == conn.State)
        //    {
        //        Console.WriteLine("Connection is Closed!");
        //    }


        //}

        //static void Main(string[] args)
        //{
        //    // define connection string
        //    string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        //    //create connection obj
        //    SqlConnection conn = new SqlConnection(connString);


        //    // create SQL sentence
        //    string sql = "insert into Students(StudentName,Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,ClassId)";
        //    sql += "values('{0}','{1}','{2}',{3},{4},'{5}','{6}',{7})";
        //    sql = string.Format(sql, "XiaoLi", "N", "1999-05-10", 20001, 23, "01234567899", "dfsdfsaf", 1);
        //    // create command object
        //    //SqlCommand cmd = new SqlCommand();
        //    //cmd.CommandText = sql;
        //    //cmd.Connection = conn;
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    //open conncetion
        //    conn.Open();
        //    // execute
        //    int result = cmd.ExecuteNonQuery();


        //    //close connection
        //    conn.Close();
        //    if(result==1)
        //    {
        //        Console.WriteLine("Insert success!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Insert failed!");
        //    }



        //}

        //static void Main(string[] args)
        //{
        //    // define connection string
        //    string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        //    //create connection obj
        //    SqlConnection conn = new SqlConnection(connString);

        //    // create SQL sentence
        //    string sql = "update Students set StudentName='{0}' where StudentIdNo={1}";
        //    sql = string.Format(sql, "XiaoGang",  20001);
        //    // create command object
        //    //SqlCommand cmd = new SqlCommand();
        //    //cmd.CommandText = sql;
        //    //cmd.Connection = conn;
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    //open conncetion
        //    conn.Open();
        //    // execute
        //    int result = cmd.ExecuteNonQuery();
        //    //close connection
        //    conn.Close();
        //    if (result == 1)
        //    {
        //        Console.WriteLine("update success!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("update failed!");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    // define connection string
        //    string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        //    //create connection obj
        //    SqlConnection conn = new SqlConnection(connString);

        //    // create SQL sentence
        //    string sql = "delete from Students where StudentIdNo={0}";
        //    sql = string.Format(sql, 20001);
        //    // create command object
        //    //SqlCommand cmd = new SqlCommand();
        //    //cmd.CommandText = sql;
        //    //cmd.Connection = conn;
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    //open conncetion
        //    conn.Open();
        //    // execute
        //    int result = cmd.ExecuteNonQuery();
        //    //close connection
        //    conn.Close();
        //    if (result == 1)
        //    {
        //        Console.WriteLine("delete success!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("delete failed!");
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    // define connection string
        //    string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        //    //create connection obj
        //    SqlConnection conn = new SqlConnection(connString);
        //    // create SQL sentence
        //    string sql = "insert into Students(StudentName,Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,ClassId)";
        //    sql += "values('{0}','{1}','{2}',{3},{4},'{5}','{6}',{7})";
        //    string sql1 = string.Format(sql, "XiaoLi1", "N", "1999-05-10", 20001, 23, "01234567899", "dfsdfsaf", 1);
        //    string sql2 = string.Format(sql, "XiaoLi2", "N", "1999-05-10", 20002, 23, "01234567899", "dfsdfsaf", 1);
        //    string sql3 = string.Format(sql, "XiaoLi3", "N", "1999-05-10", 20003, 23, "01234567899", "dfsdfsaf", 1);
        //    string sql4 = string.Format(sql, "XiaoLi4", "N", "1999-05-10", 20004, 23, "01234567899", "dfsdfsaf", 1);
        //    // create command object
        //    SqlCommand cmd = new SqlCommand(sql1+";"+ sql2 + ";"+ sql3 + ";"+ sql4, conn);

        //    //open conncetion
        //    conn.Open();
        //    // execute
        //    int result = cmd.ExecuteNonQuery();
        //    //close connection
        //    conn.Close();
        //    if (result == 4)
        //    {
        //        Console.WriteLine("Insert success!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Insert failed!");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    // define connection string
        //    string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        //    //create connection obj
        //    SqlConnection conn = new SqlConnection(connString);
        //    // create SQL sentence
        //    string sql = "insert into Students(StudentName,Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,ClassId)";
        //    sql += "values('{0}','{1}','{2}',{3},{4},'{5}','{6}',{7});select @@identity";
        //    string sql1 = string.Format(sql, "Xiaogang", "N", "1999-05-10", 20005, 23, "01234567899", "dfsdfsaf", 1);
        //      // create command object
        //    SqlCommand cmd = new SqlCommand(sql1, conn);

        //    //open conncetion
        //    conn.Open();
        //    // execute
        //    object result = cmd.ExecuteScalar();
        //    //close connection
        //    conn.Close();
        //    if (Convert.ToInt32( result) >= 0)
        //    {
        //        Console.WriteLine("Insert success!" +"result:" + result);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Insert failed!");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    // define connection string
        //    string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        //    //create connection obj
        //    SqlConnection conn = new SqlConnection(connString);
        //    // create SQL sentence
        //  //  string sql = "select count(*) from Students";
        //    string sql = "select StudentName from Students where StudentId=10020";
        //    // create command object
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    //open conncetion
        //    conn.Open();
        //    // execute
        //    object result = cmd.ExecuteScalar();
        //    //close connection
        //    conn.Close();
        //    if ((Convert.ToString(result)).Length>0)
        //    {
        //        Console.WriteLine("success!" + "result:" + result);
        //    }
        //    else
        //    {
        //        Console.WriteLine("failed!");
        //    }

        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    // define connection string
        //    string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        //    //create connection obj
        //    SqlConnection conn = new SqlConnection(connString);
        //    // create SQL sentence
        //    //  string sql = "select count(*) from Students";
        //    string sql = "select StudentId, StudentName, Gender from Students";
        //    // create command object
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    //open conncetion
        //    conn.Open();
        //    // execute
        //    SqlDataReader objReader = cmd.ExecuteReader();
        //    // read data
        //    while (objReader.Read())
        //    {
        //        //Console.WriteLine(objReader["StudentId"].ToString()+"\t" + objReader["StudentName"]+"\t"
        //        //    +objReader["Gender"]);

        //        Console.WriteLine(objReader[0].ToString() + "\t" + objReader[1] + "\t"
        //         + objReader["Gender"]);
        //    }

        //    //close reader
        //    objReader.Close();

        //    //close connection
        //    conn.Close();


        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    // define connection string
        //    string connString = "Server=XS-N-1022\\WINCCPLUSMIG2014;DataBase=StudentManageDB;Uid=sa;Pwd=Evan18662181690";
        //    //create connection obj
        //    SqlConnection conn = new SqlConnection(connString);
        //    // create SQL sentence
        //    //  string sql = "select count(*) from Students";
        //    string sql = "select StudentId, StudentName from Students; " +
        //        "select ClassId, ClassName from StudentClass";
        //    // create command object
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    conn.Open();
        //    SqlDataReader objReader = cmd.ExecuteReader();
        //    while (objReader.Read())
        //    {
        //        Console.WriteLine(objReader["StudentId"].ToString() + "\t"+
        //            objReader["StudentName"].ToString());
        //    }
        //    Console.WriteLine("------------------------------");
        //    if (objReader.NextResult())
        //    {
        //        while (objReader.Read())
        //        {
        //            Console.WriteLine(objReader["ClassId"].ToString() + "\t"+

        //                objReader["ClassName"].ToString());
        //        }
        //    }

        //    objReader.Close();
        //    conn.Close();

        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    string sql = "select Count(*) from Students";
        //    object result = SQLHelper.GetSingleResult(sql);
        //    Console.WriteLine(result);

        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    string sql = "update Students set StudentName='LiuJinJin' where StudentId=10020";
        //    object result = SQLHelper.Update(sql);
        //    Console.WriteLine(result);

        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    string sql = "select StudentName from Students";
        //    SqlDataReader objReader = SQLHelper.GetReader(sql);
        //    while (objReader.Read())
        //    {
        //        Console.WriteLine(objReader["StudentName"].ToString());
        //    }
        //    objReader.Close();//automatically close connection

        //    Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    Student objStudent = new Student();
        //    Console.WriteLine("student name:");
        //    objStudent.StudentName = Console.ReadLine();
        //    Console.WriteLine("student gender:");
        //    objStudent.Gender = Console.ReadLine();
        //    Console.WriteLine("student birthday:");
        //    objStudent.Birthday = Convert.ToDateTime(Console.ReadLine());
        //    Console.WriteLine("student student id number:");
        //    objStudent.StudentIdNo = Convert.ToDecimal(Console.ReadLine());
        //    Console.WriteLine("student age:");
        //    objStudent.Age =Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("student phone number:");
        //    objStudent.PhoeneNumber = Console.ReadLine();
        //    Console.WriteLine("student student address:");
        //    objStudent.StudentAddress = Console.ReadLine();
        //    Console.WriteLine("student class id:");
        //    objStudent.ClassId = Convert.ToInt32(Console.ReadLine());

        //    StudentService objStuService = new StudentService();
        //   int result = objStuService.AddStudent(objStudent);
        //    Console.WriteLine(result);

        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    StudentService objStuService = new StudentService();
        //    Student objStudent = objStuService.GetStudentById("10022");
        //    Console.WriteLine(objStudent.StudentName + "\t" + objStudent.Gender); ;

        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    StudentService objStuService = new StudentService();
        //    List<Student> list = objStuService.GetAllStudents();

        //    if (list.Count!=0)
        //    {
        //        foreach (var item in list)
        //        {
        //            Console.WriteLine("-------------------------");
        //            Console.WriteLine(item.StudentName + "\t" + item.Gender + "\t" + item.StudentIdNo);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("No data");
        //    }


        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    StudentService objStuService = new StudentService();
        //    List<StudentExt> list = objStuService.GetStudentExt();

        //    if (list.Count != 0)
        //    {
        //        foreach (var item in list)
        //        {
        //            Console.WriteLine("-------------------------");
        //            Console.WriteLine(item.ObjStudent.StudentName + "\t" + item.ObjClass.ClassName + "\t" + item.ObjScore.CSharp);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("No data");
        //    }


        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    StudentService objStuService = new StudentService();

        //    List<StudentSimpleExt> list = objStuService.GetStudentScore();

        //    if (list.Count != 0)
        //    {
        //        foreach (var item in list)
        //        {
        //            Console.WriteLine("-------------------------");
        //            Console.WriteLine(item.StudentName + "\t" + item.ClassName + "\t" + item.AvgScore);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("No data");
        //    }

        //    try
        //    {
        //        int result = objStuService.DeleteStudentById("10008");
        //        if (result==1)
        //        {
        //            Console.WriteLine("delete success！");
        //        }
        //        else
        //        {
        //            Console.WriteLine("delete failed ！");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    Console.ReadLine();
        //}


        static void Main(string[] args)
        {
            Console.WriteLine("please input amount");
            try
            {
                InputAmount(Convert.ToInt32(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               // throw;
            }
            Console.ReadLine();
        }

        static void InputAmount(int amount)
        {
            if (amount < 50)
            {
                throw new Exception("the amount must bigger than 50!");
            }
            else if (amount > 3000)
            {
                throw new Exception("the amount must smaller than 3000!");

            }
        }
    }
}
