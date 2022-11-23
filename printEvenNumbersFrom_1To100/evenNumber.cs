using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printEvenNumbersFrom_1To100
{
    class EvenNumbers
    {
        static void Main(string[] args)
        {
            //printing even numbers from 1 to 100
            Console.WriteLine("even numbers from 1 to 100 are:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
