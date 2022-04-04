using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_out_of_range
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            try
            {
                Console.WriteLine("Enter the elements");
                for (int i=0; i<5; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("arr[2] = {0}", arr[2]);
                Console.WriteLine("arr[7] = {0}",arr[7]);
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }

            Console.ReadKey();
        }
    }
}
