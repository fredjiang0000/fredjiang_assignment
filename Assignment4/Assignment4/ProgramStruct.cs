using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    partial class Program
    {
        struct Student
        {
            public string FirstName;
            public string LastName;
            public string Birthdate;
            public string AddressLine1;
            public string AddressLine2;
            public string City;
            public string StateOrProvince;
            public string ZipOrPostal;
            public string Country;
        }

        struct Teacher
        {
            public string FirstName;
            public string LastName;
            public string Birthdate;
            public string AddressLine1;
            public string AddressLine2;
            public string City;
            public string StateOrProvince;
            public string ZipOrPostal;
            public string Country;
        }

        struct Course
        {
            public string CourseName;
            public string Duration;
            public string teacher;
            public int Credits;
        }

        struct UProgram
        {
            public string ProgramName;
            public string DepartmentHead;
            public int Degrees;
        }
    }
}
