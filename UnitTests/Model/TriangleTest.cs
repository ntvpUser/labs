using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        [TestCase(21, 23, 52, "Тест для треугольника со сторонами 21, 23 и 52")]
        [TestCase(11.52, 13.77, 1, "Тест для треугольника со сторонами 11.52, 13.77 и 1")]
        [TestCase(double.MaxValue, double.MaxValue, 0, "Тест для треугольника со сторонами double.MaxValue, double.MaxValue и 0")]
        [TestCase(double.NaN, double.NegativeInfinity, 3, "Тест для треугольника со сторонами double.NaN и double.NegativeInfinity, 3")]
        [TestCase(-3, 0, -5, "Тест для треугольника со сторонами -3, 0 и -5")]
        public void TriangleSquareTest(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
        }
    }
}
