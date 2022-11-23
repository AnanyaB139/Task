using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerticularPositionOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] num = new int[] { 2, 5, 32, 4, 10, 13, 17, 34, 44 };
            Console.WriteLine("printing array numbers from 4 to 8th position");
            for (int i = 3; i <= 7; i++)
            {
               
                    Console.WriteLine(num[i]);
                
            }
            Console.ReadLine();
        }
    }
}
