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

        [TestMethod]
        public void Find_abcabcdabc()
        {
            Assert.AreEqual("abcd", _find("abcabcdabc"));
        }

        [TestMethod]
        public void Find_abcabcd()
        {
            Assert.AreEqual("abcd", _find("abcabcd"));
        }

        [TestMethod]
        public void Find_abcdabce()
        {
            Assert.AreEqual("dabce", _find("abcdabce"));
        }

        [TestMethod]
        public void Find_abOcdeOfgh()
        {
            Assert.AreEqual("cdeOfgh", _find("abOcdeOfgh"));
        }

        [TestMethod]
        public void Find_ab_cd_efghikl_mnop_rstq()
        {
            Assert.AreEqual("efghikl_mnop", _find("ab_cd_efghikl_mnop_rstq"));
        }

        [TestMethod]
        public void Find_ab_cd_efghiklmnop__rstq()
        {
            Assert.AreEqual("cd_efghiklmnop", _find("ab_cd_efghiklmnop__rstq"));
        }

    }
}
