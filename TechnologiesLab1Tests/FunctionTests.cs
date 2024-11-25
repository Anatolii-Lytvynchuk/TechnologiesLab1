using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnologiesLab1.Tests
{
    [TestClass()]
    public class FunctionTests
    {
        [TestMethod()]
        public void CalculateTest1()
        {
            Assert.AreEqual(new Function().Calculate(5), 1.897, 0.001);
        }

        [TestMethod()]
        public void CalculateTest2()
        {
            Assert.AreEqual(new Function().Calculate(3), 1.632, 0.001);
        }
    }
}
