using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    class main
    {
        static void Main(string[] args)
        {
            Cloth c = new Cloth();
            c.ProductId = 1;
            c.ProductName = "Jean";
            c.ProductPrice = 1500;
            c.Color = "Blue";

            Furniture f = new Furniture();
            f.ProductId = 2;
            f.ProductName = "Bed";
            f.ProductPrice = 25300;
            f.ExpireDate = 2017;


        }
    }
}
