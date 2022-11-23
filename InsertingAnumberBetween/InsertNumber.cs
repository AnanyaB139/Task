using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertingAnumberBetween
{
    class InsertNumber
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 2, 5, 32, 4, 10, 13, 17, 34, 44 };
            num[5] = 17;
            
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);

            }
            Console.ReadLine();
        }
    }
}
