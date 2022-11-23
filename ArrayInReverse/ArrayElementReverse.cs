using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInReverse
{
    class ArrayElementReverse
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 2, 5, 32, 4, 10, 13, 17, 34, 44 };

            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadLine();
        }

    }
}
