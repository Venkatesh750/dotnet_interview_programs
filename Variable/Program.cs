using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, city;
            int age;
            long phoneno;

            //getting value from user
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            Console.Write("Enter your city : ");
            city = Console.ReadLine();
            Console.Write("Enter your age : ");
            age = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your phoneno : ");
            phoneno = Convert.ToInt64(Console.ReadLine());

            Console.Write("\n");

            //printing values
            Console.WriteLine("Your complete address \n");
            Console.WriteLine("Name = {0}", name);
            Console.WriteLine("City = {0}", city);
            Console.WriteLine("Age = {0}", age);
            Console.WriteLine("Phoneno = {0}", phoneno);

            Console.ReadKey();
        }
    }
}
