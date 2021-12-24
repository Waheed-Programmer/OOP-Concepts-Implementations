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
        int result1;
        public int add(int a, int b)
        {
            result1 = a + b;
            return result1;
        }
        int result2;
        public int sub(int c, int d)
        {
            result2 = c - d;
            return result2;
        }
        int result3;
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

        }
    }
}
