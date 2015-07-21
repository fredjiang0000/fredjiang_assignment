using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Degree
    {
        public string name;
        public Course course;

        public Degree(string s)
        {
            name = s;
        }

        public void AddCourse(Course c)
        {
            course = c;
        }
    }
}
