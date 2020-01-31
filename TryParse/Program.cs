using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
                       int test1Score;
            int test2Score;
            string input;
            double average; 
            Console.Write("Enter the first score: ");
            input = Console.ReadLine();
            double test3Scorce =0;
            int.TryParse(input, out test1Score);
            //int.TryParse(input, out int inputNum);

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            bool fail = int.TryParse(input, out int inputNum);
            if(fail)
            {
                 Console.WriteLine("Number = " + inputNum);
                Console.WriteLine($"Number = {inputNum}");
                Console.WriteLine($"Number = {inputNum:C}");
                 Console.WriteLine($"Number = {inputNum, 15:C}");
                Console.WriteLine("Number = {inputNum}");
                 Console.WriteLine("Number = {0} {1}", inputNum, test1Score);
                  Console.WriteLine($"Number = {inputNum:N3}");
                Console.WriteLine("Number = {inputNum}");
                 Console.WriteLine("Number = {0,-15:N3} {1}", inputNum, test1Score);
                 Console.WriteLine("Number = {0,15:N3}", inputNum);
                Console.WriteLine("Number = {0:N3}", inputNum);
                 Console.WriteLine("Number = \t{0:C}", inputNum);
            }
            else
            {
                Environment.Exit(0); // Quit the program
            }

            Environment.Exit(2); // Quit the program

             Console.WriteLine("HI");


            // Console.Write("Enter the second score: "); 
            // input = Console.ReadLine();
            // test2Score = int.Parse(input);
            // average = (test1Score + test2Score) / 1.2345; // without M, program will think it is double

            // Console.WriteLine("The average is " + average);

        }
    }
}
