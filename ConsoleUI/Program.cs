using System;
using static System.Console;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cannot instantiate the Shape class because it is an Abstract class.
            // Shape shape1 = new Shape();

            // Create an array of shapes.
            Shape[] shapes =
            {
                new Sphere(4),
                new Cube(3)
            };

            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                WriteLine($"{shape.Name} has a volume of {shape.Volume()}");
            }

            ReadKey(true);
        }
    }
}
