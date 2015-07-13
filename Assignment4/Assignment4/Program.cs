using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int i;

            Student[] arr = new Student[5];

            for (i = 0; i < 5; i++)
            {
                arr[i].FirstName = "F" + i.ToString() ;
                arr[i].LastName = "L" + i.ToString();
                arr[i].Birthdate = "20150708";
                arr[i].AddressLine1 = "Address1-" + i.ToString();
                arr[i].AddressLine2 = "Address2-" + i.ToString();
                arr[i].City = "Kaohsiung";
                arr[i].StateOrProvince = "null";
                arr[i].ZipOrPostal = "802";
                arr[i].Country = "Taiwan";
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("First name: "+ arr[i].FirstName);
                Console.WriteLine("Last name: " + arr[i].LastName);
                Console.WriteLine("Birthdate: " + arr[i].Birthdate);
                Console.WriteLine("AddressLine1: " + arr[i].AddressLine1);
                Console.WriteLine("AddressLine2: " + arr[i].AddressLine2);
                Console.WriteLine("City: " + arr[i].City);
                Console.WriteLine("StateOrProvince: " + arr[i].StateOrProvince);
                Console.WriteLine("ZipOrPostal: " + arr[i].ZipOrPostal);
                Console.WriteLine("Country: " + arr[i].Country);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
