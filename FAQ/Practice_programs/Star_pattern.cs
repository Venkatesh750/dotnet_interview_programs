using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_programs
{
    class Star_pattern
    {
        public void st_p()
        {
            int i, j;
            for (i=0; i<=5; i++)
            {
                for (j=1; j<=i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }
    }
}
