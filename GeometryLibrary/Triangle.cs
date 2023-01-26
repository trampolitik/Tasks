using System;


namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double GetSquare()
        {
            double s = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }

        public bool IsRectangular()
        {
            double[] sides = { _side1, _side2, _side3 };
            Array.Sort(sides);
            var side1 = sides[0];
            var side2 = sides[1];
            var side3 = sides[2];

            return Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2); 
        }
    }
}
