using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class UProgram
    {
        public string name;
        public Degree degree;

        public UProgram(string s)
        {
            name = s;
        }

        public void AddDegree(Degree d)
        {
            degree = d;
        }
    }
}
