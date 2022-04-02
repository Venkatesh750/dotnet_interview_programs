using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_a_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing the variable 'value'
            int value;

            //getting value from the user
            label:
            Console.Write("Enter the number (1-7) : ");
            value = Convert.ToInt32(Console.ReadLine());

            //switch statement to check the condition
            switch (value)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid option !! \n");
                    goto label;
            }
            Console.ReadKey();
        }
    }
}
