using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_the_elements_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[5];
            Console.Write("Enter the elements : \n");
            for (i=0; i<5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nElements are\n");
            for (i=0; i<5; i++)
            {
                Console.Write("{0} \t",arr[i]);
            }

            Console.WriteLine("\n");
            Console.WriteLine("\nElements in reverse order\n");
            Array.Reverse(arr);
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} \t", arr[i]);
            }

            Console.ReadKey();
        }
    }
}
