using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PG.DP.Tests
{
    [TestClass]
    public class OrdersTest
    {
        [TestMethod]
        public void DepartmentWithIsolatedCustomerCountTest_1()
        {
            var orders = new List<Order>() {
                new Order() { CustomrId = "John", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "John", DepartmentId = "Food" },
            };

            var result = Orders.DepartmentsWithIsolatedCustomerCount(orders);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result["Books"]);
        }

        [TestMethod]
        public void DepartmentWithIsolatedCustomerCountTest_2()
        {
            var orders = new List<Order>() {
                new Order() { CustomrId = "John", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "John", DepartmentId = "Food" },
                new Order() { CustomrId = "Sam", DepartmentId = "Food" }
            };

            var result = Orders.DepartmentsWithIsolatedCustomerCount(orders);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result["Books"]);
            Assert.AreEqual(1, result["Food"]);
        }

        [TestMethod]
        public void DepartmentWithIsolatedCustomerCountTest_3()
        {
            var orders = new List<Order>() {
                new Order() { CustomrId = "John", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "John", DepartmentId = "Food" },
                new Order() { CustomrId = "Sam", DepartmentId = "Food" }
            };

            var result = Orders.DepartmentsWithIsolatedCustomerCount(orders);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result["Books"]);
            Assert.AreEqual(1, result["Food"]);
        }

        [TestMethod]
        public void DepartmentWithIsolatedCustomerCountTest_4()
        {
            var orders = new List<Order>() {
                new Order() { CustomrId = "John", DepartmentId = "Books" },
                new Order() { CustomrId = "John", DepartmentId = "Pets" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "John", DepartmentId = "Food" },
                new Order() { CustomrId = "Sam", DepartmentId = "Food" },
                new Order() { CustomrId = "Piter", DepartmentId = "Food" }
            };

            var result = Orders.DepartmentsWithIsolatedCustomerCount(orders);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result["Books"]);
            Assert.AreEqual(2, result["Food"]);
        }

        [TestMethod]
        public void DepartmentWithIsolatedCustomerCountTest_5()
        {
            var orders = new List<Order>() {
                new Order() { CustomrId = "John", DepartmentId = "Books" },
                new Order() { CustomrId = "John", DepartmentId = "Pets" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "Alice", DepartmentId = "Books" },
                new Order() { CustomrId = "John", DepartmentId = "Food" },
                new Order() { CustomrId = "Sam", DepartmentId = "Food" },
                new Order() { CustomrId = "Piter", DepartmentId = "Food" },
                new Order() { CustomrId = "Piter", DepartmentId = "Pets" }
            };

            var result = Orders.DepartmentsWithIsolatedCustomerCount(orders);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result["Books"]);
            Assert.AreEqual(1, result["Food"]);
        }
    }
}
