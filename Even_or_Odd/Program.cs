using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing the variable 'num'
            int num;

            //getting value from the user
            Console.Write("Enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());

            //condition to check even or odd
            if (num%2==0)
            {
                Console.WriteLine("{0} is even number",num);
            }
            else
            {
                Console.WriteLine("{0} is odd number",num);
            }
            Console.ReadKey();
        }
    }
}
