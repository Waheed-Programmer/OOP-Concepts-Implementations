using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public abstract class DepartSlary
    {
        public int salry = 0, totalhour = 0, perhour = 100, fixtime = 8;
        public string name;

        public abstract void Display();
        public void SalaryCounter( int bonus, int overtime)
        {
            Console.WriteLine("=============Salary Department===============>");


            salry = perhour * fixtime;
            overtime = fixtime + overtime;
            if (overtime > fixtime)
            {
                totalhour = overtime - fixtime;
                salry = salry + (totalhour * perhour);

            }
            salry = salry + bonus;
            Console.WriteLine("bonus: {0} Overtime :{1}", bonus, overtime);

        }
    }
    class Worker : DepartSlary
    {
        public override void Display()
        {
            Console.WriteLine("============================>");
            Console.WriteLine("Name:{0} FixTime:{1} Perhour:{2}" , name, fixtime, perhour);
            Console.WriteLine("============================>");
            Console.WriteLine("Total salary of {0}:{1}",name,salry);


        }

    }
    class AbstructionClass
    {
        static void Main (string [] arg)
        {
            Worker w = new Worker();
            w.name = "Waheed Arshad";
            w.SalaryCounter(12, 20);
            w.Display();

            Worker m = new Worker();
            m.name = "Waheed Arshad";
            m.perhour = 212;
            m.SalaryCounter(12, 20);
            m.Display();
            Console.ReadKey();

        }
    }
}
