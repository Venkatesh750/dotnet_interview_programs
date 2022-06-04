using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice_programs
{
    class File_Handling
    {
        public void fh()
        {
            FileStream fs = new FileStream(@"D:\sample.txt",FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Text file is created!!");
            sw.WriteLine("Sample text");
            sw.Close();
            fs.Close();
        }
        public void fh1()
        {
            FileStream fs = new FileStream(@"D:\sample.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string lines = sr.ReadLine();
            while (lines != null)
            {
                Console.WriteLine(lines);
                lines = sr.ReadLine();
            }
        }
    }
}
