using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_num
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program to calculate power of given number by user*/
            int base_num, exp_num, value;
            Console.Write("Enter the base number : ");
            base_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the exponent : ");
            exp_num = Convert.ToInt32(Console.ReadLine());
            value = Convert.ToInt32(Math.Pow(base_num, exp_num));
            Console.WriteLine("The value of {0} to the power of {1} is : {2}", base_num, exp_num, value);

            Console.ReadKey();
        }
    }
}
