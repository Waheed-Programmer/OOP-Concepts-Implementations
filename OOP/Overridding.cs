using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Overridding: Pollymorphisam
    {
        public override int Cal(int a, int b)
        {
            return a*b;
        }
    }
}
