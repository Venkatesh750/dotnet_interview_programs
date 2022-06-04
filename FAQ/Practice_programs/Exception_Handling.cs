using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Exception_Handling
    {
        public void ex_h()
        {
            try
            {
                int a, b, c;
                Console.Write("Enter the value a : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter the value b : ");
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
