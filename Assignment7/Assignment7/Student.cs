using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Student : Person
    {
        public const int test_sz = 5;
        Stack Grades = new Stack();

        public void TakeTest()
        {
        }

        //record how many student class declared
        public static class TrackStudent
        {
            public static int student_num = 0;
        }

        //number of student classes increase
        public override void Myconstruct()
        {
            Student.TrackStudent.student_num++;
        }

        //Enter and store the student's grades
        public void EnterGrades()
        {
            int i;
            int grade;

            for (i = 0; i < test_sz;i++)
            {
                //auto produce the grades
                grade = i * 20;

                //add grade to stack Grade
                Grades.Push(grade);
            }
        }

        //List the student's grades
        public void ListGrades()
        {
            Console.WriteLine("{0} {1}'s grades: ", FirstName, LastName);
            foreach (var grade in Grades)
            {
                Console.Write("{0} ", grade);
            }
            Console.WriteLine("\n");
        }
    }
}
