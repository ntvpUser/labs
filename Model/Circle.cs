using System;
using System.Reflection;

namespace Model
{
    [Serializable]
    public class Circle : IFigure
    {
        public string Name => "Круг";

        private double _r;

        public double Square => _r * _r * Math.PI;

        public double R
        {
            get => _r;
            set
            {
                if (value >= 0)
                    _r = value;
            }
        }

        public Circle(double r)
        {
            if (r < 0) throw new Exception("Значение должно быть положительным");

            _r = r;
        }

        public override string ToString()
        {
            return "Круг, площадь: " + Square + ", радиус: " + R;
        }
    }
}
