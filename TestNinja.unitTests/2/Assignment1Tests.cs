using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment1Tests
    {
        private Assignment1 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Assignment1();
        }

        [Test]
 
        [TestCase("Нынешний год 2018")]//правильный
        [TestCase("Нынешний год 2017")]//неправильный
        public void DoesContainWord(string a)
        {
            string b;
            var result = _math.DoesContainWord(a);
            b = DateTime.Now.Year.ToString();       //будет брать дату установленной в компьютере
            Assert.That(result, Does.EndWith(b)); 
        }
    }
}
