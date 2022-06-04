using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Factorial
    {
        public void ft()
        {
            int n, fact;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());  // 5
            fact = n;  // fact = 5
            while (n>1)  // 5 > 1 .. 4 > 1 .. 3 > 1 .. 2 > 1 .. 1 > 1(false)
            {
                n--;  // 4 .. 3 .. 2 .. 1
                fact = fact * n;  // fact = 5 * 4 = 20 .... 20 * 3 = 60 .... 60 * 2 = 120 .... 120 * 1 = 120
            }
            Console.WriteLine("Factorial is "+fact);
        }
    }
}
