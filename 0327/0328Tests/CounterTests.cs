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
    public class CounterTests
    {
        [TestMethod()]
        public void TickTest()
        {
            // Arrange
            Counter c = new Counter();

            // Act
            c.Tick();
            c.Tick();
            c.Tick();

            // Assert
            int expected = 3;
            int actual = c.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}