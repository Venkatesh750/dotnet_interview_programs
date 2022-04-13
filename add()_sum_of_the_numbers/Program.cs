using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_fn
{
    class Program
    {
        static void Main(string[] args)
        {
            add();

            Console.ReadKey();
        }
        public static void add()
        {
            int num1, num2, res;
            Console.Write("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            res = num1 + num2;

            Console.WriteLine("The addition of {0} + {1} = {2}",num1,num2,res);
        }
    }
}
