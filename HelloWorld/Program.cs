using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{/// <summary>
/// main program
/// </summary>
    class Program
    {
        /*
     * multiple line comment
     */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world !");
            Console.WriteLine("....................");
            Console.WriteLine("Please input your age:");
            string age = Console.ReadLine();
            Console.WriteLine("You inputting age is:" + age);
            Console.ReadLine();
            int result = Add(10, 20);
            Console.WriteLine(result);
        }

        #region add function
        /// <summary>
        /// add function between int
        /// </summary>
        /// <param name="a">the first parameter</param>
        /// <param name="b">the second parameter</param>
        /// <returns></returns>
        static int Add(int a, int b)
        {
            return a + b;
        }
        #endregion
    }
}
