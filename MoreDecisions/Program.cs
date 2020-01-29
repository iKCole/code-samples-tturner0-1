using System;

namespace MoreDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            double salesAmount = 10000;
            double totalCommission = 24;
            double percentage = .09; // modify it to .09
            // add another variable with .03 and modify to .06 later
            double secondCommissionPercent = .06;
            double bonusCommission = 0;

            string commissionBonusBrand = "nissan";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the total sale: ");
            double totalSales = double.Parse(Console.ReadLine()); // Convert the input (string) to double in one line

            Console.Write("Enter the car that you're purchasing: ");
            string userPreferredBrand = Console.ReadLine().ToLower();

            //Console.WriteLine(userPreferredBrand + " in the Uppercase form: " + userPreferredBrand.ToUpper());
            //Console.WriteLine(userPreferredBrand + " in the Lower form: " + userPreferredBrand.ToLower());

            //if sales is greater than $10,000
            if(totalSales >= salesAmount)
            {
                totalCommission = totalSales * percentage;

                // add a nested if for the bonus $750

                if(userPreferredBrand == commissionBonusBrand)
                {
                    bonusCommission = 750;
                }
            }
            else
            // add else with .03
            {
                totalCommission = totalSales * secondCommissionPercent;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Name: " + name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Commission: $" + (totalCommission));
            Console.WriteLine("Bonus: $" + (bonusCommission));

            // add bonus
        }
    }
}
