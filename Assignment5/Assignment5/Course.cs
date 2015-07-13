using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment5
{
    class Course
    {
        const int SIZE = 3;
        int student_num = 0;
        int teacher_num = 0;
        public string name;
        Student[] arr_student = new Student[SIZE];
        Teacher[] arr_teacher = new Teacher[SIZE];

        public Course(string s)
        {
            name = s;
        }

        public void AddStudent(Student s)
        {
            if (student_num >= SIZE)
                throw new IndexOutOfRangeException("Number of students can't be more than 3");
            arr_student[student_num++] = s;
        }

        public void AddTeacher(Teacher t)
        {
            if (teacher_num >= SIZE)
                throw new IndexOutOfRangeException("Number of teacher can't be more than 3");
            arr_teacher[teacher_num++] = t;
        }
    }
}
