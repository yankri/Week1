using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers you wish to add: ");
            int numbersToAdd = int.Parse(Console.ReadLine());

            int total = 0;

            for (int x = 0; x < numbersToAdd; x++)
            {
                Console.WriteLine("Enter the integer you want to add: ");
                int toParse = int.Parse(Console.ReadLine());
                total += toParse; //total will be the sum of the results of the console.readline after parsing
            }

            Console.WriteLine("The sum of the numbers is: " + total);

           




        }
    }
}
