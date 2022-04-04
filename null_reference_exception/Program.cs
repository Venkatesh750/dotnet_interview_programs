using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_reference_exception
{
    class Program
    {
        static void Main(string[] args)
        {

            string value = null;
            try
            {
                int length = value.Length;
                Console.WriteLine(length);

                Console.ReadLine();
            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine(ne.Message);
            }

            Console.ReadLine();
            
        }
    }
}
