using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Prime_Number
    {
        public void pn()
        {
            int i=2, flag = 0, n;
            Console.WriteLine("Enter a number to check prime or not :");
            n = int.Parse(Console.ReadLine());
            while(i<n)
            {
                if (n%2==0)
                {
                    Console.WriteLine(n+" is not a prime");
                    flag = 1;
                    break;
                }
                i++;
            }
            if (flag==0)
            {
                Console.WriteLine(n+" is a prime");
            }
        }
    }
}
