using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    interface ISale {
        void sale();
    
    }

    class Acount : ISale
    {
        public void sale()
        {
            Console.WriteLine("This is interface method in derived class");
        }

    }



    class InterfaceClass
    {
        static void Main(string [] inter)
        {
            Acount a = new Acount();
            a.sale();
            Console.ReadKey();

        }
             
    }
}
