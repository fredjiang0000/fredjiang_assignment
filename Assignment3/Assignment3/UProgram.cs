using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class UProgram
    {
        static string ProgramName, DepartmentHead;
        static int Degrees;

        public static void GetUProgramInformation()
        {
            Console.WriteLine("Enter the Program's name: ");
            ProgramName = Console.ReadLine();

            Console.WriteLine("Enter the DepartmentHead's name: ");
            DepartmentHead = Console.ReadLine();

            Console.WriteLine("Enter the Degrees: ");
            Degrees = int.Parse(Console.ReadLine());
        }

        public static void PrintUProgramDetails()
        {
            Console.WriteLine("Program: {0}, DepartmentHead: {1}, Degrees: {2}", ProgramName, DepartmentHead, Degrees);
        }
    }
}
