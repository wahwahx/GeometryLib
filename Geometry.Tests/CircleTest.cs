using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests
{
    [TestClass]
    public class CircleTest
    {

        [TestMethod]
        public void GetSquare_ReturnCorrectDoubleGivenValueOf1()
        {
            var circle = new Circle(1);
            var result = circle.GetSquare();
            Assert.IsTrue(result.CompareTo(Math.PI) == 0);
        }

        [TestMethod]
        public void GetSquare_ReturnExceptionGivenValueNegative()
        {
            Assert.ThrowsException<ApplicationException>(() => new Circle(-3));          
        }

        [TestMethod]
        public void GetSquare_ReturnExceptionGivenValueOf0()
        {
            Assert.ThrowsException<ApplicationException>(() => new Circle(0));
        }
    }
}
