using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQn6
    {
        class Employee
        {
            // Fields
            public string Name;
            public int Salary;
            public static int CompanyID;

            // Default Constructor
            public Employee()
            {
                Name = "Harry Potter";
                Salary = 0;
                Console.WriteLine("Default constructor.");
            }

            // Parameterized Constructor
            public Employee(string name, int salary)
            {
                Name = name;
                Salary = salary;
                Console.WriteLine($"Parameterized constructor: Name = {Name}, Salary = {Salary}");
            }

            // Copy Constructor
            public Employee(Employee emp)
            {
                Name = emp.Name;
                Salary = emp.Salary;
                Console.WriteLine($"Copy constructor: Name = {Name}, Salary = {Salary}");
            }

            // Static Constructor
            static Employee()
            {
                CompanyID = 1001;
                Console.WriteLine($"Static constructor . Company ID: {CompanyID}");
            }

            // Method to display employee information
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Salary: {Salary}, Company ID: {CompanyID}");
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Static constructor will be called first
                Console.WriteLine("Creating Employee objects...\n");

                // Using Default Constructor
                Employee emp1 = new Employee();
                emp1.DisplayInfo();

                Console.WriteLine();

                // Using Parameterized Constructor
                Employee emp2 = new Employee("Ron", 50000);
                emp2.DisplayInfo();

                Console.WriteLine();

                // Using Copy Constructor
                Employee emp3 = new Employee(emp2);
                emp3.DisplayInfo();

                Console.ReadKey();
            }*/
        }
    }
}
