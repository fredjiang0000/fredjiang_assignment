using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,grade;

            Student s1 = new Student(), s2 = new Student(), s3 = new Student();
            Teacher t1 = new Teacher(), t2 = new Teacher();
            Course ProgrammingWithCSharp = new Course("Programming with C#");

            //set all students' name
            s1.FirstName = "S1_F";
            s2.FirstName = "S2_F";
            s3.FirstName = "S3_F";

            s1.LastName = "S1_L";
            s2.LastName = "S2_L";
            s3.LastName = "S3_L";

            //set all students' grades
            s1.EnterGrades();
            s2.EnterGrades();
            s3.EnterGrades();

            //add all student to course class
            ProgrammingWithCSharp.AddStudent(s1);
            ProgrammingWithCSharp.AddStudent(s2);
            ProgrammingWithCSharp.AddStudent(s3);

            //add two teacher to course class
            ProgrammingWithCSharp.AddTeacher(t1);
            ProgrammingWithCSharp.AddTeacher(t2);

            //add course to degree
            Degree Bachelor = new Degree("Bachelor");
            Bachelor.AddCourse(ProgrammingWithCSharp);

            //add degree to uprogram
            UProgram InformationTechnology = new UProgram("Information Technology");
            InformationTechnology.AddDegree(Bachelor);

            //list students' name
            ProgrammingWithCSharp.ListStudents();

            //list all students' grades
            s1.ListGrades();
            s2.ListGrades();
            s3.ListGrades();

            Console.ReadLine();
        }
    }
}
