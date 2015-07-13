using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Teacher
    {
        static string FirstName, LastName, Birthdate, AddressLine1, AddressLine2, City, StateOrProvince, ZipOrPostal, Country;

        public static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            FirstName = Console.ReadLine();

            Console.WriteLine("Enter the teacher's last name");
            LastName = Console.ReadLine();

            Console.WriteLine("Enter the teacher's birthday");
            Birthdate = Console.ReadLine();
        }

        public static void PrintTeacherDetails()
        {
            Console.WriteLine("{0} {1} was born on: {2}", FirstName, LastName, Birthdate);
        }
    }
}
