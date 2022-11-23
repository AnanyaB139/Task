using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    class multiLevel : A
    {
        static void Main(string[] args)
        {
            multiLevel a1 = new multiLevel();
            a1.m1();
            a1.m2();
        }
    }

    class A:B
    {
        public void m1()
        {
            Console.WriteLine("this is class A");
            Console.ReadLine();
        }
    }

    class B
    {
        public void m2()
        {
            Console.WriteLine("this is class B ");
            Console.ReadLine();
        }
    }
}
