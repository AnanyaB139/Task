using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COnstructor_class3
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("this is a default constructor");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            

        }
    }
}
