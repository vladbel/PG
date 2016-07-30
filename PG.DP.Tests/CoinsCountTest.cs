using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PG.DP.Tests
{
    [TestClass]
    public class CoinsCountTest
    {
        [TestMethod]
        public void Count_1()
        {
            var coins = new Dictionary<int, int>();
            coins.Add(1, 1);
            coins.Add(5, 0);

            Assert.AreEqual(1, Coins.CountCoins(coins));
        }

        [TestMethod]
        public void Count_2()
        {
            var coins = new Dictionary<int, int>();
            coins.Add(1, 1);
            coins.Add(5, 1);

            Assert.AreEqual(2, Coins.CountCoins(coins));
        }

        [TestMethod]
        public void Count_5()
        {
            var coins = new Dictionary<int, int>();
            coins.Add(1, 1);
            coins.Add(5, 1);
            coins.Add(10, 2);
            coins.Add(25, 1);

            Assert.AreEqual(5, Coins.CountCoins(coins));
        }
    }
}
