using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Reverse_Number
    {
        public void rn()
        {
            int n, rem, rev = 0;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                rem = n % 10;
                rev = (rev*10) + rem;
                n = n / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
