using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class student
    {
        public string Name;
        public int age;
        public int marks;


        public void details()
        {
            Console.WriteLine("Name={0}","Age={1}","Marks={2}",Name,age,marks); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
