using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor1_class3
{
    class Program
    {

        static Program()
        {
            Console.WriteLine("this is static constructor ");
        }

        public  Program()
        {
            Console.WriteLine("this is non-static constructor ");
        }

        public Program(int num)
        {
            Console.WriteLine( 5 + num);
        }


        static void Main(string[] args)
        {
            Program a1 = new Program();
            Program a2 = new Program(6);
            Console.Read();
        }
    }
}
