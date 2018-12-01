using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment2Tests
    {
        private Assignment2 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Assignment2();
        }

        [Test]
        [TestCase(4, new int[] { 0,1, 2, 3, 4 }, TestName = "Положительные числа")]
        [TestCase(4, new int[] { -1, -2, -3, -4 }, TestName = "Отрицательные числа")]
        public void PrimeNumbers_Length(int qwe, int[] masi)
        {
            var result = _math.GetMinus(4);
            Assert.That(result, Is.EquivalentTo(masi));
        }
    }
}
