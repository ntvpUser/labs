using Model;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        [TestCase(4, "Тестирование при значении радиуса: 4")]
        [TestCase(3.5, "Тестирование при значении радиуса: 3.65")]
        [TestCase(double.MaxValue, "Тестирование при значении радиуса: double.MaxValue")]
        [TestCase(double.NaN, "Тестирование при значении радиуса: double.NaN")]
        [TestCase(0, "Тестирование при значении радиуса: 0")]
        public double CircleSquareTest(double r)
        {
            var circle = new Circle(r);
            return circle.Square;
        }
    }
}
