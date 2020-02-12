using System;

namespace QAReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // ternary
            Console.Write("Do you like basketball (y/n): ");
            string sport = Console.ReadLine().ToLower()[0] == 'y' ? 
                "like basketball" : "dont like basketball";

            // bool sportDesc = Console.ReadLine().ToLower()[0] == 'y' ? 
            //     true : false;

            //     bool sportDesc2 = Console.ReadLine().ToLower()[0] == 'y';

            // TryParse
            Console.WriteLine("Name of Player: ");
            string name = Console.ReadLine();

            Console.WriteLine("How many points does " + name + " have? ");

            //int.TryParse(Console.ReadLine(), out int points);

            if ((!int.TryParse(Console.ReadLine(), out int points)))
            {
                Console.WriteLine($"if - Points: {points}");
            }
            // else
            // {
            //     Console.WriteLine($"Else - Points: {points}");
            // }

             Console.WriteLine("How many rebounds does " + name + " have? ");

            if ((!int.TryParse(Console.ReadLine(), out int rebounds)))
            {
                Console.WriteLine($"if - Points: {points}");
            }
            if(points >= 25)
            {
                if(rebounds >= 10)
                {
                    Console.WriteLine(name + " is the MVP of the game");
                }
                else
                {
                   Console.WriteLine(name + " is not the MVP of the game");  
                }
            }

            if(points >= 25 && rebounds >= 10)
            {
                    Console.WriteLine(name + " is the MVP of the game");
               
            }
            else
            {
                Console.WriteLine(name + " is not the MVP of the game");  
            }

            string mvp = points >= 25 && rebounds >= 10 ?  name + " is the MVP of the game" : name + " is not the MVP of the game";
            Console.WriteLine(mvp);

            if(rebounds >= 10)
            {
                Console.WriteLine(name + " is the MVP of the game");
            }

            // nested if

        }
    }
}
