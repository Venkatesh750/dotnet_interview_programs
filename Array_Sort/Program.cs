using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sort
{
    class Program
    {
        static void Arr(int[] arr)
        {
            Console.WriteLine("\n Elements of Array : \n");
            foreach (int i in arr)
            {
                Console.Write("\t{0}", i);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write("Enter the numbers : \t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program.Arr(arr);
            Array.Sort(arr);
            Program.Arr(arr);
            Console.ReadLine();
        }

    }
}
