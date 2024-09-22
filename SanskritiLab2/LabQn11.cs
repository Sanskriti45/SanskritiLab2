using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQn11
    {
        public class GenericClass<T>
        {
            // Field to store data of any type
            private T data;

            // Constructor to initialize data
            public GenericClass(T value)
            {
                data = value;
            }

            // Method to display data
            public void DisplayData()
            {
                Console.WriteLine($"Data: {data}");
            }
        }

        class Program
        {
            // Generic method
            public static void Swap<T>(ref T value1, ref T value2)
            {
                T temp = value1;
                value1 = value2;
                value2 = temp;
            }

            /*static void Main(string[] args)
            {
                // Using generic class with integer data
                GenericClass<int> intObj = new GenericClass<int>(123);
                intObj.DisplayData();

                // Using generic class with string data
                GenericClass<string> stringObj = new GenericClass<string>("Hello Generics");
                stringObj.DisplayData();

                // Demonstrating generic method (Swap)
                int a = 10, b = 20;
                Console.WriteLine($"Before Swap: a = {a}, b = {b}");
                Swap<int>(ref a, ref b); // Swapping two integers
                Console.WriteLine($"After Swap: a = {a}, b = {b}");

                string x = "First", y = "Second";
                Console.WriteLine($"Before Swap: x = {x}, y = {y}");
                Swap<string>(ref x, ref y); // Swapping two strings
                Console.WriteLine($"After Swap: x = {x}, y = {y}");

                Console.ReadKey();
            }*/
        }
    }
}
