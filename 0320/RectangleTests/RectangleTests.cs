using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void RectangleConstructionTest1()
        {
            // Arrange
            Rectangle r = new Rectangle(2, 7, 2, 1);
            // Act
            string? actual = r.ToString();
            string? expected = "[(2, 7), Width = 2, Height = 1]";
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RectangleConstructionTest2()
        {
            // Arrange
            Rectangle r = new Rectangle(new Point(2, 6), new Point(4, 7));
            // Act
            string? actual = r.ToString();
            string? expected = "[(2, 7), Width = 2, Height = 1]";
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PerimeterTest()
        {
            // Arrange
            Rectangle r = new Rectangle(new Point(2, 6), new Point(4, 7));
            // Act
            int expected = 6;
            int actual = r.Perimeter();
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AreaTest()
        {
            // Arrange
            Rectangle r = new Rectangle(new Point(2, 6), new Point(4, 7));
            // Act
            int expected = 2;
            int actual = r.Area();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IntersectsWithPositiveTest()
        {
            // Arrange
            Rectangle r1 = new Rectangle(new Point(2, 7), new Point(4, 5));
            Rectangle r2 = new Rectangle(new Point(3, 6), new Point(10, 1));

            // Act
            bool expected = true;
            bool actual = r1.IntersectsWith(r2);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IntersectsWithNegativeTest()
        {
            // Arrange
            Rectangle r1 = new Rectangle(new Point(1, 3), new Point(4, 5));
            Rectangle r2 = new Rectangle(new Point(5, 4), new Point(7, 9));

            // Act
            bool expected = false;
            bool actual = r1.IntersectsWith(r2);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}