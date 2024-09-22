using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQn10
    {
        class Shape
        {
            // Properties for Length and Breadth
            public double Length { get; set; }
            public double Breadth { get; set; }

            // Default constructor
            public Shape()
            {
                Length = 0;
                Breadth = 0;
            }

            // Parameterized constructor
            public Shape(double length, double breadth)
            {
                Length = length;
                Breadth = breadth;
            }
        }

        // Derived class Rectangle from Shape
        class Rectangle : Shape
        {
            // Constructor that calls base class parameterized constructor
            public Rectangle(double length, double breadth) : base(length, breadth)
            {
            }

            // Method to calculate area of rectangle
            public double CalculateArea()
            {
                return Length * Breadth;
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Create an object of Rectangle with length and breadth
                Console.WriteLine("Enter Length of the Rectangle:");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Breadth of the Rectangle:");
                double breadth = double.Parse(Console.ReadLine());

                Rectangle rect = new Rectangle(length, breadth);

                // Calculate and display the area
                double area = rect.CalculateArea();
                Console.WriteLine($"The area of the rectangle is: {area}");

                Console.ReadKey();
            }*/
        }
    }
}
