using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character ");
            char ch = Convert.ToChar(Console.ReadLine());
            //char ch = 'b';

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch + " its a vowel");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("its a consonants");
                Console.ReadLine();
            }
        }
    }
}
