using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment8
{
    class Course
    {
        const int SIZE = 3;
        int student_num = 0;
        int teacher_num = 0;
        public string name;
        List<Student> arr_student = new List<Student>();
        Teacher[] arr_teacher = new Teacher[SIZE];

        public Course(string s)
        {
            name = s;
        }

        public void AddStudent(Student s)
        {
            if (student_num >= SIZE)
                throw new IndexOutOfRangeException("Number of students can't be more than 3");
            arr_student.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            if (teacher_num >= SIZE)
                throw new IndexOutOfRangeException("Number of teacher can't be more than 3");
            arr_teacher[teacher_num++] = t;
        }

        //List all students' name
        public void ListStudents()
        {
            foreach(Student s in arr_student)
                Console.WriteLine("Student's name: {0} {1}", s.FirstName, s.LastName);
        }
    }
}
