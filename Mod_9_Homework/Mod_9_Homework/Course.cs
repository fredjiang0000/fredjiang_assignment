using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mod_9_Homework
{
    class Course
    {
        public const int SIZE = 3;
        int teacher_num = 0;
        public int student_index = 0;
        public string name;
        List<Student> arr_student = new List<Student>();
        Teacher[] arr_teacher = new Teacher[SIZE];

        public Course(string s)
        {
            name = s;
        }

        public int AddStudent(Student s)
        {
            //Insert the student and update the index
            arr_student.Insert(student_index++,s);

            return 0;
        }

        public int AddTeacher(Teacher t)
        {
            if (teacher_num >= SIZE)
                return 1;
            arr_teacher[teacher_num++] = t;

            return 0;
        }

        //List student's information
        public Student ListStudent()
        {
            return arr_student[student_index];
        }

        public int SizeofStudentList()
        {
            return arr_student.Count;
        }
    }
}
