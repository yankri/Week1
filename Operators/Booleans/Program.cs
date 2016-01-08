using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            bool lightSwitch = true; //represents on
            bool lamp = true; //on

            Console.WriteLine(lightSwitch && lamp);

            Console.WriteLine(lightSwitch || lamp);

            Console.WriteLine(!lightSwitch);

            Console.WriteLine(lightSwitch ^ lamp);
            */

            bool x = (1 > 2);
            Console.WriteLine(x);

            bool y = (1 < 2);
            Console.WriteLine(y);

            bool z = (1 >= 2);
            Console.WriteLine(z);

            bool w = (1 <= 2);
            Console.WriteLine(w);

            bool t = (1 != 2);
            Console.WriteLine(t);

            string greeting = ("Hi" + 2 + "u");
            Console.WriteLine(greeting);

            int p = 1;
            p += 3;
            p = p + 3;
            Console.WriteLine(p);

        }
    }
}
