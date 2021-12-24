using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{

    interface calc1
    {
        int add(int a, int b);
    }
    interface calc2
    {
        int sub(int c, int d);
    }
    interface calc3
    {
        int mul(int e, int f);
    }

    class caluclation: calc1,calc2,calc3
    {
        public int result1;
        public int add(int a, int b)
        {
            result1 = a + b;
            return result1;
        }
        public int result2;
        public int sub(int c, int d)
        {
            result2 = c - d;
            return result2;
        }
        public int result3;
        public int mul(int e, int f)
        {
            result3 = e * f;
            return result3;
        }
    }









    class Implementations
    {
        public static void Main()
        {
            caluclation c = new caluclation();
            c.add(5, 9);
            c.sub(9, 5);
            c.mul(6, 6);
            Console.WriteLine("Additions of \n" +c.result1);
            Console.WriteLine("Sub of \n" + c.result2);
            Console.WriteLine("Mul of \n" + c.result3);
            Console.ReadKey();

        }
    }
}
