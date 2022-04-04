using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Welcome");
            a = Convert.ToInt32(Console.ReadLine());

            try
            {
                if(a==5 || a < 5)
                {
                    Console.WriteLine("Congratulations you have got an {0}",a);
                    Console.ReadLine();
                }
                else
                {
                    throw (new OutofStockException("OutofStockExceptoin generated"));
                    
                }

            }
            catch (OutofStockException oe)
            {
                Console.WriteLine(oe.Message.ToString());
                Console.ReadLine();
            }
        }
    }
    //Creating custom exception
    public class OutofStockException : Exception
    {
        public OutofStockException(string message) : base(message)
        {

        }
    }
}
