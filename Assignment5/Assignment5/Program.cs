using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(), s2 = new Student(), s3 = new Student();
            Teacher t1 = new Teacher();
            Course ProgrammingWithCSharp = new Course("Programming with C#");

            ProgrammingWithCSharp.AddStudent(s1);
            ProgrammingWithCSharp.AddStudent(s2);
            ProgrammingWithCSharp.AddStudent(s3);

            ProgrammingWithCSharp.AddTeacher(t1);

            Degree Bachelor = new Degree("Bachelor");
            Bachelor.AddCourse(ProgrammingWithCSharp);

            UProgram InformationTechnology = new UProgram("Information Technology");
            InformationTechnology.AddDegree(Bachelor);

            Console.WriteLine("The " + InformationTechnology.name + " program contains the " + InformationTechnology.degree.name + " of Sciense degree\n");
            Console.WriteLine("The " + InformationTechnology.degree.name + " of Sciense degree contains the course " + InformationTechnology.degree.course.name + "\n");
            Console.WriteLine("The " + InformationTechnology.degree.course.name + " course contains " + Student.TrackStudent.student_num + " student<s>");
            Console.ReadLine();
        }
    }
}
