using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileExample_class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the filepath");
            string filepath = Console.ReadLine();
            FileInfo file = new FileInfo(filepath);

            if (file.Exists)
            {
                StreamWriter sw = new StreamWriter(filepath);
                Console.WriteLine("enter the data");
               
                
                
               
                sw.Write(Console.ReadLine());
                sw.Close();

            }
            else
            {
                Console.WriteLine("invalid filepath");
            }
            Console.ReadLine();

        }
    }
}
