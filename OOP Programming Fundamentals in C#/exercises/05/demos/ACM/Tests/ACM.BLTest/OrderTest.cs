using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Tests
{
    [TestClass()]
    public class OrderTest
    {
        [TestMethod()]
        public void ValidateTest()
        {
            // arrange
            var order = new Order(1);
            order.OrderDate = DateTimeOffset.Now;

            // act
            var actual = order.Validate();
            var expected = true;

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}