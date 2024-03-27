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
    public class ModularCounterTests
    {
        [TestMethod()]
        public void TickTest()
        {
            // Arrange
            ModularCounter mc = new ModularCounter(10);
            // Act
            for (int i = 0; i < 15; i++)
            {
                mc.Tick();
            }
            // Assert
            int expected = 5;
            int actual = mc.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}