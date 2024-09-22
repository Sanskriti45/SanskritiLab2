using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQN4
    {
        // Single Inheritance
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }
        }

        class Dog : Animal  // Dog inherits from Animal (Single Inheritance)
        {
            public void Bark()
            {
                Console.WriteLine("Dog is barking.");
            }
        }

        // Multilevel Inheritance
        class Mammal : Dog  // Mammal inherits from Dog, Dog inherits from Animal (Multilevel Inheritance)
        {
            public void Walk()
            {
                Console.WriteLine("Mammal is walking.");
            }
        }

        // Hierarchical Inheritance
        class Cat : Animal  // Cat also inherits from Animal (Hierarchical Inheritance)
        {
            public void Meow()
            {
                Console.WriteLine("Cat is meowing.");
            }
        }

        class Program
        {
          /*  static void Main(string[] args)
            {
                // Single Inheritance Example
                Dog dog = new Dog();
                dog.Eat();  // Inherited from Animal
                dog.Bark(); // Method of Dog

                Console.WriteLine();

                // Multilevel Inheritance Example
                Mammal mammal = new Mammal();
                mammal.Eat();   // Inherited from Animal
                mammal.Bark();  // Inherited from Dog
                mammal.Walk();  // Method of Mammal

                Console.WriteLine();

                // Hierarchical Inheritance Example
                Cat cat = new Cat();
                cat.Eat();   // Inherited from Animal
                cat.Meow();  // Method of Cat

                Console.ReadKey();
            }*/
        }
    }
}
