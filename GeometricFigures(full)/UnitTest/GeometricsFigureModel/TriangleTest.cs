using System;
using GeometricFigures;
using NUnit.Framework;


namespace UnitTest.GeometricsFigureModel
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        [TestCase(3, 4, 5, ExpectedResult = 6,
            TestName = "2.1) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        [TestCase(6, 8, -1, ExpectedException = typeof(ArgumentException),
            TestName = "2.2) Тестирование класса Triangle при присвоении сторон при ошибочных значениях, отрицательное значение")]
        [TestCase(6, 8, 10, ExpectedResult = 24,
            TestName = "2.3) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        [TestCase(11, 15, 81, ExpectedException = typeof(ArgumentException),
            TestName = "2.4) Тестирование класса Triangle при присвоении сторон при ошибочных значениях, несуществующий треугольник")]
        [TestCase(10, 10, 12, ExpectedResult = 48,
            TestName = "2.5) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        public double TriangleAreaTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle.Area;
        }

        [Test]
        [TestCase(1, 2, 2, ExpectedResult = 5,
            TestName = "3.1) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        [TestCase(1, -2, 3, ExpectedException = typeof(ArgumentException),
            TestName = "3.2) Тестирование класса Triangle при присвоении сторон при ошибочных значениях, отрицательное значение")]
        [TestCase(4, 4, 6, ExpectedResult = 14,
            TestName = "3.3) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        [TestCase(11, 15, 81, ExpectedException = typeof(ArgumentException),
            TestName = "3.4)Тестирование класса Triangle при присвоении сторон при ошибочных значениях, несуществующий треугольник")]
        [TestCase(8, 8, 5, ExpectedResult = 21,
            TestName = "3.5) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        public double TrianglePerimeterTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle.Perimeter;
        }
    }
}
