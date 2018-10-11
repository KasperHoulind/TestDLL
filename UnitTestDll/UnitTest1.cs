
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDLL;

namespace UnitTestDll
{
    [TestClass]
    public class UnitTest1
    {
        
        private const double Oz = 28.3495;
        private const double Grams = 0.0353;
        [TestMethod]
        public void TestMethod1()
        {
            Convert1Dll c = new Convert1Dll();
            double var = 10;

            double actual = c.OzToGrams(var);
                
            double expected = var * Oz;

            Assert.AreEqual(actual,expected,0.00000001);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Convert1Dll c = new Convert1Dll();
            double var = 10;

            double actual = c.GramsToOz(var);

            double expected = var * Grams;

            Assert.AreEqual(actual, expected, 0.00000001);

        }
    }
}

