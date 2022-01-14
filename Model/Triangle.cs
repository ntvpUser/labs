using System;
using System.Xml.Linq;

namespace Model
{
    [Serializable]
    public class Triangle : IFigure
    {
        public string Name => "Треугольник";

        private double _a;
        private double _b;
        private double _c;

        public double Square => Math.Sqrt((_a + _b + _c) / 2 * ((_a + _b + _c) / 2 - _a) * ((_a + _b + _c) / 2 - _b) * ((_a + _b + _c) / 2 - _c));

        public bool TriangleCheck(double a, double b, double c) =>
            ((a + b) < c || (a + c) < b || (b + c) < a);

        public Triangle(double a, double b, double c)
        {
            if (!(a > 0) || !(b > 0) || !(c > 0)) 
                throw new Exception("значения должны быть положительными");

            if (TriangleCheck(a, b, c))
                throw new Exception("правило треугольника не соблюдено");

            _a = a;
            _b = b;
            _c = c;
        }

        public override string ToString()
        {
            return "Треугольник, площадь: " + Square + ", стороны: " + _a + ", " + _b + ", " + _c;
        }
    }
}
