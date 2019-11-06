using System.Text;

namespace AreaCalculator.Lib.Domain
{
    public abstract class BaseShapeFactory
    {
        public abstract Shape Create(string input);
    }
}
