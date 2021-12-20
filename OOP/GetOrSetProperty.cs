using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Student
    {
        private int _Id;
        private string _name;

        public int StdId
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Negative value and 0 not allowed");
                }
                else
                {
                    this._Id = value;
                }
            }
        }
        public int StdId
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Negative value and 0 not allowed");
                }
                else
                {
                    this._Id = value;
                }
            }
        }
    }
    class GetOrSetProperty
    {
        public static void Main(string[] arg)
        {
            Student s = new Student();
            s.StdId = 1001;
            Console.WriteLine(s.StdId);
            Console.ReadKey();
        }
    }
}
