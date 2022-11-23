using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Switch1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the grade ");
            string grades  = Console.ReadLine();

            switch (grades)
            {
                case "A":
                    Console.WriteLine("very good");
                    
                    break;
                case "B":
                    Console.WriteLine(" good");
                    break;
                case "C":
                    Console.WriteLine("try next time ");
                    break;
                case "D":
                    Console.WriteLine("bad");
                    break;
                default: Console.WriteLine("invalid grade");
                    
                    break;
            }
            Console.ReadLine();
        }
    }
}
