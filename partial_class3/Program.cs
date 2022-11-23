using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class3
{
    public partial class colors
    {
        public string DarkColor { get; set; }
        public int  ColorNumber { get; set; }
    }

    public partial class colors
    {
        public colors(string color, int colorNum)
        {
            this.DarkColor = color;
            this.ColorNumber = colorNum;

            public void DisplayEmpInfo()
            {
                Console.WriteLine(this.DarkColor + " " + this.ColorNumber);
            }


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var emp = new colors();
            Console.WriteLine(emp.EmpId); // prints genereted id

            Console.ReadLine();
        }
    }
}
