using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQn9
    {
        class Student
        {
            // Private fields
            private string name;
            private int age;
            private int marks1;
            private int marks2;

            // Read-Only Property
            public string Name
            {
                get { return name; }
            }

            // Write-Only Property
            public int Age
            {
                set { age = value; }
            }

            // Auto-Implemented Property
            public string Address { get; set; }

            // Computed Property
            public int TotalMarks
            {
                get { return marks1 + marks2; }
            }

            // Constructor to initialize name, marks1, and marks2
            public Student(string studentName, int m1, int m2)
            {
                name = studentName;
                marks1 = m1;
                marks2 = m2;
            }

            // Method to display student information
            public void DisplayInfo()
            {
                Console.WriteLine($"Student Name: {Name}");
                Console.WriteLine($"Total Marks: {TotalMarks}");
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Create a new student object
                Student student = new Student("Harry Potter", 80, 90);

                // Set the write-only property
                student.Age = 20;

                // Set the auto-implemented property
                student.Address = "Azkaban";

                // Display student information using read-only and computed properties
                student.DisplayInfo();

                // Print the auto-implemented property value
                Console.WriteLine($"Address: {student.Address}");

                Console.ReadKey();
            }*/
        }
    }
}
