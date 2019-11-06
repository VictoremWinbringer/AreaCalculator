using AreaCalculator.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaCalculator
{
    class Program
    {
        static void Main()
        {

            var factory = new ShapeFactory();
            while (true)
            {
                var circle = Console.ReadLine();
                var rectange = Console.ReadLine();
                var result = new[] { circle, rectange }
                    .Select(s => factory.Create(s))
                    .Select(s => $"Area:{s.Area.Value}, Perimeter: {s.Perimeter.Value}");
                foreach (var r in result)
                {
                    Console.WriteLine(r);
                }
            }
        }
    }
}
