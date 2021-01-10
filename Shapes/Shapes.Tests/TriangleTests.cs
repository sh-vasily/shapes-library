using System;
using FluentAssertions;
using Xunit;

namespace Shapes.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3,4,5,true)]
        [InlineData(3,4,6,false)]
        public void ShouldCorrectDetermineTriangleRectangleOrNot(int A, int B, int C, bool isTriangleRectangle)
        {
            //arrange
            var triangleUnderTest = new Triangle(A, B, C);
            //act assert
            triangleUnderTest.IsRectangular
                .Should()
                .Be(isTriangleRectangle);
        }
        
        [Fact]
        public void NotRectangleTriangleSquareShouldBeCorrectCalculated()
        {
            //arrange
            var triangleUnderTest = new Triangle(3,4,6);
            var expectedSquare = 5.333;
            //act
            var actualSquare = Math.Round(triangleUnderTest.Square(),3);
            //assert
            actualSquare
                .Should()
                .Be(expectedSquare);
        }
        
        [Fact]
        public void RectangleTriangleSquareShouldBeCorrectCalculated()
        {
            //arrange
            var triangleUnderTest = new Triangle(3,4,5);
            var expectedSquare = 6;
            //act
            var actualSquare = Math.Round(triangleUnderTest.Square(),3);
            //assert
            actualSquare
                .Should()
                .Be(expectedSquare);
        }
    }
}