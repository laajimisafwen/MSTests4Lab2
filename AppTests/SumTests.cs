using AppToBeTested;

namespace AppTests
{
    [TestClass]
    public class SumTests
    {
        [TestMethod]
        public void TestSum_PositiveNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sum(5, 10);
           // Assert.AreEqual(15, result, "The result should be 15");
            Assert.AreEqual(25, result, "The result should be 25");
        }
        [TestMethod]
        public void TestSum_NegativeAndPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sum(-3, 7);
            Assert.AreEqual(4, result, "The result should be 4");
        }
        [TestMethod]
        public void TestSum_NegativeNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sum(-6, -21);
            Assert.AreEqual(-27, result, "The result should be -27");
        }
    }
}