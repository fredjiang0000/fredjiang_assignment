using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Teacher
    {
        public string FirstName, LastName, Birthdate, AddressLine1, AddressLine2, City, StateOrProvince, ZipOrPostal, Country;

        public Teacher()
        {
            Teacher.TrackTeacher.teacher_num++;
        }

        public static class TrackTeacher
        {
            public static int teacher_num = 0;
        }
    }
}
