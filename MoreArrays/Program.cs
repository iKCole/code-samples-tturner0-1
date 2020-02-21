using System;

namespace MoreArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Used as a purpose to either sort or reverse
            string[] classNameArray = { "Ashley", "Hysuon", 
                "Issac", "Asido", "Juliet", "William", "Prof. T ", "Ghost"};

            int[] favNum = { 12, 2, 65, 3, 11, 21};
       
            Array.Sort(classNameArray); // Sort the order of the names of people in alphabet
            Array.Reverse(classNameArray); // Reverse the order in the names of people

            // Show the outcome if sort or reverse
            Console.WriteLine(favNum[0]);
            Console.WriteLine(favNum[1]);
            Console.WriteLine(favNum[2]);
            Console.WriteLine(favNum[3]);
            Console.WriteLine(favNum[4]);
            Console.WriteLine(favNum[5]);

            Array.Reverse(favNum);

            int[,] scores = new int[1,2];
            scores[0,0] = 71;
            scores[0,1] = 68;
   
            int[,] scores1 = { {71, 68},
                                {78, 71} };

            int[,] scores2 = new int[1,2] { {78, 71} };

            string[,] vehicles = 
            {
                {"Name of Cars", "Color", "Type of Gas", "Used/New"},
                {"Ford", "Silver", "Gas", "Used"},
                {"Toyota", "Black", "Diesel", "Used"},
                {"Nissan", "Blue", "Electric", "New"},
            };

            // 2D array
            string[,] vehicles2 = new string[4,4];
            vehicles2[0,0] = "Name of Cars";
            vehicles2[0,1] = "Color";
            vehicles2[0,2] = "Type of Gas";
            vehicles2[0,3] = "Used/New";
            vehicles2[1,0] = "Ford";
            vehicles2[1,1] = "Silver";
            vehicles2[1,2] = "Gas";
            vehicles2[1,3] = "Used";
            vehicles2[2,0] = "Toyota";
            vehicles2[2,1] = "Black";
            vehicles2[2,2] =  "Diesel";
            vehicles2[2,3] = "Used";
            vehicles2[3,0] = "Nissan";
            vehicles2[3,1] = "Blue";
            vehicles2[3,2] = "Electric";
            vehicles2[3,3] = "New";

        }
    }
}
