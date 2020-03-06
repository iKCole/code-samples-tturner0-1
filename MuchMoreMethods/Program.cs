using System;

namespace MuchMoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            bool current = TryParse("abc", out int digit);

            Console.WriteLine($"Can you parse abc?: {current}, digit: {digit}");

            current = TryParse("123", out digit);

            Console.WriteLine($"Can you parse 123?: {current}, digit: {digit}");

            Console.WriteLine(Multiply());
            Console.WriteLine(Multiply(2));
            Console.WriteLine(Multiply(5,6));

            Console.WriteLine(Multiply(number2: 4.6, number1: 5.5));
             Console.WriteLine(Multiply(5.5, 4.6));

            int sum = SumAndAverage(5,6, out double avg);
            Console.WriteLine($"Sum: {sum}\nAverage: {avg}");

        }

        // Concept of how TryParse works
        private static bool TryParse(string data, out int digit)
        {
            // Try-Catch is a way to handle and catch the exception
            try
            {
                digit = int.Parse(data);
                return true;
            }
            catch(FormatException fe)
            {
                digit = 0;
                return false;
            }
        }

        // Method with two optional parameters
        private static int Multiply(int number1 = 4, int number2 = 4)
        {
            return number1 * number2;
        }

        private static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        private static int SumAndAverage(int number1, int number2, out double avg)
        {
            avg = (number1 + number2) / 2.0;
            return number1 + number2;
        }
    }
}
