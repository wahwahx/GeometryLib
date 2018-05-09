using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests
{
    [TestClass]
    public class TriangleTest
    {

        [TestMethod]
        public void GetSquare_ReturnCorrectDoubleIfRightTriangle()
        {
            var circle = new Triangle(6,8,10);
            var result = circle.GetSquare();
            Assert.IsTrue(result.CompareTo(24) == 0);
        }

        [TestMethod]
        public void GetSquare_ReturnExceptionIfSidesNegative()
        {
            Assert.ThrowsException<ApplicationException>(() => new Triangle(-1,-1,-1));          
        }

        [TestMethod]
        public void GetSquare_ReturnExceptionIfTriangleSidesIncorrect()
        {
            Assert.ThrowsException<ApplicationException>(() => new Triangle(1, 2, 3));
        }

        [TestMethod]
        public void GetSquare_ReturnExceptionGivenValueOf0()
        {
            Assert.ThrowsException<ApplicationException>(() => new Triangle(0, 3, 3));
        }

        [TestMethod]
        public void GetSquare_ReturnTrueIfRightTriangle()
        {
            var circle = new Triangle(6, 8, 10);
            var result = circle.IsRightAngle();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetSquare_ReturnFalseIfNotRightTriangle()
        {
            var circle = new Triangle(6, 7, 10);
            var result = circle.IsRightAngle();
            Assert.IsFalse(result);
        }

    }
}
