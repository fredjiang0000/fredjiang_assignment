using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Teacher : Person
    {
        public void GradeTest()
        {
        }

        //record how many teacher class declared
        public static class TrackTeacher
        {
            public static int teacher_num = 0;
        }

        //number of teacher classes increase
        public override void Myconstruct()
        {
            Teacher.TrackTeacher.teacher_num++;
        }

    }
}
