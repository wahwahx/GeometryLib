using System;

namespace Geometry
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ApplicationException("The radius can not be negative");
            }
            _radius = radius;
        }
        public double GetSquare()
        {
            var result = Math.PI * Math.Pow(_radius, 2);
            return result;
        }
    }
}
