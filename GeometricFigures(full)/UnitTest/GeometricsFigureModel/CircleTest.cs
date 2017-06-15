using System;
using GeometricFigures;
using NUnit.Framework;


namespace UnitTest.GeometricsFigureModel

{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        [TestCase(5, ExpectedResult = (Math.PI * 5 * 5), 
            TestName = "Тестирование класса Circle свойства Area при верном значении")]
        [TestCase(0, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса Circleсвойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(1, ExpectedResult = (Math.PI), 
            TestName = "Тестирование класса Circle свойства Area при верном значении")]
        [TestCase(-1, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса Circle свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(2, ExpectedResult = (Math.PI * 2 * 2), TestName = "Тестирование класса Circle свойства Area при верном значении")]
        public double CircleAreaTest(double radius)
        {
            var circle = new Circle(radius);
            return circle.Area;
        }

        [Test]
        [TestCase(3, ExpectedResult = (2 * Math.PI * 3), 
            TestName = "Тестирование класса CircleFigure свойства Perimeter при верном значении")]
        [TestCase(0, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса CircleFigure свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(1, ExpectedResult = (2 * Math.PI * 1), 
            TestName = "Тестирование класса CircleFigure свойства Perimeter при верном значении")]
        [TestCase(-1, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса CircleFigure свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(2, ExpectedResult = (2 * Math.PI * 2), 
            TestName = "Тестирование класса CircleFigure свойства Perimeter при верном значении")]
        public double CirclePerimeterTest(double radius)
        {
            var circle = new Circle(radius);
            return circle.Perimeter;
        }
    }
}