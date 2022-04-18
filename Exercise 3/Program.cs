using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# to read any Month Number in integer
               and display the number of days for this month */

            int mon_no;

            Console.Write("Enter the Month No : ");
            mon_no = Convert.ToInt32(Console.ReadLine());
            switch (mon_no)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("Month have 31 days \n");
                    break;
                case 2:
                    Console.Write("The 2nd month is a February and have 28 days \n");
                    Console.Write("in leap year The February month  Have 29 days \n");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("Month have 30 days \n");
                    break;
                default:
                    Console.Write("invalid Month number.\nPlease try again ....\n");
                    break;
            }

            Console.ReadKey();
        }
    }
}
