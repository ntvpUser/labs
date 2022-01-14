using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        [TestCase(21, 23, "Тест для прямоугольника со сторонами 21 и 23")]
        [TestCase(21.52, 13.77, "Тест для прямоугольника со сторонами 21.52 и 13.77")]
        [TestCase(double.MaxValue, 15, "Тест для прямоугольника со сторонами double.MaxValue и 15")]
        [TestCase(double.NaN, double.NegativeInfinity, "Тест для прямоугольника со сторонами double.NaN и double.NegativeInfinity")]
        [TestCase(-3, 0, "Тест для прямоугольника со сторонами -3 и 0")]
        public double RectangleSquareTest(double a, double b)
        {
            var rectangle = new Rectangle(3, 4);
            return rectangle.Square;
        }
    }
}
