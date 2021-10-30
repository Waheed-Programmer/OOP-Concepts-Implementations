using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public abstract class DepartSlary
    {
        public abstract void Display();
        public void Display1()
        {

        }
    }
    class Worker : DepartSlary
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }

    }
    class AbstructionClass
    {
        static void Main(string [] arg)
        {

        }
    }
}
