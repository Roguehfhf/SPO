using System;
using GeometricFigures;
using NUnit.Framework;

namespace UnitTest.GeometricsFigureModel
{
    [TestFixture]
    public class RingTest
    {
        [Test]
        [TestCase(2, 1, ExpectedResult = (Math.PI * ((2 * 2)- (1 * 1))),
            TestName = "1.1) Тестирование класса Ring свойства Area при верном значении")]
        [TestCase(-3, 1, ExpectedException = (typeof(ArgumentException)),
            TestName = "1.2) Тестирование класса Ring свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(8, 5, ExpectedResult = (Math.PI * ((8 * 8) - (5 * 5))),
            TestName = "1.3) Тестирование класса Ring свойства Area при верном значении")]
        [TestCase(-8, 1, ExpectedException = (typeof(ArgumentException)),
            TestName = "1.4) Тестирование класса Ring свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(4, 2, ExpectedResult = Math.PI * ((4 * 4) - (2 * 2)), 
            TestName = "1.5) Тестирование класса Ring свойства Area при верном значении")]
        public double RingAreaTest(double outsideRadius, double innerRadius)
        {
            var ring = new Ring(outsideRadius, innerRadius);
            return ring.Area;
        }

        [Test]
        [TestCase(3, 2,  ExpectedResult = (2 * Math.PI * (3 - 2)),
            TestName = "Тестирование класса Ring свойства Perimeter при верном значении")]
        [TestCase(-3, 1, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса Ring свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(4, 1, ExpectedResult = (2 * Math.PI * (4 - 1)),
            TestName = "Тестирование класса Ring свойства Perimeter при верном значении")]
        [TestCase(-7, 0, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса Ring свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(5, 3, ExpectedResult = (2 * Math.PI * (5 - 3)),
            TestName = "Тестирование класса Ring свойства Perimeter при верном значении")]
        public double RingPerimeterTest(double outsideRadius, double innerRadius)
        {
            var ring = new Ring(outsideRadius, innerRadius); 
            return ring.Perimeter;
        }
    }
}
