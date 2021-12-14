using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class DBManager
    {
        //Singleto is used for only one instance create for class

        private static DBManager myobject;
        private int i = 0;

        private DBManager()
        {

        }

        public static DBManager GetInstance()
        {
            if (myobject == null)
            {
                myobject = new DBManager();
            }
            return myobject;
        }

    }
}
