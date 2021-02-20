using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
        }

        public static void MyMethod()
        {
            Console.WriteLine();
            Console.WriteLine("Module 1 Assignment");

            int myVariable1 = 1;
            int myVariable2 = 3;
            int myVariable3 = 7;


            Console.WriteLine(myVariable1);
            Console.WriteLine(myVariable2);

            string myVariablestring = ("This is my second attempt");
            string myVariablestring2 = ("I am hoping it is correct this time");
            Console.WriteLine(myVariable1 * myVariable2);

            Console.WriteLine(myVariablestring);


            Console.WriteLine(myVariable1 / myVariable2);
            Console.WriteLine(myVariablestring2);

            Console.WriteLine(myVariable1 + myVariable3);
        }
    }
}