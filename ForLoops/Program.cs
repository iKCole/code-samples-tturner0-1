using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = {
                "Asido",
                "Ashley",
                "Isaac",
                "Juliet",
                "Hysuon",
                "William",
                "Tiandre"
            };
            //string[] people = new string[7];
            
           string[] reversePeople = {
                "Asido",
                "Ashley",
                "Isaac",
                "Juliet",
                "Hysuon",
                "William",
                "Tiandre"
            };
           
           Array.Reverse(reversePeople);
            for(int index = 0; index < people.Length; index++)
            {
                //Console.Write($"Enter Person {index+1} in the class: ");
                //people[index] = Console.ReadLine();
                
                Console.WriteLine(people[index] + " " + reversePeople[index]);

                // if(people.Length - 1 == index)
                // {
                //     Console.WriteLine(people[index] + " " + people[0]);
                // }
                // else{
                //      Console.WriteLine(people[index] + " " + people[index+1]);
                // }
            }

            for(int index = 0; index < people.Length; index++)
            {
                System.Console.WriteLine($"{index+1}: {people[index]}");
            }

            // shot clock
            // int shotClock = 24;
            // for( ; shotClock >= 0; shotClock--)
            // {
            //     //Console.Clear();
            //     Console.ForegroundColor= ConsoleColor.Red;
            //     Console.Write(shotClock);
            //     System.Threading.Thread.Sleep(shotClock <= 10 ? 100 : 1000);
            // }
            // Console.ResetColor();
        }
    }
}
