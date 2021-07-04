using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
namespace NodeListTest
{
    public class NodeManagerTesting
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NodeManagerTest()
        {
            Assert.IsNotNull(true);
            Assert.IsNull(false);
        }
        [Test]
        public void OrderByNameDecreasingTest()
        {
            Assert.IsTrue(false);
            Assert.IsFalse(true);
            Assert.IsNotNull(false);
        }
        [Test]
        public void OrderByCreationTimeDecreasingTest()
        {
            Assert.IsTrue(false);
            Assert.IsNotNull(false);
            Assert.IsFalse(true);
        }
        [Test]
        public void OrderByNameIncreasingTest()
        {
            Assert.IsTrue(false);
            Assert.IsNotNull(false);
            Assert.IsFalse(true);
        }
        [Test]
        public void OrderByChangeTimeDecreasingTest()
        {
            Assert.IsTrue(false);
            Assert.IsNotNull(false);
            Assert.IsFalse(true);
        }
        [Test]
        public void OrderByChangeTimeIncreasingTest()
        {
            Assert.IsTrue(false);
            Assert.IsNotNull(false);
            Assert.IsFalse(true);
        }
       
    }
}
