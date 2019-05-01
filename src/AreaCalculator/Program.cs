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
                   new Circle(2),
                   new Triangle(2, 3, 4)
               };
                figures.ForEach(f=> Console.WriteLine(f.Square.Value.ToString()));
        }
    }
}
