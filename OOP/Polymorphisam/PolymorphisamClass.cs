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
            public static void WL(double f)
            {
                Console.WriteLine(Convert.ToDouble(f));
            }
        }
        static void Main(string [] arg)
        {
            WL("This is First ");
            WL(4562);
            WL(4563.326);

            
            Console.ReadKey();
        }
        static void WL(string text)
        {
            Console.WriteLine(text);
        }
        static void WL(int number)
        {
            Console.WriteLine(number);
        }
        static void WL(double f)
        {
            Console.WriteLine(Convert.ToDouble(f));
        }
    }
}
