using System;

namespace Statements
{

    /**
     * Author: Tiandre Turner       NMAD.180
     * Date: 01/22/2020
     * Description:  Statements and expression demo
     * Caveats: none
     */
    class Program
    {
        static void Main(string[] args)
        {
            //    int originalStudents=2;	
            //    long newStudents=3;	
            //    int totalStudents=0;	
            //    totalStudents=originalStudents+newStudents;

            string firstName = "Tiandre";
            string lastName = "Turner";

            string description = "You're so awesome!";

            Console.WriteLine("Hello "+ firstName + " " + lastName + "! \n" + description);

            int number = 77;
            Console.WriteLine("number = " + number + number);
            Console.WriteLine(number + " is a number");

            Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine(number + number + " is a number");

             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("number = " + (number + number));

            Console.ForegroundColor = ConsoleColor.Yellow;
            string challenge = "56";
             Console.WriteLine(number + number + challenge  + number);

            Console.WriteLine(number / number + challenge  + number * 2);
        }
    }
}
