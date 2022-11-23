using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parallelExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            for(int i = 0; i<num; i++)
            {
                for (int j =i; j<=i; j++)
                {
                    Console.WriteLine("i=" + i + ";" + "j=" + j);
                }
               
            }
            Console.ReadLine();
        }
    }
}
