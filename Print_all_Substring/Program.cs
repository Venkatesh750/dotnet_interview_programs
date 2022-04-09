using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the value : ");
                string val;
                val = Console.ReadLine();
                for (int i = 1; i < val.Length; i++)
                {
                    for (int j = 0; j <= val.Length - i; j++)
                    {
                        string substr = val.Substring(j, i);
                        Console.WriteLine(substr);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
