using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    class inheritanceExamples : A
    {
        static void Main(string[] args)
        {
            inheritanceExamples a1 = new inheritanceExamples();
            a1.m1();
        }
    }

    class A
    {
        public  void m1()
        {
            Console.WriteLine("hello world");
            Console.ReadLine();
        }
    }

}
