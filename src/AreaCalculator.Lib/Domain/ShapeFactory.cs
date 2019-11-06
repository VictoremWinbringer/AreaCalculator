using System;
using System.Collections.Generic;

namespace AreaCalculator.Lib.Domain
{
    public sealed class ShapeFactory : BaseShapeFactory
    {
        private readonly Dictionary<string, ShapeCreator> _factory;

        public ShapeFactory()
        {
            _factory = new Dictionary<string, ShapeCreator>
            {
                ["circle"] = new CircleCreator(),
                ["rectangle"] = new RectangleCreator()
            };
        }
        public override Shape Create(string input)
        {
            var args = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
            if (args.Length != 2)
                throw new ArgumentException($"Bad shape input: {input}. Print line like 'circle:10 or rectangle:10x20'");
            var key = args[0].Trim().ToLower();
            var value = args[1].Trim().ToLower();
            if (!_factory.ContainsKey(key))
                throw new ArgumentException($"Unknown shape - {key}");
            return _factory[key].Create(value);
        }
    }
}
