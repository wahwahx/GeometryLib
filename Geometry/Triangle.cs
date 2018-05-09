using System;
using System.Collections.Generic;
using System.Linq;

namespace Geometry
{
    public class Triangle : IFigure
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (!(side1 + side2 > side3 && side1 + side3 > side2 && side3 + side2 > side1))
            {
                throw new ApplicationException("A triangle with such sides can not exist");
            }

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double GetSquare()
        {
            var semiperimeter = (_side1 + _side2 + _side3) / 2;
            var result = Math.Sqrt(semiperimeter * (semiperimeter - _side1) * (semiperimeter - _side2) * (semiperimeter - _side3));
            return result;
        }

        public bool IsRightAngle()
        {
            var sides = new List<double> {_side1, _side2, _side3};
            var hypotenuse = sides.Max();
            sides.Remove(hypotenuse);
            var hypotenuseForRightAngle = Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
            var res = hypotenuse.CompareTo(hypotenuseForRightAngle) == 0;
            return res;
        }
    }
}

