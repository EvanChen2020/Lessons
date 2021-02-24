using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // string info = "E-mail address: {0} E-mail type is: {1}";
            // info = string.Format(info, "Email address", "Email type");
            // Console.WriteLine(info);
            // Console.WriteLine("Total:{0:C4}",5587616514);

            // string a = "";
            // Console.WriteLine(a.Length);
            // string b = null;
            //// Console.WriteLine(b.Length);
            ///
            //string strText = "I am learning";
            //strText += ".Net platm";
            //strText += "and C# language";
            //Console.WriteLine(strText);
            //Console.ReadLine();

            //StringBuilder myBuilder = new StringBuilder();
            //myBuilder.Append("I am learning ");
            //myBuilder.Append(".Net platform ");
            //myBuilder.Append("C# language");
            //Console.WriteLine(myBuilder.ToString());
            //Console.ReadLine();
            //int[] netScore1 = new int[3] { 67, 89, 78 };
            //int[] netScore2 = new int[] { 67, 89, 78 };
            //int[] netScore3 = { 67, 89, 78 };

            //int[] netScore = new int[] { 67, 68, 98, 56, 98, 49 };
            //int sumScore = 0;
            ////for (int i = 0; i < netScore.Length; i++)
            ////{
            ////    sumScore += netScore[i];

            ////}
            //foreach (var i in netScore)
            //{
            //    sumScore += i;
            //}
            //int avgScore = sumScore / netScore.Length;
            //Console.WriteLine("the avg is {0}",avgScore);

            //string name1 = "x i a o w a n g";
            //string[] letterArray = name1.Split();

            //string name2 = "xiaowang,xiaoliu,xiaojiang";
            //string[] nameList = name2.Split(',');

            //// use '_' to connect all charater
            //string name3 = string.Join("_", nameList);
            //Console.WriteLine(name3);

            //int wangScore = 90;
            //int zhangScore = wangScore;
            //Console.WriteLine("xiaowang score: {0} xiaozhang score: {1}",wangScore, zhangScore);

            //zhangScore += 5;
            //Console.WriteLine("------------------after updating-----------------");
            //Console.WriteLine("xiaowang score: {0} xiaozhang score: {1}", wangScore, zhangScore);

            int[] score = { 90, 90 };
            Console.WriteLine("xiaowang score: {0} xiaozhang score: {1}", score[0], score[1]);

            int[] editedScore = score;
            editedScore[1] += 5;
            Console.WriteLine("------------------after updating-----------------");
            Console.WriteLine("xiaowang score: {0} xiaozhang score: {1}", editedScore[0], editedScore[1]);
            Console.WriteLine("xiaowang score: {0} xiaozhang score: {1}", score[0], score[1]);
        }
    }
}
