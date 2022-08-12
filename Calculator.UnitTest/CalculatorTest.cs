using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP;

namespace UnitTest
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calculator;
        [TestInitialize]
        public void Initialize()
        {
            calculator = new Calculator();
        }
        [TestMethod]
        public void FirstTest()
        {
            
            Assert.IsNotNull(calculator.Add(1,2));
            Assert.AreEqual(2, calculator.Add(1, 1));
        }
    }
}
