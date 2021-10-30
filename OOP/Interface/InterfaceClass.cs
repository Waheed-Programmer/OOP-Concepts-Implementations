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
    interface IPurchase
    {
        void purchase();

    }

    class Acount : ISale,IPurchase
    {
        public void sale()
        {
            Console.WriteLine("This is Sale Interface");
            Console.WriteLine("-------------------------");
        }
        public void purchase()
        {
            Console.WriteLine("This is purchase interface ");
        }
    }



    class InterfaceClass
    {
        static void Main(string [] inter)
        {
            Acount a = new Acount();
            a.sale();
            a.purchase();
            Console.ReadKey();

        }
             
    }
}
