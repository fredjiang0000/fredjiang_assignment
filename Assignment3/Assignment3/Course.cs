using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Course
    {
        static string CourseName, 	Duration, teacher;
        static int Credits;

        public static void GetCourseInformation()
        {
            Console.WriteLine("Enter the Course's name: ");
            CourseName = Console.ReadLine();

            Console.WriteLine("Enter the Credits");
            Credits = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Duration");
            Duration = Console.ReadLine();

            Console.WriteLine("Enter the teacher's name");
            teacher = Console.ReadLine();
        }

        public static void PrintCourseDetails()
        {
            Console.WriteLine("Course: {0}, Credits: {1}, Duration: {2}, Teacher: {3}", CourseName, Credits, Duration, teacher);
        }
    }
}
