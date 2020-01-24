using System;

namespace CastingInput
{

    /**
     * Author: Prof. Tiandre Turner         NMAD.180
     * Date: 01/24/2020 or January 24, 2020
     * Description: Show how does casting works, 
     *              difference between Write and WriteLine as well as double and decimal,
     *              how does getting the input works
     *
     * Caveats: None
     */
    class Program
    {
        static void Main(string[] args)
        {
            // int totalMinutes = 87;
            // int hours = (int) (totalMinutes / 60 );
            // int minutes = totalMinutes % 60;
            // Console.WriteLine(totalMinutes + " is equal to " + hours 	+ " and " + minutes + " minutes");

            // Console.Write("Enter a number: ");
            // string data = Console.ReadLine();
            // Console.WriteLine(data);
            // Console.WriteLine("Enter a number: ");
            // Console.ReadLine();

            // string data = "123";
	        // int number = int.Parse(data);  // convert from string to int

            int test1Score;
            int test2Score;
            string input;
            double average; 
            Console.Write("Enter the first score: ");
            input = Console.ReadLine();
            test1Score = int.Parse(input);
            Console.Write("Enter the second score: "); 
            input = Console.ReadLine();
            test2Score = int.Parse(input);
            average = (test1Score + test2Score) / 1.2345; // without M, program will think it is double
            decimal avg = (test1Score + test2Score) / 1.2345M; // add M only for decimal
            Console.WriteLine("The average is " + average);
            Console.WriteLine("The average is " + avg);

        }
    }
}
