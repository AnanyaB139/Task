using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 198, rem = 0, q = 0,sum=0 ;

            while (num>0)
            {
                rem = num % 10;
                Console.Write(rem);
                num = num / 10;
               
            }
            
            Console.ReadLine();
        }
    }
}
