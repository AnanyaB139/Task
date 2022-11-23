using System;

namespace ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logic
            //Please Enter first number
            //122
            //Please Enter Second Number
            //122
            //Result is : 244
            Console.WriteLine("Please Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine("Addition is :-" + result);
            Console.Read();
        }
    }
}
