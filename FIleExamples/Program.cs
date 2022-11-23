using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FIleExamples
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the file path");
            string filepath = Console.ReadLine();
            FileInfo file = new FileInfo(filepath);
            Console.WriteLine("give any number");
            int num = int.Parse(Console.ReadLine());
            string a = string.Empty;
            if (!file.Exists)
            {
                Console.WriteLine("please enter the data");
                for (int i = 0; i < num; i++)
                {
                    a += Console.ReadLine();
                    a += '\n';
                }

                
                StreamWriter sw = new StreamWriter(filepath);
                sw.WriteLine(a);
                sw.Close();
                Console.WriteLine("the data is entered successsfully");
                
            }
            else 
            {
                Console.WriteLine( "file alrady existed " );
              
            }
            Console.ReadLine();
        }
    }
}
