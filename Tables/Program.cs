using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int j=1; j<=10; j++)
            {
                Console.Write("{0} x {1} = {2} \n",n,j,n*j);
            }
        }
    }
}
