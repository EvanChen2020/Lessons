using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Student
{
    class Calculator
    {
        public Calculator()
        {

        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, double b)
        {
            return a + (int)b;
        }

        public int Add(double a, double b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }

        public int Add(double a, int b)
        {
            return (int)a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
