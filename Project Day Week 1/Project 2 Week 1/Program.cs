using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Please enter the first of 5 numbers: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second of 5 numbers: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third of 5 numbers: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the fourth of 5 numbers: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the fifth of 5 numbers: ");
            int e = int.Parse(Console.ReadLine());

            */
            Console.WriteLine("Enter 5 integers separated by a space.");
            string [] inputArray = (Console.ReadLine().Split(' '));

            int total = 0;

            foreach (string toParse in inputArray)
            {
                int parseResult = int.Parse(toParse);
                total += parseResult;
            }

            Console.WriteLine("Your total is: " + total);



        }
    }
}
