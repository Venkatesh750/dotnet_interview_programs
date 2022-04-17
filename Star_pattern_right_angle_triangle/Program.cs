using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to display the
               pattern like right angle triangle using an asterisk. 
                The pattern like :

                *
                **
                ***
                ****   */
            int i, j;
            for (i = 1; i <5; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
