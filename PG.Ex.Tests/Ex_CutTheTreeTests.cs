using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Ex.Tests
{
    [TestClass]
    public class Ex_CutTheTreeTests
    {
        [TestMethod]
        public void Test_1()
        {
            var buffer = new string[] 
            {
                "6",
                "100 200 100 500 100 600",
                "1 2",
                "2 3",
                "2 5",
                "4 5",
                "5 6"
            };

            var result = CutTheTree.Test(buffer);
            Assert.AreEqual(400, result);
        }
    }
}
