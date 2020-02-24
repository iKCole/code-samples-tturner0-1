using System;

namespace MuchMoreArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] anArray = new int[0]; // Create new empty array

           Console.WriteLine($"The size of anArray is {anArray.Length}");

           Array.Resize(ref anArray, 5); // set the length to 5

           Console.WriteLine($"The size of anArray is {anArray.Length}");

           Array.Resize(ref anArray, 3); // set the length to 3

           Console.WriteLine($"The size of anArray is {anArray.Length}");

           Console.Write("How many items do you want to add? ");
           int numberToAdd = int.Parse(Console.ReadLine());

        //    Array.Resize(ref anArray, anArray.Length - numberToAdd);
        //    Console.WriteLine($"The size of anArray is {anArray.Length}");

            // set the length to the total of the current length and the number you want to increase
           Array.Resize(ref anArray, anArray.Length + numberToAdd); 
           Console.WriteLine($"The size of anArray is {anArray.Length}");




        }
    }
}
