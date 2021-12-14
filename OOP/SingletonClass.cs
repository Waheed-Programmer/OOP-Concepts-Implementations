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
        public void Show()
        {
            Console.WriteLine("DBManager: Show()");
        }

        public void SetI(int val)
        {
            i = val;
        }

        public void ShowI()
        {
            Console.WriteLine("Get Integer is "+i);
        }
        static void Main(string[] args)
        {

            DBManager db;
            db = DBManager.GetInstance();
            db.Show();
            db.SetI(23);
            db.ShowI();
            Console.WriteLine();
            Console.ReadKey();

                
        }
    }
}
