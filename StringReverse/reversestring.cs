using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class reversestring
    {
        static void Main(string[] args)
        {
            string name = "namjoon";
            string sum = "";
            char[] ch = name.ToCharArray();
            for (int i = ch.Length-1; i >= 0; i--)
            {
                sum = sum + ch[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
