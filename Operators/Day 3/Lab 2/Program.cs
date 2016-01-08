using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight on Earth.");
            int weight = int.Parse(Console.ReadLine());

            double moonWeight = weight * 0.17;

            Console.WriteLine("Your weight on the moon is: " + moonWeight);
        }
    }
}
