using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program : prgm1
    {
        static void Main(string[] args)
        {
            prgm1 p = new prgm1();
            p.m3();
            
            Program p1 = new Program();
            p1.m1();
            Console.Read();
        }
    }

    class prgm1
    {
        protected void m1()
        {
            Console.WriteLine("this is method m1 of protected method");
        }

        private void m2()
        {
            Console.WriteLine("this is method m2 of private method");
        }

        public void m3()
        {
            Console.WriteLine("this is method m3 of public method");
        }
    }
}
