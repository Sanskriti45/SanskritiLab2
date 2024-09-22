using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQn8
    {
        class ComplexNumber
        {
            public int Real { get; set; }  // Real part of the complex number
            public int Imaginary { get; set; }  // Imaginary part of the complex number

            // Constructor to initialize complex number
            public ComplexNumber(int real, int imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            // Overloading the binary + operator
            public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
            {
                // Add the real parts and imaginary parts separately
                return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
            }

            // Method to display the complex number
            public void Display()
            {
                Console.WriteLine($"{Real} + {Imaginary}i");
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Create two complex number objects
                ComplexNumber c1 = new ComplexNumber(3, 2);
                ComplexNumber c2 = new ComplexNumber(1, 7);

                // Display the complex numbers
                Console.WriteLine("First complex number:");
                c1.Display();

                Console.WriteLine("\nSecond complex number:");
                c2.Display();

                // Use the overloaded + operator to add the complex numbers
                ComplexNumber result = c1 + c2;

                // Display the result of addition
                Console.WriteLine("\nAfter adding the two complex numbers:");
                result.Display();

                Console.ReadKey();
            }*/
        }
    }
}

