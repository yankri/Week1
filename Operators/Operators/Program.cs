using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = (2 + 3) * 5;
            Console.WriteLine(x);

            int y;
            x = y = 5 % 2 + 1;

            Console.WriteLine(y);
            Console.WriteLine(x);
            

            int x = 1;
            int y = -x * 3;

            Console.WriteLine(y);
            

            int x = 1 + 2 * 3;
            Console.WriteLine(x++);
            Console.WriteLine(x);

            int x = 1 + (2 * 3);
            double y = 3.12 + (3.3 * 2.2);

            Console.WriteLine(x);
            Console.WriteLine(y);
            */

            int x = 1;
            int y = x++; //y will be 1 because it is getting assigned x, but then x itself is getting 1 added to it

            Console.WriteLine(y);
            Console.WriteLine(x);

        }
    }
}
