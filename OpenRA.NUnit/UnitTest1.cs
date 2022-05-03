using NUnit.Framework;

namespace OpenRA.NUnit
{
	[TestFixture]
	public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(TestName = "Test Code")]
        public void Test1()
        {
           // Assert.Pass();
        }
    }
}
