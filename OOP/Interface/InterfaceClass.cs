using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    interface ISale {
        void sale(string name , int price );
    
    }
    interface IPurchase
    {
        void purchase();

    }

    class Acount : ISale,IPurchase
    {
        int balance;

        public void sale(string name , int price)
        {
            Console.WriteLine("Name: {0}\n Price{1}",name,price);

            balance = balance + price;
            Console.WriteLine("Balance: {0}", balance);

            
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
            a.sale("Lays",50);
            a.sale("Pepsi", 100);
            a.purchase();
            Console.ReadKey();

        }
             
    }
}
