using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Elements_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 4, 9, 2, 10 };
            Console.Write("Elements of array is : ");
            foreach (int i in arr)
            {
                Console.Write("\t"+i);
            }

            int sum = arr.Sum();
            Console.WriteLine("\nSum of elements of array : "+sum);

            Console.ReadKey();
        }
    }
}
