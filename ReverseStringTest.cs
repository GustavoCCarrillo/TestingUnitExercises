using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseStringTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("elppA", ReverseString.Program.ReverseString("Apple"));
        }
    }
}
