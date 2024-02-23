using NUnit.Framework;
using PracticEx.Figures;
using System;

namespace Tests
{
    [TestFixture]
    class TriangleTests
    {
        [Test]
        public void GetSquare_Result6()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            double result = triangle.GetSquare();
            if (Math.Abs(result - 6) < 0.001)
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void GetSquare_Result10()
        {
            Triangle triangle = new Triangle(5, 4, 6);
            double result = triangle.GetSquare();
            if (Math.Abs(result - 9.921) < 0.001)
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void IsRectangular_ResultTrue()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.IsTrue(triangle.IsRectangular());
        }

        [Test]
        public void IsRectangular_ResultFalse()
        {
            Triangle triangle = new Triangle(2, 4, 3);
            Assert.IsFalse(triangle.IsRectangular());
        }

        [Test]
        public void InitTriangle1_ResultException()
        {
            Assert.Throws<ArgumentException>(()=> new Triangle(-1, 5, 4));
        }

        [Test]
        public void InitTriangle2_ResultException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 99, 4));
        }

        [Test]
        public void InitTriangle3_ResultException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(new double[] { 1,5,4,3}));
        }
    }
}
