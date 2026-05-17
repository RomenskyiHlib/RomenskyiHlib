using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTenth.Service
{
    internal class GeometryThings
    {
        public Func<double, double, double> TriangleArea =>
            (baseLength, height) => 0.5 * baseLength * height;

        public Func<double, double, double> RectangleArea =>
            (width, height) => width * height;
    }
}
