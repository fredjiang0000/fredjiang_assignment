using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        static string FirstName, LastName, Birthdate, AddressLine1, AddressLine2, City, StateOrProvince, ZipOrPostal, Country;

        public static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            FirstName = Console.ReadLine();

            Console.WriteLine("Enter the student's last name");
            LastName = Console.ReadLine();

            Console.WriteLine("Enter the student's birthday");
            Birthdate = Console.ReadLine();
        }

        public static void PrintStudentDetails()
        {
            Console.WriteLine("{0} {1} was born on: {2}", FirstName, LastName, Birthdate);
        }

        public static void ValidatingStudentBirthday()
        {
            throw new NotImplementedException();
        }
    }
}
