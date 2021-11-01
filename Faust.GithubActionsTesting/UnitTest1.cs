using Faust.SomeService;
using NUnit.Framework;

namespace Faust.GithubActionsTesting
{
    public class Tests
    {
        private CalculatorService CalcService = new CalculatorService();
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddingTwoNumbersTest()
        {
            int firstNumber = 2;
            int secondNumber = 2;

            int result = CalcService.addTwoNumbers(firstNumber, secondNumber);

            Assert.AreEqual(result, 4);
        }
    }
}