using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            int var1 = 24;
            int var2 = 99;
            bool decision = !(!(var1 > 30) || !(var2 < 12 || var1 <= 25));
            Console.WriteLine(decision);
            // Console.Write("Enter an letter: ");
            // string letter = Console.ReadLine().ToUpper();
            // switch(letter)
            // {
            //     case "A":
            //         Console.WriteLine("You selected an A");
            //         break;
            //     case "B":
            //         Console.WriteLine("You selected a B");
            //         break;
            //     default:
            //         Console.WriteLine("Letter is not found");
            //         break;
            // }

            // Console.Write("Enter an number: ");
            // int myInt = int.Parse(Console.ReadLine());

            // switch(myInt)
            // {
            //     case 1: 
            //     case 2: Console.WriteLine("You selected a A or B");
            //         break;
            //     default:
            //         Console.WriteLine("Letter is not found");
            //         break;
            // }
            //  Console.Write("Enter your grade: ");
            // double grade = double.Parse(Console.ReadLine());
            
            // if (grade >= 90) 
            // {
            //     Console.WriteLine("You got an A");
            // } 
            // else if (grade >= 80)
            // { 
            //         Console.WriteLine("You got a B");
               
            // }
            //  else if (grade >= 70)
            // {
            //     Console.WriteLine("You got a C");
                
            // }
            // else if(grade >= 60)
            // {
            //      Console.WriteLine("You got a D");
            // }
            // else
            // {
            //     Console.WriteLine("You got an F");
            // }



        }
    }
}
