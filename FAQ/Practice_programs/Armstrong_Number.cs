using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Armstrong_Number
    {
        public void arm()
        {
            int n, rem, sum = 0, temp;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n>0)
            {
                rem = n % 10;
                sum = sum + (rem*rem*rem);
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not an armstrong number");
            }
        }
    }
}
