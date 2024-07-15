using System;
using System.Buffers.Text;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3OOP
{
    internal class Program
    {
        #region Polymorphism
        // Polymorphism can be achieved through overriding and overloading.
        // * Allows methods to be reused in different contexts with the same name
        // * Makes it easier to introduce new classes that conform to existing interfaces.
        // * Reduces the need for large conditional statements by allowing different object types to be treated uniformly.
        #endregion

        #region Overloading
        // Method overloading:
        // - Allows a class to have multiple methods with the same name but different parameters.
        // - The compiler determines which method to invoke based on the method signatures at compile time.
        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
        }

        // The three methods with same name but different Parameters 
        #endregion

        #region Overriding
        // Method overriding
        // - Allows a subclass to provide a specific implementation for a method that is already defined in its base class.
        // - This is achieved using the (virtual keyword) in the base class method and the (override keyword) in the derived class method.
        // - The method to be called is determined at runtime based on the object instance.

        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal sound");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("hooow hoooww");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("meow meow");
            }
        }

        #endregion





        static void Main(string[] args)
        {

            Animal animal = new Dog();
            animal.MakeSound(); // hooow hooow

            animal = new Cat();
            animal.MakeSound(); // meow meow
        }
    }
}
