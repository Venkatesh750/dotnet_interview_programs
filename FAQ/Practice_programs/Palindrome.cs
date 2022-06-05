using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Palindrome
    {
        //Palindrome in string
        public void stPalinddrome()
        {
            string value, rev;
            Console.WriteLine("Enter the value to check whether palindrome or not");
            value = Convert.ToString(Console.ReadLine());
            char[] ch = value.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = value.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine(value + " is a palindrome");
            }
            else
            {
                Console.WriteLine(value + " is not a palindrome");
            }
        }
    }
}
