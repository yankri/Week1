using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it is divisible by both 7 and 5.");
            string userInput = Console.ReadLine();
            double query = Convert.ToDouble(userInput);

            if (query % 5 == 0 && query % 7 ==0)
            {
                Console.WriteLine("Your number is divisible by both 7 and 5");
            }

            else if (query % 5 == 0)
                {
                Console.WriteLine("Your number is divisible by 5");
            }

            else if (query % 7 == 0)
            {
                Console.WriteLine("Your number is divisible by 7.");
            }

            else
            {
                Console.WriteLine("Your number is not divisible by 5 or 7");
            }

        }
    }
}
