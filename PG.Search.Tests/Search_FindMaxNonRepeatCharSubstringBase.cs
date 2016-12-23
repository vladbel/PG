using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Search.Tests
{
    [TestClass]
    public abstract class Search_FindMaxNonRepeatCharSubstringBase
    {

        protected Func<string, string> _find;

        [TestMethod]
        public void Find_aa()
        {
            Assert.AreEqual("a", _find("aa"));
        }

        [TestMethod]
        public void Find_aba()
        {
            Assert.AreEqual("ab", _find("aba"));
        }

        [TestMethod]
        public void Find_abb()
        {
            Assert.AreEqual("ab", _find("abb"));
        }

        [TestMethod]
        public void Find_abca()
        {
            Assert.AreEqual("abc", _find("abca"));
        }

        [TestMethod]
        public void Find_abac()
        {
            Assert.AreEqual("bac", _find("abac"));
        }

        [TestMethod]
        public void Find_ababca()
        {
            Assert.AreEqual("abc", _find("ababca"));
        }

        [TestMethod]
        public void Find_abacba()
        {
            Assert.AreEqual("bac", _find("abacba"));
        }
    }
}
