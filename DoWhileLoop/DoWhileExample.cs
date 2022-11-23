using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class DoWhileExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number > 100);
            if (number < 100)
            {
                Console.WriteLine("number must be greater then 100");
            }
            Console.ReadLine();

        }
    }
}
