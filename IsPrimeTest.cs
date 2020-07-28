using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsPrimeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(isPrime.IsPrime.IsPrimeNumber(2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(isPrime.IsPrime.IsPrimeNumber(5));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(isPrime.IsPrime.IsPrimeNumber(10));
        }
    }
}
