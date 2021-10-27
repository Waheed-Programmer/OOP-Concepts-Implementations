using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Pollymorphisam
    {
        //Method over loading

        public string Sname(string n)
        {
            return n;
        }
        public string Sname(string n , string fn)
        {
            return n + "S/O" + fn;

        }

        public string Sname(string n, string fn, string add)
        {
            return n + "" + fn + "Adress is " + add;
        }


        // Method overidding

        public virtual int Cal(int a, int b)
        {
            return a + b;
        }
    }
}
