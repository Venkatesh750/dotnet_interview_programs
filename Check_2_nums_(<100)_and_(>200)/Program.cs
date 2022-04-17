using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lt_or_gt_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to check two given numbers where one is
               less than 100 and other is greater than 200 */

            int m, n;
            Console.Write("Enter the first number (<100): ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number (>200): ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m < 100 && n > 200));

            Console.ReadKey();
        }
    }
}
