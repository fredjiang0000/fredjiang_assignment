using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.FirstName = "Fred";
            s.LastName = "jiang";
            s.Birthdate = "830504";
            s.AddressLine1 = "T";
            s.AddressLine2 = "S";
            s.City = "Kaohsiung";
            s.Country = "Taiwan";

            Console.WriteLine("First Name = " + s.FirstName);
            Console.WriteLine("Last Name = " + s.LastName);
            Console.WriteLine("Birthdate = " + s.Birthdate);
            Console.WriteLine("AddressLine1 = " + s.AddressLine1);
            Console.WriteLine("AddressLine2 = " + s.AddressLine2);
            Console.WriteLine("City = " + s.City);
            Console.WriteLine("Country = " + s.Country);
            Console.ReadLine();
        }
    }
}
