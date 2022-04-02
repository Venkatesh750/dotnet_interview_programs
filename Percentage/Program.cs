using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percentage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sub1, sub2, sub3, sub4, total;
            double per;
            label:
            Console.Write("\nEnter marks of subjects to find out the percentage. \n");
            Console.Write("Enter  the marks of Subject1 : ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  the marks of Subject2 : ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  the marks of Subject3 : ");
            sub3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  the marks of Subject4 : ");
            sub4 = Convert.ToInt32(Console.ReadLine());
            total = sub1 + sub2 + sub3 + sub4;
            per = total / 4;
            Console.Write("Percentage = {0}%\n", per);
            Console.Write("Do you want to continue ? Y/N \t");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'Y' || ch == 'y')
            {
                goto label;
            }

        }
    }
}
