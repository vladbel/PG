using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Search.Tests
{
    [TestClass]
    public class LongestCommonSubstringTests
    {
        [TestMethod]
        public void ShallFind_abc()
        {
            var results = LongestCommonSubstring.Find("1abc2", "3abc4");
            Assert.AreEqual("abc", results[0]);
        }

        [TestMethod]
        public void ShallFind_abc_02()
        {
            var results = LongestCommonSubstring.Find("12abc21", "34abc43");
            Assert.AreEqual("abc", results[0]);
        }

        [TestMethod]
        public void ShallFind_abc_AtTheBeginning()
        {
            var results = LongestCommonSubstring.Find("abc21", "12abc43");
            Assert.AreEqual("abc", results[0]);

            results = LongestCommonSubstring.Find("21abc21", "abc43");
            Assert.AreEqual("abc", results[0]);

            results = LongestCommonSubstring.Find("abc21", "abc43");
            Assert.AreEqual("abc", results[0]);
        }

        [TestMethod]
        public void ShallFind_ba_and_ab()
        {
            var results = LongestCommonSubstring.Find("aba", "bab");
            Assert.AreEqual("ab", results[0]);
            Assert.AreEqual("ba", results[1]);

            results = LongestCommonSubstring.Find("bab", "aba");
            Assert.AreEqual("ba", results[0]);
            Assert.AreEqual("ab", results[1]);
        }

        [TestMethod]
        public void ShallFind_aba_and_bab()
        {
            var results = LongestCommonSubstring.Find("abab", "baba");
            Assert.AreEqual("aba", results[0]);
            Assert.AreEqual("bab", results[1]);

            results = LongestCommonSubstring.Find("baba", "abab");
            Assert.AreEqual("bab", results[0]);
            Assert.AreEqual("aba", results[1]);
        }


    }
}
