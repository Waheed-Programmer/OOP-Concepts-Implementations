using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public delegate void Di(string v, string u);

    class Delegate
    {
        public static void seti(string q, string w)
        {
            Console.WriteLine("{0}{1}", q, w);
        }
        static void Main(string[] it)
        {
            Di d = new Di(Delegate.seti);
            d.Invoke("Waheed", "Arshad");
            Console.ReadKey();
        }
    }
}
