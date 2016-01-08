using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to evaluate: ");
            //int query = int.Parse(Console.ReadLine());
            string userInput = Console.ReadLine();
            int query = int.Parse(userInput);
            /*
            if (query == 0)
            {
                Console.WriteLine("You entered zero!");
            }

            else
            {
                if (query % 2 == 0)
                {
                    Console.WriteLine("Your number is even.");
                }
                else
                {
                    Console.WriteLine("Your number is odd.");
                }
             }
              */
            int p = query % 2
            string w = (p == 0) ? "even" : "odd";

            Console.WriteLine(w);


        }
    }
}
