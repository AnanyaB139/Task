using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class WHileLoopExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entert the number:");
            int num;
             num = Convert.ToInt32(Console.ReadLine());
           
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("its a prime number");
                    break;
                }
                else 
                {
                    Console.WriteLine("its a odd number");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
