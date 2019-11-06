using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "xyz", "abc", "qwerty", "hello" };
            int[] grades = { 77, 50, 78, 95 };


            Console.WriteLine("Enter Students name to search");
            string studentsname;
            studentsname = Console.ReadLine();

            bool contains = false;
            int studentsgrade = 0;


            for (int i = 0; i < students.Length; i++)
            {
                if (studentsname == students[i])
                {
                    contains = true;
                    studentsgrade = grades[i];
                    break;
                }
            }
            if (contains == true)
            {
                Console.WriteLine("The student is in the class");
                Console.WriteLine("The students grade is {0}", studentsgrade);
            }
            else
            {
                Console.WriteLine("the student is not in the class");
            }
        }
    }
}
