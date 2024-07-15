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







        static void Main(string[] args)
        {
            
        }
    }
}
