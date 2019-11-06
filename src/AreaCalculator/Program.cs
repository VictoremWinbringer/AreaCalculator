using AreaCalculator.Lib;
using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main()
        {

            BaseShapeFactory factory = new ShapeFactory();
            while (true)
            {
                var input = Console.ReadLine();
                var shape = factory.Create(input);
                Console.WriteLine($"Area:{shape.Area.Value}, Perimeter: {shape.Perimeter.Value}");
            }
        }
    }
}
