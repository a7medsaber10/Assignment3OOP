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
        // - This is achieved using the (virtual keyword) in the base class method and the (override keyword) in the derived class method or with new keyword in derived class.
        // - The method to be called is determined at runtime based on the object instance.

        public class Animal
        {
            public string animal { get; set; }

            public Animal(string _animal)
            {
                animal = _animal;
            }
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal sound");
            }

            public void getAnimal()
            {
                Console.WriteLine($"Animal: {animal}");
            }


        }

        public class Dog : Animal
        {
            public int dog { get; set; }
            public Dog(string _animal, int _dog) : base(_animal)
            {
                dog = _dog;
            }

            // Overriding using keyword override
            public override void MakeSound()
            {
                Console.WriteLine("hooow hoooww");
            }
            // Overriding using keyword new
            public new void getAnimal()
            {
                Console.WriteLine($"Dog: {dog}");
            }

        }


        #endregion

        #region Binding Part1
        // Binding => Reference from parent = Object from child

        // Binding have two main types =>   1.Static Binding     2.Dynamic Binding


        // 1.Static Binding 
        // - occurs at compile time
        // - Faster execution due to no runtime overhead.
        // - Provides compile-time type checking, reducing runtime errors.
        // - Preferred when type information is known at compile time.
        // - Used in most regular programming scenarios for better performance and type safety.

        // 2. Dynamic Binding 
        // - occurs at runtime
        // - More flexible, allowing for scenarios where the type or members are not known at compile time.
        // - Is generally slower than Static binding.
        // - Employed in scenarios requiring reflection, such as dynamically loading assemblies or creating instances of types at runtime.

        class TypeA
        {
            public int A { get; set; }

            public TypeA(int _A)
            {
                A = _A;
            }

            public void myFunc01()
            {
                Console.WriteLine($"Base");
            }

            public virtual void myFunc02()
            {
                Console.WriteLine($"Type A: A => {A}");
            }
        }

        class TypeB : TypeA
        {
            public int B { get; set; }

            public TypeB(int _A, int _B) : base(_A)
            {
                B = _B;
            }

            public new void myFunc01()
            {
                Console.WriteLine($"Child");
            }

            public override void myFunc02()
            {
                Console.WriteLine($"Type B: B => {B}");
            }
        }

        class TypeC : TypeB
        {
            public int C { get; set; }

            public TypeC(int _A, int _B, int _C) : base(_A, _B)
            {
                C = _C;
            }

            public new void myFunc01()
            {
                Console.WriteLine($"Grand Child");
            }

            public override void myFunc02()
            {
                Console.WriteLine($"Type C: C => {C}");
            }
        }
        #endregion

        #region Interface
        // Interface => is a contract that defines a set of methods, properties, events, or indexers without providing implementation.
        // Default access modifier => public
        // private not allowed inside interface

        // we can write inside interface:
        // 1. signature for property
        // 2. signature for method
        // 3. Default implemented method
        interface IMyInterface
        {

            //1. signature for property
            public int Age { get; set; }

            //2. signature for method
            public void myfunc();

            //3. Default implemented method
            public void print() { Console.WriteLine("Default implemented method"); }
        }

        class myType : IMyInterface
        {
            public int Age { get; set; } // Automatic prop

            public void myfunc() => Console.WriteLine("Hello!");
        }
        #endregion

        static void Main(string[] args)
        {
            #region Binding Part2
            //TypeA refBase = new TypeB(1, 2);
            //refBase.A = 1; // valid
            //refBase.B = 2; // invalid

            //refBase.myFunc01();  // Base [new => Parent]  Static Binding

            //refBase.myFunc02();  // Type B: B => 2 [override => child] Dynamic binding

            //TypeB refChild =  (TypeB)refBase; // Casting not binding => [Unsafe]
            //// -------------------------------------------------------------------------------

            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 1; // Valid
            //typeA.B = 2; // invalid
            //typeA.C = 3; // invalid

            //typeA.myFunc01();  // Base [new => Parent]  Static Binding
            //typeA.myFunc02();  // Type C: C => 3 [override => child] Dynamic binding


            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 1; // Valid
            //typeB.B = 2; // Valid
            //typeB.C = 3; // invalid

            //typeB.myFunc01();  // Base [new => Parent]  Static Binding
            //typeB.myFunc02();  // Type C: C => 3 [override => child] Dynamic binding 
            #endregion

        }
    }
}
