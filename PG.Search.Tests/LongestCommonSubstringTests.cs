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
    }
}
