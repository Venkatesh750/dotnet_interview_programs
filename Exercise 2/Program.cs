using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to read roll no, name and
               marks of three subjects and calculate the total, percentage and division. */

            double rl_no, phy, che, mat, total;
            double per;
            string name, div;
            
            Console.Write("Enter the roll number : ");
            rl_no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Name : ");
            name = Console.ReadLine();

            Console.Write("Enter the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks of Mathematics : ");
            mat = Convert.ToInt32(Console.ReadLine());

            total = phy + che + mat;
            per = total / 3.0;
            if (per >= 60)
            {
                div = "First";
            }
            else if (per < 60 && per >= 48)
            {
                div = "Second";
            }
            else if (per < 48 && per >= 36)
            {
                div = "Pass";
            }
            else
            {
                div = "Fail";
            }

            Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl_no, name);
            Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Mathematics : {2}\n", phy, che, mat);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);

            Console.ReadKey();
        }
    }
}
