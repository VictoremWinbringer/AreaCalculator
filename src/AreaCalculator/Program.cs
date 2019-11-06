using AreaCalculator.Lib;
using AreaCalculator.Lib.Domain;
using System;
using System.Collections.Generic;

namespace AreaCalculator
{
    class Program
    {
        static void Main()
        {
            var factory = new ShapeFactory();
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();
                    var shape = factory.Create(input);
                    Console.WriteLine($"Area:{shape.Area}, Perimeter: {shape.Perimeter}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
