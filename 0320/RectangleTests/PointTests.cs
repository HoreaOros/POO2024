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
    public class PointTests
    {
        [TestMethod()]
        public void ToStringTestOrigin()
        {
            // Arrange
            Point p = new Point();
            string expected = "(0, 0)";


            // Act 
            string actual = p.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTestNotZero()
        {
            // Arrange
            Point p = new Point(3, 4);
            string expected = "(3, 4)";


            // Act 
            string actual = p.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }      
    }
}