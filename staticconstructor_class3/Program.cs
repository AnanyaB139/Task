using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor_class3
{
    static class Program
    {
        public static void m1()
        {
            Console.WriteLine("this is static mothod m1");
           
        }

        public static void m2()
        {
            Console.WriteLine("this is static mothod m2");
            
        }


        static void Main(string[] args)
        {
            m1();
            m2();
            Console.Read();
        }
    }
}
