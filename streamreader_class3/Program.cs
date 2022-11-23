using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamreader_class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the file path");
            string filepath = Console.ReadLine();
            FileInfo file = new FileInfo(filepath);

            if (file.Exists)
            {
                StreamReader sr = new StreamReader(filepath);
                string s = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(s);
                Console.Read();
            }
            else
            {
                Console.WriteLine("invalid file path");
                Console.Read();
            }
        }
    }
}
