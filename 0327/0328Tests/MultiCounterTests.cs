using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0328;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0328.Tests
{
    [TestClass()]
    public class MultiCounterTests
    {
        [TestMethod()]
        public void TickTest()
        {
            // Arrange
            MultiCounter mc = new MultiCounter(3, 10);
            // Act
            for (int i = 0; i < 267; i++)
            {
                mc.Tick();
            }
            // Assert
            string expected = "267";
            string actual = mc.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TickTest1()
        {
            // Arrange
            MultiCounter mc = new MultiCounter(3, 10);
            // Act
            for (int i = 0; i < 42; i++)
            {
                mc.Tick();
            }
            // Assert
            string expected = "042";
            string actual = mc.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}