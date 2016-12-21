using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Search.Tests
{
    [TestClass]
    public class Search_FindMaxNonRepeatCharSubstringTests
    {
        [TestMethod]
        public void MaxRight_aba()
        {
            Assert.AreEqual("ba", MaxNonRepeatCharSubstring.FindMaxRightCrossSubstring("aba", 0,1,2));
        }

        [TestMethod]
        public void MaxRight_bba()
        {
            Assert.AreEqual("ba", MaxNonRepeatCharSubstring.FindMaxRightCrossSubstring("bba", 0, 1, 2));
        }

        [TestMethod]
        public void MaxRight_abca()
        {
            Assert.AreEqual("bca", MaxNonRepeatCharSubstring.FindMaxRightCrossSubstring("abca", 0, 1, 3));
            Assert.AreEqual("bca", MaxNonRepeatCharSubstring.FindMaxRightCrossSubstring("abca", 0, 2, 3));
        }

        [TestMethod]
        public void MaxRight_adbca()
        {
            Assert.AreEqual("dbca", MaxNonRepeatCharSubstring.FindMaxRightCrossSubstring("adbca", 0, 2, 4));
        }
    }
}
