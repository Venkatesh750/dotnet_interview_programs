using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Swap_two_numbers
    {
        public void stn()
        {
            int a, b;
            Console.WriteLine("Enter the 1st value : ");
            a = int.Parse(Console.ReadLine());  // 5
            Console.WriteLine("Enter the 2nd value : ");
            b = int.Parse(Console.ReadLine());  // 4
            Console.WriteLine("Before swap : "+a+b);  // 54
            a = a * b;  // a = 5 * 4  => 20
            b = a / b;  // b = 20/4  => 5
            a = a / b;  // a = 20/5  => 4
            Console.WriteLine("After swap : "+a+b);   // 45
        }
    }
}
