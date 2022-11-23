using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadParallel
{
    class Program
    {

        Thread t1, t2;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.m3();
        }
        public  void m3()
        {
            t1 = new Thread(m1);
            t2 = new Thread(m2);
            t1.Start();
            t2.Start();
           
        }

        public  void m1()
        {
            
            for (int i = 0; i <=10; i++)
            {

                Console.Write("i=" + i);
                Thread.Sleep(2000);
            }
            Console.ReadLine();
        }

        public  void m2()
        {
            for (int j = 0; j <=10; j++)
            {
                Console.Write( "j=" + j);
                Thread.Sleep(2000);
            }
        }
             
    }
}
