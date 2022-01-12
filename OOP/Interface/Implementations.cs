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

    interface calc4
    {
        int divid(int g, int h);
    }

    class caluclation: calc1,calc2,calc3,calc4
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

        public int result4;
        public int divid(int g, int h)
        {
            result4 = g / h;
            return result4;
        }
    }









    class Implementations
    {
        public static void Main(string[] args)
        {
            caluclation c = new caluclation();
            c.add(5, 9);
            c.sub(9, 5);
            c.mul(6, 6);
            c.divid(100, 50);
            Console.WriteLine("Additions of \n" +c.result1);
            Console.WriteLine("Sub of \n" + c.result2);
            Console.WriteLine("Mul of \n" + c.result3);
            Console.WriteLine("Divid of \n" + c.result4);

            Console.ReadKey();

        }
    }
}
