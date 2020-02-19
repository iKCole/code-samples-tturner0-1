using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int CLASS_SIZE = 7;
            const string ASHLEY = "Ashley";
            const string ASHLEY_FAV_POP = "Coke";
            const double ASHLEY_FAV_POP_PRICE = 2.80;
            const int MAX_CLASS_SIZE = 15;
            string[] classNameArray2 = new string[0]; // create an empty array of string
            string[] classNameArray = { ASHLEY, "Hysuon", 
                "Issac", "Asido", "Juliet", "William", "Prof. T ", "Ghost"}; // create and initialize the string array with seven names.

            string[] studentsFavDrinks = new string[MAX_CLASS_SIZE];
            studentsFavDrinks[0] = ASHLEY_FAV_POP;

            double[] pricesArray = new double[MAX_CLASS_SIZE];
            pricesArray[0] = ASHLEY_FAV_POP_PRICE;

            // Console.WriteLine(classNameArray[0] + " " + classNameArray[1] + " " + classNameArray[2] + " " + classNameArray[3] + " " + classNameArray[4] + " " +
            //                    classNameArray[5] + " " + classNameArray[6] );
            
            Console.WriteLine(classNameArray[0] + $"'s favorite pop, {studentsFavDrinks[0]} cost {pricesArray[0]:C}");

            // change the values in specific locations
            // classNameArray[0] = "Loco";
            // classNameArray[1] = "Hy";
            // classNameArray[2] = "Ike";
            // classNameArray[3] = "He is not here";
            // classNameArray[4] = "Jule";
            // classNameArray[5] = "Will";

            //  Console.WriteLine(classNameArray[0] + " " + classNameArray[1] + " " + classNameArray[2] + " " + classNameArray[3] + " " + classNameArray[4] + " " +
            //                    classNameArray[5] + " " + classNameArray[6] );


            // Console.WriteLine($"There are {classNameArray.Length} people in this room");

            // // one of the examples of how to use the length for if statements
            // if(classNameArray.Length < MAX_CLASS_SIZE)
            // {
            //     Console.WriteLine("There is enough space in the classroom");
            // }
            // else
            // {
            //     Console.WriteLine("The classroom is full");
            // }

            // if(classNameArray.Length > MAX_CLASS_SIZE)
            // {
            //     Console.WriteLine("Need to find another room");
            // }
            
        }
    }
}
