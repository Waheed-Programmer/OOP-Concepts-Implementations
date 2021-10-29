using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphisam
{
    class PolymorphisamClass
    {
        class Display
        {
            public static void WL(string text)
            {
                Console.WriteLine(text);
            }
            public static void WL(int number)
            {
                Console.WriteLine(number);
            }
        }
        static void Main(string [] arg)
        {
            Display.WL("This is First ");
            Display.WL(4562);
            Console.ReadKey();
        }
    }
}
