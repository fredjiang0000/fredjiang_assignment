using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Student : Person
    {
        public void TakeTest()
        {
        }

        public static class TrackStudent
        {
            public static int student_num = 0;
        }

        public override void Myconstruct()
        {
            Student.TrackStudent.student_num++;
        }
    }
}
