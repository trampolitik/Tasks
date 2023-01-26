using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Cricle : IShape
    {
        private readonly double _radius;
        public Cricle(double raduis)
        {
            _radius = raduis;
        }
        public double GetSquare() =>  Math.PI* Math.Pow(_radius, 2);

    }
}
