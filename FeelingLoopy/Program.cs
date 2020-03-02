using System;

namespace FeelingLoopy
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
            
            for(int index = 0; index < people.Length; index++)
            {

               // Console.WriteLine(people[index] + " " + people[index]);
                Console.WriteLine(people[index]);
            }

            int index2 = 0;
            while(index2 < people.Length)
            {
                Console.WriteLine(people[index2]);
                index2++;
            }

            // int index2 = 0;
            // while(index2 < people.Length)
            // {
            //     Console.WriteLine(people[index2]);
            //     index2++;
            // }

             //int j = 0;
            //  Console.WriteLine("Do you want to continue? (y/n): ");
            // while(Console.ReadLine() == "y")
            // {
            //     Console.WriteLine("do something");
            //    // Console.WriteLine("Do you want to continue? (y/n): ");
            // }

            // Console.WriteLine();

            //int i = 0;
            // do
            // {
            //     Console.WriteLine("do something");
            //     Console.WriteLine("Do you want to continue? (y/n): ");
            // }while(Console.ReadLine() == "y");

            // int index3 = 0;
            // while(true)
            // {
            //     Console.WriteLine(index3);
            //     if(index3 == 3)
            //     {
            //         Console.WriteLine("Stop at 3!");
            //         continue;
            //     }

            //     index3++;
            // }

            // int index3 = 0;
            // while(true)
            // {
            //     if(index3 == 3)
            //     {
            //         Console.WriteLine("Stop at 3!");
            //         break;
            //     }
                
            //     index3++;
            // }
            

            // Console.Write("How many more people do you want to add? ");
            // int moreToAdd = int.Parse(Console.ReadLine());

            // Array.Resize(ref people, moreToAdd + people.Length);
            // //index++;
            // for(; index < people.Length; index++)
            // {
            //     //Console.WriteLine(people[index] == "" ? "No Name" : people[index]);
            //     Console.Write($"Enter Array #{index}: ");
            //     people[index] = Console.ReadLine();
            // }


        }
    }
}
