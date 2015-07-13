using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            for(i = 0;i<8;i++)
                for (j = 0; j < 8; j++)
                {
                    int t = (i+j) & 1;
                    if(t == 0)
                        Console.Write("X");
                    else
                        Console.Write("O");
                    if (j == 8 - 1)
                        Console.WriteLine();
                }

            Console.ReadLine();
        }
    }
}
