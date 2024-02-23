using NUnit.Framework;
using PracticEx.Figures;
using System;

namespace Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void GetSquare_Result78()
        {
            Circle circle = new Circle(5);
            double result = circle.GetSquare();

            if (Math.Abs(result - 78.539d) < 0.001)
                Assert.Pass();
            else
                Assert.Fail();
        }
        [Test]
        public void GetSquare_Result314()
        {
            Circle circle = new Circle(10);
            double result = circle.GetSquare();

            if (Math.Abs(result - 314.159) < 0.001)
                Assert.Pass();
            else
                Assert.Fail();
        }
        [Test]
        public void InitCircle_ResultException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}