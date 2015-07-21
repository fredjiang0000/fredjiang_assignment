using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Mod11_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ArrayList students = new ArrayList();
        private int student_index = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            newStudent.FirstName = txtFirstName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.City = txtCity.Text;
            ClearForm();

            //use asynchronous task to add student
            Task.Run(() => AddToCollection(newStudent));
        }

        
        private void AddToCollection(Student student)
        {
            // This line of code is intended to simulate network or database latency
            // It causes a non-responsive UI
            // Do not remove this line of code as a way of completing the assignment
            // You MUST use a C# task to get credit
            Thread.Sleep(5000);
            students.Add(student);
            int count = students.Count;
            MessageBox.Show("Student created successfully.  Collection contains " + count.ToString() + " Student(s).");
            student_index++;

            //Use delegate to get the object which in other thread
            Action methodDelegate = delegate()
	        {
                TestBtnIsEnabled();
	        };
	        this.Dispatcher.BeginInvoke(methodDelegate);
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtFirstName.Focus();
        }

        //print the previous index student
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            student_index--;
            TestBtnIsEnabled();

            Student s = (Student)students[student_index];

            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtCity.Text = s.City;
        }

        //print the next index student
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            student_index++;
            TestBtnIsEnabled();

            if (student_index == students.Count)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtCity.Text = "";
                return;
            }
            Student s = (Student)students[student_index];

            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtCity.Text = s.City;
        }

        //set the button
        void TestBtnIsEnabled()
        {
            if (student_index == 0)
                btnPrevious.IsEnabled = false;
            else
                btnPrevious.IsEnabled = true;

            if (student_index == students.Count)
                btnNext.IsEnabled = false;
            else
                btnNext.IsEnabled = true;
        }

    }
}
