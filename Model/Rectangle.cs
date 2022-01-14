using System;

namespace Model
{
    [Serializable]
    public class Rectangle : IFigure
    {
        public string Name => "Прямоугольник";

        private double _a;
        private double _b;

        public double Square => _a*_b;

        public Rectangle(double a, double b)
        {
            if (a < 0 && b < 0)
                throw new Exception("Стороны должны быть > 0");

            _a = a;
            _b = b;
        }

        public override string ToString()
        {
            return "Прямоугольник. Площадь: " + Square + ", стороны: " + _a + ", " + _b;
        }
    }
}
