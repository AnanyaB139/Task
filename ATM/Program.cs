using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000;
            

            int pin = 123456;
            Console.WriteLine("please enter the pin");
           int pin1 = Convert.ToInt32( Console.ReadLine());
            if (pin == pin1)
            {
                Console.WriteLine("welcome to ATM");
                Console.WriteLine("A. check balance ");
                Console.WriteLine("B. withdraw cash ");
                Console.WriteLine("c. change the pin ");
                Console.WriteLine("D. exit ");
            }
            else
            {
                Console.WriteLine("invalid pin number");
            }
            Console.ReadLine();
            Console.WriteLine("please enter your option in alphabets");
            var options = Console.ReadLine();
            switch (options)
            {
                case "A":
                    Console.WriteLine("your balance is 10.000");
                    break;

                case "B":
                    Console.WriteLine("please enter the amount");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    if (amount > balance)
                    {
                        Console.WriteLine("your remaining balance is 10.000");
                    }
                    else
                    {
                        Console.WriteLine("successfully withdrawed " + amount);
                        Console.WriteLine("your balance is " + (balance - amount));
                    }

                    // code block
                    break;
                case "C":
                    Console.WriteLine("please enter new pin");
                    int newpin = Convert.ToInt32(Console.ReadLine());
                    var regex = @"^[0-9]{6}$";
                    Match match = Regex.Match(newpin.ToString(), regex, RegexOptions.IgnoreCase);



                    if (match.Success)
                    {
                        Console.WriteLine("your new pin has generated");
                        Console.WriteLine("your new ATM pin is : " + match);
                    }
                    else if (pin == newpin)
                    {
                        Console.WriteLine("old pin and new pin cannot be same");
                    }
                    else {
                        Console.WriteLine("your pin should be 6 digit");
                    }
                   
                    
                  
                    break;
                case "D":
                   Environment.Exit(0);

                    break;


                default:
                    // code block
                    break;
            }
            Console.ReadLine();



        }
    }
}
