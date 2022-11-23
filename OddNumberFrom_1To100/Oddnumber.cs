using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberFrom_1To100
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            // printing the odd numbers from 1 to 100
            Console.WriteLine("odd numbers from 1 to 100 are :");

            for (int i = 1; i < 100; i++)
            { 
              if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
