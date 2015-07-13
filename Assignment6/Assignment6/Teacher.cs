using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Teacher : Person
    {
        public void GradeTest()
        {
        }

        public static class TrackTeacher
        {
            public static int teacher_num = 0;
        }

        public override void Myconstruct()
        {
            Teacher.TrackTeacher.teacher_num++;
        }

    }
}
