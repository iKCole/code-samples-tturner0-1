using System;

namespace Variables
{
    class Program
    {
        /*
         * Multi-line comments
         * Author: Tiandre Turner NMAD.180
         * Date: January 17, 2020 or 01/17/2020
         * Description: Variable Examples
         * Caveats: I have issues
         */
        static void Main(string[] args)
        {
            // string helloWorld;
            // helloWorld = "Hello World!";

            string helloWorld = "Hello World!";
            Console.WriteLine(helloWorld);

            string number = "23";
            Console.WriteLine(number);

            int number2 = 23;
            Console.WriteLine(number + number2); // This is an example of using one line comment: This is where I have problem with

            string firstName = "Tiandre";
            string lastName = "Turner";
            Console.WriteLine(firstName + " " + lastName + "\n\nHello World, \nI am from Chicago");

        }
    }
}
