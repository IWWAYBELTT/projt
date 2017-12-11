using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Monapplication.Tests
{
      [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            Calculator sut = new Calculator();
            int expectedResult = sut.Add(7, 8);
            NUnit.Framework.Assert.AreEqual(15, expectedResult);
           
        }

        [Test]
        public void ShouldMulTwoNumbers()
        {
            Calculator sut = new Calculator(); 
            int expectedResult = sut.Mul(7, 8);
            NUnit.Framework.Assert.AreEqual(56, expectedResult);
          
        }

    } }


