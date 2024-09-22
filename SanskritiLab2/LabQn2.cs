using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQn2
    {
        public class MyClass
        {
            public string Name { get; set; }

            public void DisplayMessage()
            {
                Console.WriteLine($"Hello from {Name} in Namespace1!");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // Create an object of MyClass from Namespace1
                MyClass obj = new MyClass();
                obj.Name = "Sanskriti";

                // Accessing method from the class in Namespace1
                obj.DisplayMessage();

                Console.ReadKey();
            }
        }
    }
}
