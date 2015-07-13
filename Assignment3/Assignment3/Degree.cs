using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Degree
    {
        static string DegreeName;
        static int CreditsRequired;

        public static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the Degree's name: ");
            DegreeName = Console.ReadLine();

            Console.WriteLine("Enter the CreditsRequired: ");
            CreditsRequired = int.Parse(Console.ReadLine());
        }

        public static void PrintDegreeDetails()
        {
            Console.WriteLine("Degree: {0}, CreditsRequired: {1}", DegreeName, CreditsRequired);
        }
    }
}
