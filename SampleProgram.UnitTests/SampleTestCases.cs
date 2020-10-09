using NUnit.Framework;
using SampleProgram;

namespace SampleProgram.UnitTests
{

    [TestFixture]
    class SampleTestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add()
        {
            var sample = new SampleCode();
            Assert.AreEqual(31, sample.Add(20, 11));
        }

        [Test]
        public void Sub()
        {
            SampleCode sample = new SampleCode();
            Assert.AreEqual(10, sample.Sub(20, 11));
        }
    }
}