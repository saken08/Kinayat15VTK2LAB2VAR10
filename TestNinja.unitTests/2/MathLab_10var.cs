using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class MathLab_10var
    {
        /*
            я добавил скобки чтобы условия решения было правильным (чтобы сумма а+b разделилась на 4)
            if ((a + b) % 4 == 0)
                return true;
            if ((a + b) % 4 != 0)
                return false;
            return true;
            
             */
        [Test]
        public void IsSumDivisibleBy4_8and12_Return20()
        {
            //Arrange 
            int a = 8, b = 12;
            Math_Lab1 c = new Math_Lab1();

            //Act  
            var result = c.IsSumDivisibleBy4(a, b);

            //Assert 
            Assert.IsTrue(result);
        }

        [Test]
        public void IsSumDivisibleBy4_16and5_Return21()
        {
            //Arrange 
            int a = 16, b = 5;
            Math_Lab1 c = new Math_Lab1();

            //Act  
            var result = c.IsSumDivisibleBy4(a, b);

            //Assert 
            Assert.IsTrue(result);
        }
    }
}