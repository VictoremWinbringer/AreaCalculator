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
                    .Select(s => s.Split(":", StringSplitOptions.RemoveEmptyEntries))
                    .Select(sa => (sa[0], sa[1].Split("x", StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray()))
                    .Select(sa => factory.Create(sa.Item1, sa.Item2))
                    .Select(s => $"Area:{s.Area.Value}, Perimeter: {s.Perimeter.Value}");
                foreach (var r in result)
                {
                    Console.WriteLine(r);
                }
            }
        }
    }
}
