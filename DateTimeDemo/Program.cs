using System;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Today.ToString("MM/dd/yy -- HH:mm tt"));
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMM yyyy"));
             Console.WriteLine(DateTime.Now.ToString("dddd, MMM dd, yyyy"));
             Console.WriteLine(DateTime.Now.ToString("ddd, MMMM dd, yy"));


            Console.Write("Welcome to the Zodiac game!\n\n");
            

            DateTime ariesStartDate = new DateTime(DateTime.Now.Year, 03, 21);
            DateTime ariesEndDate = new DateTime(DateTime.Now.Year, 04, 19);
            Console.WriteLine("What is your birth month?: ");
            string month = Console.ReadLine();

            Console.WriteLine("What is your birth day?: ");
            string day = Console.ReadLine();
            
            DateTime birthDate = new DateTime(DateTime.Now.Year,  int.Parse(month), int.Parse(day));

            int number;

            bool isNumber = int.TryParse(month, out number);

            Console.WriteLine("Birthday: " + birthDate);
            Console.WriteLine(ariesStartDate.ToString("MMMM dd") + " - " + ariesEndDate.ToString("MMMM dd"));
            // if the birthday is between March 21 and April 19
            if(birthDate >= ariesStartDate && birthDate <= ariesEndDate)
            {
                Console.WriteLine("You're an Aries!");
            }
            else
            {
                Console.WriteLine("You're not an Aries :(");
            }

            DateTime today = DateTime.Now;
            DateTime tenYears = DateTime.Now.AddYears(10);
            DateTime tenYearsAgo = DateTime.Now.AddYears(-10);
            //TimeSpan tenYearsAgoTS = DateTime.Now.Subtract(10);

            
            Console.WriteLine("Today - " + today);
            Console.WriteLine("Ten years - " + tenYears);
            //Console.WriteLine("Ten years ago- " + tenYearsAgoTS.ToString("m/dd/yyyy h:mm:ss tt"));
            // switch(number)
            // {
            //     case 1:
            //         Console.WriteLine("You're an Aquarius");
            //         break;
            //     case 2:
            //         Console.WriteLine("You're a Pisces");
            //         break;
            //     case 3:
            //         Console.WriteLine("You're an Aries");
            //         break;
            //     case 4:
            //         Console.WriteLine("You're a Taurus");
            //         break;
            //     case 5:
            //         Console.WriteLine("You're a Gemini");
            //         break;
            //     case 6:
            //         Console.WriteLine("You're a Cancer");
            //         break;
            //     case 7:
            //         Console.WriteLine("You're a Leo");
            //         break;
            //     case 8:
            //         Console.WriteLine("You're a Virgo");
            //         break;
            //     case 9:
            //         Console.WriteLine("You're a Libra");
            //         break;
            //     case 10:
            //         Console.WriteLine("You're a Scoripo");
            //         break;
            //     case 11:
            //         Console.WriteLine("You're a Sagittarius");
            //         break;
            //     case 12:
            //         Console.WriteLine("You're a Capricorn");
            //         break;
            // }
        }
    }
}
