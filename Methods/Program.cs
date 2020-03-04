using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                HelloWorld();
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Hello(name);

            Console.WriteLine($"Number: {GetNumber()}");
            Console.WriteLine($"Number: {GetNumber(5)}");
           
            // HelloWorld();
            // HelloWorld();
            // HelloWorld();
            // HelloWorld();

            void HelloWorld()
            {
                Console.WriteLine("Hello World!");
            }
        }

        // Method
        // public static void HelloWorld()
        // {
        //     Console.WriteLine("Hello World!");
        // }

        public static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public static void Hello(string name, int age)
        {
            Console.WriteLine($"Hello {name}, you're {age} years old!");
        }

         public static void Hello(string name, string age)
        {
            Console.WriteLine($"Hello {name}, you're {age} years old!");
        }

        public static int GetNumber()
        {
            return 11;
        }

        public static int GetNumber(int number)
        {
            return 11 * number;
        }
    }
}
