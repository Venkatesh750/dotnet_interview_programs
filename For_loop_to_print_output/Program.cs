using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Using for loop print the following output on console
                 1
                121
               12321
              1234321
             123454321 */

            int i, j;
            for (i = 0; i < 6; i++)
            {
                for (j = 1; j <= 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                for (j = i - 1; j >= 1; j--)
                {
                    Console.Write("{0}", j);
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
