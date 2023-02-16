using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name = 1");
            Console.WriteLine("Password = 1");
            Console.ReadLine();
            Console.Clear();
        Start:
            Console.WriteLine("Name:");  
            String name = Console.ReadLine();

            if (name == "1") {
                Console.WriteLine("Password:");
                String password = Console.ReadLine();

                if (password == "1")
                {
                    Console.WriteLine("Congratulations, you made it.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Password Incorrect, Try again");
                    goto Start;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Name Incorrect, Try again");
                goto Start;
            }
        }
    }
}
