using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            MyGetInformation();

            Student.ValidatingStudentBirthday();

            MyPrint();

            Console.ReadLine();
        }

        static void MyGetInformation()
        {
            Student.GetStudentInformation();
            Teacher.GetTeacherInformation();
            Course.GetCourseInformation();
            UProgram.GetUProgramInformation();
            Degree.GetDegreeInformation();
        }

        static void MyPrint()
        {
            Student.PrintStudentDetails();
            Teacher.PrintTeacherDetails();
            Course.PrintCourseDetails();
            UProgram.PrintUProgramDetails();
            Degree.PrintDegreeDetails();
        }
    }

    
}
