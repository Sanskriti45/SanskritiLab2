using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanskritiLab2
{
    internal class LabQn5
    {
     
    
        // Base class
        class Name
        {
            // Virtual method
            public virtual void Spell()
            {
                Console.WriteLine("My name is Sanskriti");
            }
        }

        // Derived class Dog
        class Add : Name
        {
            // Overriding the virtual method
            public override void Spell()
            {
                Console.WriteLine("Lives in syuchatar.");
            }
        }

        // Derived class Cat
        class Phone : Name
        {
            // Overriding the virtual method
            public override void Spell()
            {
                Console.WriteLine("Number is 10 digits");
            }
        }

        class Program
        {
           /* static void Main(string[] args)
            {
                // Create objects of Animal, Dog, and Cat
                Name myName = new Name();
                Name myAdd = new Add();
                Name myPhone = new Phone();

                // Call the Sound method on each object
                myName.Spell();  // Calls the method from the Animal class
                myAdd.Spell();     // Calls the overridden method from the Dog class
                myPhone.Spell();     // Calls the overridden method from the Cat class

                Console.ReadKey();
            }*/
        }
    }

}

