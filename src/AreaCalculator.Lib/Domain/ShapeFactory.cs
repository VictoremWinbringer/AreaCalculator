using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace AreaCalculator.Lib
{
    public sealed class ShapeFactory
    {
        public Shape Create(string input)
        {
            return input?
                .Split(":", System.StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim().ToLower())
                .ToArray()
                 switch
            {
                var args when args.Length == 2 && args[0] == "circle" => (Shape)new Circle(new Radius(double.Parse(args[1]))),
                var args when args.Length == 2 && args[0] == "rectangle" => CreateRectangle(args[1]),
                _ => throw new NotImplementedException(input) { Source = typeof(ShapeFactory).FullName }
            };
        }

        private Rectangle CreateRectangle(string input)
        {
            var args = input.Split("x", StringSplitOptions.RemoveEmptyEntries);
            return new Rectangle(new Height(double.Parse(args[0])), new Width(double.Parse(args[1])));
        }
    }
}