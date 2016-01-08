using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.

            Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double circumference = 2 * radius * Math.PI;

            double area = Math.PI * radius * radius;

            Console.WriteLine("The circumference of the circle is: " + circumference);

            Console.WriteLine("The area of the circle is: " + area);



        }
    }
}
