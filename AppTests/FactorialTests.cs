using AppToBeTested;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void TestFactorial_PositiveInteger()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Factorial(5);
            Assert.AreEqual(120, result);
        }
        [TestMethod]
        public void TestFactorial_Zero()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Factorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestFactorial_One()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Factorial(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFactorial_NegativeInteger()
        {
            Calculator calculator = new Calculator();
            calculator.Factorial(-3);
            // Assert: Expecting ArgumentException
        }
    }
}
