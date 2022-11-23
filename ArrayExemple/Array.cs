using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExemple
{
    class Array
    {
        static void Main(string[] args)
        {
            int number1=0;
            int[] num = new int[] { 2, 5, 32, 4, 10, 13, 17, 34, 44};

            for (int i = 0; i < num.Length-1; i++)
            {
                for (int j = 0; j < num.Length-1; j++)
                {
                    if (num[j] < num[j + 1])
                    { 
                      
                    }
                }
            }
           
            Console.ReadLine();
        }
    }
}
