using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Sum_of_digits
    {
        public void sod()
        {
            int n, rem, total = 0;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                rem = n % 10;
                total = total + rem;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits : "+total);
        }
    }
}
