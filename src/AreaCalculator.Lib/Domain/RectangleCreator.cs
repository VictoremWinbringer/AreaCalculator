using System;

namespace AreaCalculator.Lib.Domain
{
    public sealed class RectangleCreator : ShapeCreator
    {

        public override Shape Create(string input)
        {
            input = input?.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));
            var args = input.Split("x", StringSplitOptions.RemoveEmptyEntries);
            if (args.Length != 2)
                throw new ArgumentException($"{nameof(Rectangle)} Input: {input} has bad format. It should be like 10x20 and has 2 params");
            if (!double.TryParse(args[0], out var height))
                throw new ArgumentException($"{nameof(Rectangle)} Height: {args[0]} has bad format for double");
            if (!double.TryParse(args[1], out var width))
                throw new ArgumentException($"{nameof(Rectangle)} Width: {args[1]} has bad format for double");
            return new Rectangle(height, width);
        }
    }
}
