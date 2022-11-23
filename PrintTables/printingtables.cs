using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTables
{
    class printingtables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number, answer = 0;
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                answer = i * number;
                Console.WriteLine(number +"*" + i + "=" +answer);
            }
            Console.ReadLine();
        }
    }
}
