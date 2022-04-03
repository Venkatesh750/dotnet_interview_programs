using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter a character : ");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine("{0} is vowel", ch);
            }
            else
            {
                Console.WriteLine("{0} is not a vowel", ch);
            }

            Console.ReadKey();
        }
    }
}
