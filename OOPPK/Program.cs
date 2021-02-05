using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPK
{
    class Program
    {

        #region Procedure Oriented
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please input the first operator number:");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Please input the second operator number:");
        //    int b = int.Parse(Console.ReadLine());

        //    int result1 =Add(a,b);
        //    int result2 = Sub(a, b);
        //    Console.WriteLine("a + b = "+ result1);
        //    Console.WriteLine("a - b = " + result2);
        //    Console.Read();
        //}

        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Sub(int a, int b)
        //{
        //    return a - b;
        //}
        #endregion

        #region Object Oriented
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the first operator number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second operator number:");
            int b = int.Parse(Console.ReadLine());

            // OOP
            Calculator calculator = new Calculator();

            int result1 = calculator.Add(a, b);
            int result2 = calculator.Sub(a, b);
            Console.WriteLine("a + b = " + result1);
            Console.WriteLine("a - b = " + result2);

            Console.WriteLine("Please input the first operator float number:");
            double  c = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second operator float number:");
            double d = double.Parse(Console.ReadLine());

            double result3 = calculator.Add(c, d);
            double result4 = calculator.Sub(c, d);
            Console.WriteLine("c + d = " + result3);
            Console.WriteLine("c - d = " + result4);
            Console.Read();
        }

        #endregion


    }
}
