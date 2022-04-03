using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_elements_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[5];
            Console.WriteLine("Enter the elements : ");
            
            for (i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n");

            Console.WriteLine("The elements are : ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} ", arr[i]);
            }

            Console.ReadKey();
        }
    }
}
