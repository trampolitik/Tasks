using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public static class Geometry
    {
        public static double CalculateSquare(IShape shape) => shape.GetSquare();
        
    }
}
