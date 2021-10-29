using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulations
{
    class Encapsulation
    {
       public class Banksystem
        {
            public double balance;
            public double deposit;
            public double withdraw;

            public double Balance()
            {
                Console.WriteLine("Enter Account Balance");
                balance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Account balance is {0}", balance);
                return balance;
            }
            public double Deposit()
            {
                Console.WriteLine("Enter Deposit Balance");
                deposit = Convert.ToDouble(Console.ReadLine());
                balance = balance + deposit;
                Console.WriteLine("Total balance is {0}", balance);
                return balance;
            }
            public double WithDraw()
            {
                Console.WriteLine("Enter Widraw Balance");
                withdraw = Convert.ToDouble(Console.ReadLine());
                balance = balance - withdraw;
                Console.WriteLine("Total balance is {0}", balance);
                return balance;
            }
        }
       
    }
}
