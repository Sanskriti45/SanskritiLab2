using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQn3
    {
        public partial class Person
        {
            // Fields and properties for the class
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
        public partial class Person
        {
            // Method to display person's full information
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
            }
        }
        class Program
        {
            /*static void Main(string[] args)
            {
                // Create a new Person object
                Person person = new Person
                {
                    FirstName = "Sanskriti",
                    LastName = "Tiwari",
                    Age = 23
                };

                // Call the method to display person's information
                person.DisplayInfo();

                Console.ReadKey();
            }*/
        }
    }
}
