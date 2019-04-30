using System;
using System.Collections.Generic;
using AreaCalculator.Lib;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
               List<IFigure> figures = new List<IFigure>()
               {
                   new Circle(new Length(2)),
                   new Triangle(new Length(2), new Length(2), new Length(2))
               };
                figures.ForEach(f=> Console.WriteLine(f.Square.Value.ToString()));
        }
    }
}
