using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.DP.Tests
{
    [TestClass]
    public class CoinsChangeRecurciveTests
    {
        [TestMethod]
        public void Change_US_1()
        {
            var denominations = new int[] { 1, 5, 10, 25};
            var result = Coins.Change_R(1, denominations, denominations.Length - 1);
            Assert.AreEqual(1, Coins.CountCoins(result));
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void Change_US_3()
        {
            var denominations = new int[] { 1, 5, 10 , 25};
            var result = Coins.Change_R(3, denominations, denominations.Length - 1);
            Assert.AreEqual(3, Coins.CountCoins(result));
            Assert.AreEqual(3, result[1]);
        }

        [TestMethod]
        public void Change_US_5()
        {
            var denominations = new int[] { 1, 5, 10, 25 };
            var result = Coins.Change_R(5, denominations, denominations.Length - 1);
            Assert.AreEqual(1, Coins.CountCoins(result));
            Assert.AreEqual(1, result[5]);
        }

        [TestMethod]
        public void Change_US_6()
        {
            var denominations = new int[] { 1, 5, 10, 25 };
            var result = Coins.Change_R(6, denominations, denominations.Length - 1);
            Assert.AreEqual(2, Coins.CountCoins(result));
            Assert.AreEqual(1, result[5]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void Change_USSR_2()
        {
            var denominations = new int[] { 1, 2, 3, 5, 10, 15 };
            var result = Coins.Change_R(2, denominations, denominations.Length - 1);
            Assert.AreEqual(1, Coins.CountCoins(result));
            Assert.AreEqual(1, result[2]);
        }

        [TestMethod]
        public void Change_USSR_3()
        {
            var denominations = new int[] { 1, 2, 3, 5, 10, 15 };
            var result = Coins.Change_R(3, denominations, denominations.Length - 1);
            Assert.AreEqual(1, Coins.CountCoins(result));
            Assert.AreEqual(1, result[3]);
        }

        [TestMethod]
        public void Change_USSR_4()
        {
            var denominations = new int[] { 1, 2, 3, 5, 10, 15 };
            var result = Coins.Change_R(4, denominations, denominations.Length - 1);
            Assert.AreEqual(2, Coins.CountCoins(result));
        }

        [TestMethod]
        public void Change_USSR_7()
        {
            var denominations = new int[] { 1, 2, 3, 5, 10, 15 };
            var result = Coins.Change_R(7, denominations, denominations.Length - 1);
            Assert.AreEqual(2, Coins.CountCoins(result));
            Assert.AreEqual(1, result[2]);
            Assert.AreEqual(1, result[5]);
        }

        [TestMethod]
        public void Change_USSR_8()
        {
            var denominations = new int[] { 1, 2, 3, 5, 10, 15 };
            var result = Coins.Change_R(8, denominations, denominations.Length - 1);
            Assert.AreEqual(2, Coins.CountCoins(result));
            Assert.AreEqual(1, result[3]);
            Assert.AreEqual(1, result[5]);
        }

        [TestMethod]
        public void Change_USSR_9()
        {
            var denominations = new int[] { 1, 2, 3, 5, 10, 15 };
            var result = Coins.Change_R(9, denominations, denominations.Length - 1);
            Assert.AreEqual(3, Coins.CountCoins(result));
        }

        [TestMethod]
        public void Change_USSR_12()
        {
            var denominations = new int[] { 1, 2, 3, 5, 10, 15 };
            var result = Coins.Change_R(12, denominations, denominations.Length - 1);
            Assert.AreEqual(2, Coins.CountCoins(result));
        }

        [TestMethod]
        public void Change_USSR_17()
        {
            var denominations = new int[] { 1, 2, 3, 5, 10, 15 };
            var result = Coins.Change_R(17, denominations, denominations.Length - 1);
            Assert.AreEqual(2, Coins.CountCoins(result));
        }
    }
}
