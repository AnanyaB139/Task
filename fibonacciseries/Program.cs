using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciseries
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2= 1, num3 ;
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the fibonacciseries of the number " + num + " is ");
            for (int i = 0; i < num; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }
            Console.ReadLine();
        }
    }
}
