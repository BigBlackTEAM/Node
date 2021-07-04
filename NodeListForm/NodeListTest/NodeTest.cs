using NUnit.Framework;

namespace NodeListTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NodeTest()
        {
            Assert.IsNotNull(true);
            Assert.IsNull(false);

        }
        [Test]
        public void ToStringTest()
        {
            Assert.IsNotNull(true);
            Assert.IsNull(false);
            Assert.IsTrue(true);
        }
        [Test]
        public void GetHashCodeTest()
        {
            Assert.IsTrue(true);
            Assert.IsNotNull(true);
            Assert.IsNull(false);
        }
        [Test]
        public void EqualsTest()
        {
            Assert.IsTrue(true);
            Assert.IsFalse(false);
        }
        

    }
}