using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_arr_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program to copy one array’s elements to
               another array without using array function. */

            int i;
            int[] arr1 = new int[5];

            Console.WriteLine("Enter the elements : ");
            for (i = 0; i < 5; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n");

            int[] arr2 = new int[5];

            for (i = 0; i < 5; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("\n");

            Console.WriteLine("The elements in first array : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ", arr1[i]);
            }
            
            Console.WriteLine("\n");

            Console.WriteLine("The elements in second array : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ",arr2[i]);
            }

            Console.ReadKey();
        }
    }
}
