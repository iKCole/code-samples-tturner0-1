using System;
using System.Text;

namespace LetsGetStringy
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello";
            //helloWorld = helloWorld + " World!";
            helloWorld += " World!";

            string anH = helloWorld.Substring(0, 1);
            int position = helloWorld.IndexOf('W');
            string aW = helloWorld.Substring(position, 1);
            
            helloWorld = helloWorld.Remove(0, 1);
            helloWorld = helloWorld.Insert(0, aW);
            helloWorld = helloWorld.Remove(position, 1);
            helloWorld = helloWorld.Insert(position, anH);
            Console.WriteLine(helloWorld);

            // Split -- to split the phrases by a specific character or more.
            //char delimiter = ' ';
            //string delimiter = " ";
            char[] delimiters = {' ', '!'};
            //string[] splitArray = helloWorld.Split(' ');
            //string[] splitArray = helloWorld.Split(" ");
            // string[] splitArray = helloWorld.Split(delimiter);
            // string[] splitArray = helloWorld.Split(delimiters);

            // for(int index = 0; index < splitArray.Length; index++)
            // {
            //     Console.WriteLine(splitArray[index]);
            // }

            // for(int index = 0; index < splitArray.Length; index++)
            // {
            //     string word = splitArray[index];
            //     for(int secIndex = 0; secIndex < word.Length; secIndex++)
            //     {
            //         Console.WriteLine(word[secIndex]);
            //     }
                
            // }


            // ToCharArray -- to covert string to an char array
            //char[] letters = helloWorld.ToCharArray();

            // char[] letters = helloWorld.ToCharArray(1, 6);
            // for(int index = 0; index < letters.Length; index++)
            // {
            //     // if(index % 3 == 0 || index % 5 == 0)
            //     // {
            //         Console.WriteLine($"{letters[index]} @ {index} ");
            //         // helloWorld = helloWorld.Remove(index, 1);
            //         // Console.WriteLine(helloWorld);
            //     // }   
            // }

            // int where = helloWorld.IndexOf('l');
            // Console.WriteLine("l is found at position " + where);

            // indexof
            // int where = 0;
            
            // while((where = helloWorld.IndexOf('l', where)) != -1)
            //     Console.WriteLine("l is found at position " + where++);

            // StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append(helloWorld);
            sb.AppendLine(helloWorld);
            sb.Append(helloWorld);
            sb.AppendLine(helloWorld);
            sb.Replace("l", "a", 6, 5);
            Console.WriteLine(sb);

            // StringBuilder mySB = new StringBuilder(helloWorld);
            // Console.WriteLine(mySB);

            // StringBuilder mySb = new StringBuilder(helloWorld, 14);
            // Console.WriteLine(mySb);
        }
    }
}
