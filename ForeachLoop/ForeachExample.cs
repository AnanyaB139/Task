using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    class ForeachExample
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (int numbers in arr)
            {
                Console.WriteLine(numbers);
            }
            Console.ReadLine();
        }
    }
}
