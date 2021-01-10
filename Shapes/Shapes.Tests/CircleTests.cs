using System;
using NUnit.Framework;

namespace Shapes.Tests
{
    public class CircleTests
    {
        
        [Test]
        public void CircleSquareShouldBeCorrectCalculated()
        {
            //arrange
            var circleUnderTest = new Circle(2);
            var expectedSquare = Math.PI * Math.Pow(2, 2);
            //act
            var actualSquare = circleUnderTest.Square();
            //assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }
    }
}