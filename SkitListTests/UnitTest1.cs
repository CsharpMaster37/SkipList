using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SkipListLib;

namespace SkitListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCountInc()
        {
            SkipList<int, int> skiplist = new SkipList<int, int>();
            skiplist.Add(1, 1);
            Assert.AreEqual(1, skiplist.Count);
            skiplist.Add(2, 1);
            Assert.AreEqual(2, skiplist.Count);
        }
        [TestMethod]
        public void TestCountDec()
        {
            SkipList<int, int> skiplist = new SkipList<int, int>();
            skiplist.Add(1, 1);
            skiplist.Add(2, 1);
            skiplist.Remove(1);
            Assert.AreEqual(1, skiplist.Count);
        }
        [TestMethod]
        public void TestAddElement()
        {
            SkipList<int, int> skiplist = new SkipList<int, int>();
            skiplist.Add(1, 1);
            skiplist.Add(6, 1);
            skiplist.Add(10, 1);
            Assert.AreEqual(true, skiplist.Contains(1));
            Assert.AreEqual(true, skiplist.Contains(6));
            Assert.AreEqual(true, skiplist.Contains(10));
            Assert.AreEqual(false, skiplist.Contains(12));
        }
        [TestMethod]
        public void TestRemoveElement()
        {
            SkipList<int, int> skiplist = new SkipList<int, int>();
            skiplist.Add(1, 1);
            skiplist.Add(6, 1);
            skiplist.Remove(6);
            Assert.AreEqual(false, skiplist.Contains(6));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddNullElement()
        {
            SkipList<string, int> skiplist = new SkipList<string, int>();
            skiplist.Add(null, 1);
        }
    }
}
