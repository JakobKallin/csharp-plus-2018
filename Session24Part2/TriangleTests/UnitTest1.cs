using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Session24Part2;

namespace TriangleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NegativeSide()
        {
            // Arrange
            double a = -1;
            double b = 2;
            double c = 2;

            // Act
            bool result = Triangle.IsIsosceles(a, b, c);

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
