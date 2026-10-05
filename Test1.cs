using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionApp1;

namespace TestProject1
{
    [TestClass]
    public class PrimeCheckerTests
    {

        [TestMethod]
        public void IsPrime_ValidPrimeNumbers_ReturnsTrue()
        {
            var checker = new PrimeChecker();
            Assert.IsTrue(checker.IsPrime(2));
            Assert.IsTrue(checker.IsPrime(17));
        }

        [TestMethod]
        public void IsPrime_CompositeNumbers_ReturnsFalse()
        {
            var checker = new PrimeChecker();
            Assert.IsFalse(checker.IsPrime(4));
            Assert.IsFalse(checker.IsPrime(9));
        }

        [TestMethod]
        public void IsPrime_SpecialAndNegativeCases_ReturnsFalse()
        {
            var checker = new PrimeChecker();
            Assert.IsFalse(checker.IsPrime(0));
            Assert.IsFalse(checker.IsPrime(1));
            Assert.IsFalse(checker.IsPrime(-5));
        }
    }
}

