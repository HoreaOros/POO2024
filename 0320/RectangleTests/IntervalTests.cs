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
    public class IntervalTests
    {
        [TestMethod()]
        public void IntervalTest()
        {
            // arrange
            Interval t1 = new Interval(1, 2);
            Interval t2 = new Interval(2, 1);

            string expected = "(1, 2)";
            
            // act 
            string? actual1 = t1.ToString();
            string? actual2 = t2.ToString();
            
            // assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EqualsTestEqual()
        {
            // arrange
            Interval t1 = new Interval(1, 2);
            Interval t2 = new Interval(3, 4);
            int expected = 0;

            // act
            int actual = t1.CompareTo(t2);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void EqualsTestLessThan()
        {
            // arrange
            Interval t1 = new Interval(1, 2);
            Interval t2 = new Interval(3, 5);

            // act
            int actual = t1.CompareTo(t2);

            // assert
            Assert.IsTrue(actual < 0);
        }
        [TestMethod()]
        public void IntersectsWithTest1()
        {
            // arrange
            Interval t1 = new Interval(1, 5);
            Interval t2 = new Interval(3, 6);
            bool expected = true;

            // act
            bool actual = t1.IntersectsWith(t2);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}