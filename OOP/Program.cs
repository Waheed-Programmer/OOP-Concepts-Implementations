using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP.Encapsulations.Encapsulation;

namespace OOP
{
    class student
    {
        public void print3largest(int[] arr, int arr_size)

        {
            int i, first, second, third ,four;
            

            // There should be atleast four elements
            if (arr_size < 4)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            first = second = third = four = 00;

            for (i = 0; i < arr_size; i++)
            {
                // If current element is
                // greater than first
                if (arr[i] > first)
                {
                    four = third;
                    third = second;
                    second = first;
                    first = arr[i];
                }

                // If arr[i] is in between first
                // and second then update second
                else if (arr[i] > second)
                {

                    four = third;
                    third = second;
                    second = arr[i];
                }

                else if (arr[i] > third)
                {
                    four = third;
                    third = arr[i];
                }
                else if (arr[i] > four)
                    
                four = arr[i];
            }

            int sum = first + second + third + four;
            
            Console.WriteLine("Three largest elements are " + first + " " + second + " " + third+" " +four);
            Console.WriteLine(sum);
            Console.ReadLine();

        }
       
       
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 12, 13, 1, 10, 34, 1 };
        //    int n = arr.Length;
        //    student s = new student();
        //    s.print3largest(arr, n);
        //    AccessModifier ac = new AccessModifier();
        //    Console.WriteLine(ac.y);
        //    ac.y = "Programmer";
        //    Console.WriteLine(ac.y);
        //    AccessModifier.s = "Asp.Net";
        //    Console.WriteLine(AccessModifier.s);


        //    InheritClass i = new InheritClass();
        //    i.b = "Welcome";
        //    i.a = "C# Devloper";
        //    Console.WriteLine(i.a);
        //    Console.WriteLine(i.b);
        //    Console.WriteLine(i.y);


        //    Pollymorphisam p = new Pollymorphisam();
        //    Console.WriteLine(p.Sname("Waheed Arshad Here", "Muhammad Arshad", "Lahore Punjab"));

        //    Console.WriteLine(p.Cal(10, 10));

        //    Overridding over = new Overridding();
        //    Console.WriteLine(over.Cal(10, 10));

        //    Banksystem bs = new Banksystem();
        //    bs.Balance();
        //    bs.WithDraw();
        //    bs.Deposit();
        //    Console.Read();




        //}

       
    }
}
