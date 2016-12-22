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
        public void Find_abca()
        {
            Assert.AreEqual("abc", _find("abca"));
        }
    }
}
