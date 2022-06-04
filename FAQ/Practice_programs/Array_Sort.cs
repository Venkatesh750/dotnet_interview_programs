using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Array_Sort
    {
        public void Arr_sort()
        {
            int[] arr = new int[5];
            int i;

            Console.WriteLine("Enter the elements :");
            for (i=0; i<5; i++)
            {
               arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Before sorting : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.Write("\n");
            Console.Write("After sorting : ");
            Array.Sort(arr);
            for (i=0; i<5; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write("\n");
        }
    }
}
