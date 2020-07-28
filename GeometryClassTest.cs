using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryClassTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5.0, GeometryClass.Triangle.AreaOfTriangle(2.0, 5.0));
            Assert.AreEqual(5.0, GeometryClass.Triangle.AreaOfTriangle(5.0, 2.0));
        }

        [TestMethod]
        public void HypTest()
        {
            Assert.AreEqual(5.0, GeometryClass.Triangle.Hypoteneuse(3.0, 4.0));
            Assert.AreEqual(5.0, GeometryClass.Triangle.Hypoteneuse(4.0, 3.0));
        }
    }
}
