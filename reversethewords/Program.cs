using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversethewords
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance =  "hello good morning ";
            string[]  split1 = sentance.Split();
            for (int i = split1.Length-1; i >=0; i--)
            {
                Console.Write(split1[i] + "  ");
               
            }
            Console.ReadLine();
        }
    }
}
