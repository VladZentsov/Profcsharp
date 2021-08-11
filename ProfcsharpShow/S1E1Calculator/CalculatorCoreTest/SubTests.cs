using CalculatorCore.Infrastructure;
using NUnit.Framework;

namespace CalculatorCoreTest
{
    public class SubTests
    {
        Sub instance;
        [SetUp]
        public void Setup() => instance = new();

        [Test]
        public void ResultTest()
        {
            double x = 1, y = 2; Assert.AreEqual(x - y, instance.Result(x, y));
            x = 1; y = -2; Assert.AreEqual(x - y, instance.Result(x, y));
            x = -1; y = -2; Assert.AreEqual(x - y, instance.Result(x, y));
            x = -1; y = 2; Assert.AreEqual(x - y, instance.Result(x, y));
            x = 1.0; y = -1.2; Assert.AreEqual(x - y, instance.Result(x, y));
        }
    }
}