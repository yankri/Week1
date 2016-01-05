using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the company: ");
            string companyName = Console.ReadLine();

            Console.WriteLine("Enter the street address of the company: ");
            string companyAddress = Console.ReadLine();

            Console.WriteLine("Enter the city and state of the company: ");
            string companyCityState = Console.ReadLine();

            Console.WriteLine("Enter the phone number (xxx-xxx-xxxx) of the company: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the fax number (xxx-xxx-xxxx) of the company: ");
            string faxNumber = Console.ReadLine();

            Console.WriteLine("Enter the website of the company: ");
            string website = Console.ReadLine();

            Console.WriteLine("Enter the first name of the manager: ");
            string managerFirstName = Console.ReadLine();

            Console.WriteLine("Enter the manager's last name: ");
            string managerLastName = Console.ReadLine();

            Console.WriteLine("Enter the manager's direct phone number (xxx-xxx-xxxx): ");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(companyName + " is located at ");
            Console.WriteLine(companyAddress);
            Console.WriteLine(companyCityState);
            Console.WriteLine("Phone: " + phoneNumber);
            Console.WriteLine("Fax: " + faxNumber);
            Console.WriteLine("Website: " + website);
            Console.WriteLine();
            Console.WriteLine("Manager Name: " + managerFirstName + " " + managerLastName);
            Console.WriteLine("Manager's Phone Number: " + managerPhoneNumber);

            Console.ReadKey();


        }
    }
}
