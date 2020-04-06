using System;

namespace BeClassy
{
    class Program
    {
        // static string[] fNames = new string[0];
        // static string[] lNames = new string[0];
        // static string[] courses = new string[0];
        // static string[] grades = new string[0];

        static Grade[] grades = new Grade[0];
        static void Main(string[] args)
        {
            GetRecord();
            DisplayRecord(0);
        }

        public static void GetRecord()
        {
            Console.Write("Enter first name: ");
            string first = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string last = Console.ReadLine();
            Console.Write("Enter course name/num: ");
            string className = Console.ReadLine();
            Console.Write("Enter grade: ");
            string grade = Console.ReadLine();

            //int currentSize = fNames.Length;
            int currentSize = grades.Length;
            int newsize = currentSize + 1;

            // Create a new instance of Grade class
            // Grade newStudent = new Grade();
            // newStudent.fName = first;
            // newStudent.lName = last;
            // newStudent.courseCode = className;
            // newStudent.grade = grade;

            Array.Resize(ref grades, newsize);
            //grades[currentSize] = newStudent;
            grades[currentSize] = new Grade(first, last, className, grade);
         
            // Array.Resize(ref fNames, newsize);
            // Array.Resize(ref lNames, newsize);
            // Array.Resize(ref courses, newsize);
            // Array.Resize(ref grades, newsize);

            // fNames[currentSize] = first;
            // lNames[currentSize] = last;
            // courses[currentSize] = className;
            // grades[currentSize] = grade;
        } 

        public static void DisplayRecord(int index) 
        {
            Console.WriteLine($"Name: {grades[index].fName} {grades[index].lName}\nCourse: {grades[index].courseCode}\nGrade: {grades[index].grade}");
        }
    }
}
