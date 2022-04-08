using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GenericClass<int> i = new GenericClass<int>();
            Console.WriteLine("Printing integer value");
            i.GenericFn(5);
            
            GenericClass<string> s = new GenericClass<string>();
            Console.WriteLine("Printing string value");
            s.GenericFn("Venkatesh");

            Console.ReadKey();
        }
    }

    public class GenericClass<T>
    {
        public void GenericFn(T printValue)
        {
            Console.WriteLine(printValue);
        }
    }
}
