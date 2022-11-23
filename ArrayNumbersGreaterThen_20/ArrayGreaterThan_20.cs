using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNumbersGreaterThen_20
{
    class ArrayGreaterThan_20
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 2, 5, 32, 4, 10, 13, 17, 34, 44 };

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 20)
                {
                    Console.WriteLine(num[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
