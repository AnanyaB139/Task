using System;

namespace ExceptionHandling
{
    class exceptionhandleing
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 2, 5, 32, 4, 10, 13, 17, 34, 44 };

            try
            {
                Console.WriteLine("enter the index of an array  ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value of the index  "+ number + "=" +  num[number]);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("invalid array size {0} ", e.InnerException);
                Console.ReadLine();
            }
        }
    }
}
