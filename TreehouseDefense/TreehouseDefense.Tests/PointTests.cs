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
            Assert.AreEqual(x, point.X);
            Assert.AreEqual(y, point.Y);
        }

        [Test()]
        public void DistanceToTestWithPathagoreanTriple()
        {
            var point = new Point(3, 4);
            var target = new Point(0, 0);

            var expected = 5.0;

            var actual = target.DistanceTo(point);

            Assert.AreEqual(expected, actual, 2);
        }

        [Test()]
        public void DistanceToPointAtSamePosition()
        {
            var point = new Point(3, 4);
            var target = new Point(3, 4);

            var expected = 0.0;

            var actual = target.DistanceTo(point);

            Assert.AreEqual(expected, actual, 2);
        }

        [Test()]
        public void DoesNotEqualNull()
        {
            var target = new Point(0, 0);
            Assert.False(target.Equals(null));
        }

        [Test()]
        public void DistinctObjectsAreEqual()
        {
            var target = new Point(4, 5);
            Assert.True(target.Equals(new Point(4, 5)));
        }

        [Test()]
        public void PointsAreNotEqual()
        {
            var target = new Point(4, 5);
            Assert.False(target.Equals(new Point(4, 6)));
        }

        [Test()]
        public void SimilarPointsHaveDifferentHashCodes1()
        {
            var target = new Point(4, 5);
            Assert.AreNotEqual(new Point(5, 4).GetHashCode(), target.GetHashCode());
        }

        [Test()]
        public void SimilarPointsHaveDifferentHashCodes2()
        {
            var target = new Point(4, 5);
            Assert.AreNotEqual(new Point(4, 6).GetHashCode(), target.GetHashCode());
        }

        [Test()]
        public void EqualPointsHaveSameHashCodes()
        {
            var target = new Point(4, 5);
            Assert.AreEqual(new Point(4, 5).GetHashCode(), target.GetHashCode());
        }
    }
}