using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting the vaue form the user 
            Console.WriteLine("enter the number :");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("entert another number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int add = number1 + number2;
            Console.WriteLine("the addition of two numbers are: " + add );
            Console.ReadLine();
        }
    }
}
