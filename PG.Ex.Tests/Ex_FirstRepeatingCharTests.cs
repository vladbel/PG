using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Ex.Tests
{
    [TestClass]
    public class Ex_FirstRepeatingCharTests
    {
        [TestMethod]
        public void Test_1()
        {
            var str = "abccb";
            var result = FirstRepeatingChar.GetFirstChar(str);
            Assert.AreEqual('b', result);
        }
    }
}
