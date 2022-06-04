using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Fibonacci
    {
        /*public void fb()
        {
            int n1 = 0, n2 = 1, n3, number, i;
            Console.WriteLine("Enter the number of elements :");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1+" "+n2+" ");
            for (i=2; i<number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }
        }*/

        public void fb()
        {
            int f = 0, s = 1, t, number, i;
            Console.WriteLine("Enter the number of elements :");
            number = int.Parse(Console.ReadLine());
            Console.Write(f + " " + s+ " ");  // 0 1
            for (i=2; i<number; ++i)
            {
                t = f + s;               // 0+1  1+1  1+2 2+3
                Console.Write(t + " ");  //  1    2    3   5 ...
                f = s;                   // f=1  f=1  f=2 f=3
                s = t;                   // s=1  s=2  s=3 s=5
            }

        }
    }
}
