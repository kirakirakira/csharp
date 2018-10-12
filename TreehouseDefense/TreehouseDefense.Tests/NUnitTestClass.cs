using NUnit.Framework;
using System;
using TreehouseDefense;

namespace TreehouseDefense.Tests
{
    [TestFixture()]
    public class PointTests
    {
        [Test()]
        public void PointTest()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);
            Assert.Equals(x, point.X);
            Assert.Equals(y, point.Y);
        }

        [Test()]
        public void DistanceToTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}