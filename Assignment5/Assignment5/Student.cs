using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Student
    {
        public string FirstName, LastName, Birthdate, AddressLine1, AddressLine2, City, StateOrProvince, ZipOrPostal, Country;

        public Student()
        {
            Student.TrackStudent.student_num++;
        }

        public static class TrackStudent
        {
            public static int student_num = 0;
        }
    }
}
