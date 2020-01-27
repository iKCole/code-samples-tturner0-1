using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            double salesAmount = 10000;
            double totalCommission = 24;
            double percentage = .07;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the total sale: ");
            string data = Console.ReadLine();
            double totalSales = double.Parse(data);

            // double totalSales = double.Parse(Console.ReadLine()); // Convert the input (string) to double in one line

            //if sales is greater than $10,000

            if(totalSales >= salesAmount)

            {
                totalCommission = totalSales * percentage;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Name: " + name);
               Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Commission: $" + (totalCommission));
        }
    }
}
