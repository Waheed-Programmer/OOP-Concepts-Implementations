using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public abstract class shape
    {
        public abstract void draw();
    }
    class Rectangular : shape
    {
        public override void draw()
        {
            Console.WriteLine("The method is Rectangular"); 
        }
    }
    class Triangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("The method is Triangle"); 

        }
    }
    class AbstImpliment
    {
        static void Main(string[] arg)
        {
            shape s;
            s = new Rectangular();
            s.draw();

            s = new Triangle();
            s.draw();
            Console.ReadKey();


        }
    }
}
