using System;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int newNumber);

            if(isValid)
            {

            }
            else
            {
                
            }
            


            Console.Write("Welcome to the Zodiac game!\n\n");
            Console.WriteLine("What is your birth month?: ");
            string input = Console.ReadLine();

            int number;

            bool isNumber = int.TryParse(input, out number);

            if(isNumber)
            {
                switch(number)
                {
                    case 1:
                        Console.WriteLine("You're an Aquarius");
                        break;
                    case 2:
                        Console.WriteLine("You're a Pisces");
                        break;
                    case 3:
                        Console.WriteLine("You're an Aries");
                        break;
                    case 4:
                        Console.WriteLine("You're a Taurus");
                        break;
                    case 5:
                        Console.WriteLine("You're a Gemini");
                        break;
                    case 6:
                        Console.WriteLine("You're a Cancer");
                        break;
                    case 7:
                        Console.WriteLine("You're a Leo");
                        break;
                    case 8:
                        Console.WriteLine("You're a Virgo");
                        break;
                    case 9:
                        Console.WriteLine("You're a Libra");
                        break;
                    case 10:
                        Console.WriteLine("You're a Scoripo");
                        break;
                    case 11:
                        Console.WriteLine("You're a Sagittarius");
                        break;
                    case 12:
                        Console.WriteLine("You're a Capricorn");
                        break;
                }
     
            }
            else
            {
                string sign;
                string sign2 = (input == "January") ? "Aquarius" : (input == "March" ? "Aries" : "Pisces");

                if(input == "January")
                {
                    sign = "Aqua";
                }
                else if(input == "March")
                {
                    sign = "Aries";
                }
                else
                    sign = "Pisces";

                Console.WriteLine($"You're a {sign} || {sign2}");
                // switch(input)
                // {
                //     case "January":
                //         Console.WriteLine("You're an Aquarius");
                //         break;
                //     case "February":
                //         Console.WriteLine("You're a Pisces");
                //         break;
                //     case "March":
                //         Console.WriteLine("You're an Aries");
                //         break;
                //     case "April":
                //         Console.WriteLine("You're a Taurus");
                //         break;
                //     case "May":
                //         Console.WriteLine("You're a Gemini");
                //         break;
                //     case "June":
                //         Console.WriteLine("You're a Cancer");
                //         break;
                //     case "July":
                //         Console.WriteLine("You're a Leo");
                //         break;
                //     case "August":
                //         Console.WriteLine("You're a Virgo");
                //         break;
                //     case "September":
                //         Console.WriteLine("You're a Libra");
                //         break;
                //     case "October":
                //         Console.WriteLine("You're a Scoripo");
                //         break;
                //     case "November":
                //         Console.WriteLine("You're a Sagittarius");
                //         break;
                //     case "December":
                //         Console.WriteLine("You're a Capricorn");
                //         break;
                // }
            }


            


        }
    }
}
