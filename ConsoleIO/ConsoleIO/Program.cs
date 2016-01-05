using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 20;

            Console.WriteLine("Hello World");

            Console.WriteLine(x);

            Console.WriteLine(x % 35 == 0);

            Console.WriteLine((x % 5 == 0 && x % 7 == 0)? "Yep" : "No " + x);

            Console.ReadKey();
            

            Console.WriteLine("We Can Code It");

            Console.Write("coding");
            Console.Write(" bootcamp");
            

            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("The user's full name is: " + firstName + " " + lastName);

            

            Console.WriteLine("Age: ");
            string age = Console.ReadLine();
            int age2 = Convert.ToInt32(age);

            Console.WriteLine("Age: ");
            int age3 = int.Parse(Console.ReadLine());
           */

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your gender: ");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter your address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter your city and state: ");
            string cityState = Console.ReadLine();

            Console.WriteLine("You are a " + age + " year old " + gender + " named " + name + ". You live at " + address + " in " + cityState + ".");


        }
    }
}
