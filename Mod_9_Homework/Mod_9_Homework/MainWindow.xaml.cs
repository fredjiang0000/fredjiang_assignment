using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course course = new Course("hw9");

        public MainWindow()
        {
            InitializeComponent();
        }

        //print the previous index student
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            course.student_index--;
            TestBtnIsEnabled();

            Student s = course.ListStudent();

            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtCity.Text = s.City;
        }

        //print the next index student
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            course.student_index++;
            TestBtnIsEnabled();

            if (course.student_index == course.SizeofStudentList())
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtCity.Text = "";
                return;
            }
            Student s = course.ListStudent();

            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtCity.Text = s.City;
        }

        //set the button
        void TestBtnIsEnabled()
        {
            if (course.student_index == 0)
                btnPrevious.IsEnabled = false;
            else
                btnPrevious.IsEnabled = true;

            if (course.student_index == course.SizeofStudentList())
                btnNext.IsEnabled = false;
            else
                btnNext.IsEnabled = true;
        }

        //store information from user
        private void EnterStudentInformation(Student s)
        {
            s.FirstName = "" + txtFirstName.Text;
            s.LastName = "" + txtLastName.Text;
            s.City = "" + txtCity.Text;
        }

        //clean all text
        private void CleanTxt()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        //to store the student's information that user enter
        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student();
            EnterStudentInformation(s);

            course.AddStudent(s);

            CleanTxt();
            TestBtnIsEnabled();
        }
    }
}
