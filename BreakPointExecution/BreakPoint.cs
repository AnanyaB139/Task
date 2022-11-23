using System;
namespace BreakPointExecution
{
    class BreakPoint
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                int num = i;
                System.Threading.Thread.Sleep(300);
            }

            for (int j = 1; j <= 50; j++)
            {
                Console.Write("j=" + j + ",");
                System.Threading.Thread.Sleep(300);
            }
            Console.Read();
        }
    }
}
