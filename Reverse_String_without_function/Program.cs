using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rev_str_without_arr_fn
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
                Console.Write("String before reverse : {0}\n",val);

                char[] ch = val.ToCharArray();

                Console.Write("String after reverse : ");
                string rev_string="";
                int length;

                length = val.Length - 1;

                while (length >= 0)
                {
                    rev_string = rev_string + val[length];
                    length--;
                }
                Console.WriteLine(rev_string);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
