using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQn7
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            // Constructor
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            // Overloading the unary minus (-) operator
            public static Point operator -(Point p)
            {
                return new Point(-p.X, -p.Y);
            }

            // Method to display the point
            public void DisplayPoint()
            {
                Console.WriteLine($"Point: ({X}, {Y})");
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Create a point object
                Point p1 = new Point(5, -3);
                Console.WriteLine("Original Point:");
                p1.DisplayPoint();

                // Use overloaded unary minus operator to negate the point
                Point p2 = -p1;
                Console.WriteLine("\nPoint after applying unary minus operator:");
                p2.DisplayPoint();

                Console.ReadKey();
            }*/
        }
    }
}
