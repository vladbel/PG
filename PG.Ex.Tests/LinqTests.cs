using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;


namespace PG.Ex.Tests
{
    [TestClass]
    public class LinqTests
    {
        private class Order
        {
            public string CustomerId { get; set; }
            public string DepartmentId { get; set; }
        }

        private List<Order> _orders;

        [TestInitialize]
        public void Init()
        {
            _orders = new List<Order>()
            {
                new Order()
                {
                    CustomerId = "c1",
                    DepartmentId = "d1"
                },
                new Order()
                {
                    CustomerId = "c2",
                    DepartmentId = "d1"
                },
                new Order()
                {
                    CustomerId = "c2",
                    DepartmentId = "d2"
                },
                new Order()
                {
                    CustomerId = "c2",
                    DepartmentId = "d3"
                }

            };
        }

        [TestMethod]
        public void GetSpecificCustomer()
        {
            var order = _orders.Where(o => o.CustomerId == "c1").FirstOrDefault();
            Assert.AreEqual("c1", order.CustomerId);
        }

        [TestMethod]
        public void GroupByDepartment()
        {
            // select CustomerId of customers who made purchises in departments, which has exactly two orders.
            var r = _orders.GroupBy(o => o.DepartmentId)
                .Where( g => g.Count() == 2)
                .SelectMany( g => g.Select(e=>e.CustomerId)).ToList();
            
        }

        [TestMethod]
        public void SelectDistinct()
        {
            var array = new string[] { "1", "1"};

            var result = array.GroupBy(id => id).Select(gr => gr.First()).ToArray();
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual("1", result[0]);
        }

        [TestMethod]
        public void SelectDistinct2()
        {
            var array = new string[] { "1", "1", "1" };

            var result = array.GroupBy(id => id).Select(gr => gr.First()).ToArray();
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual("1", result[0]);
        }

        [TestMethod]
        public void SelectDistinct3()
        {
            var array = new string[] {};

            var result = array.GroupBy(id => id).Select(gr => gr.First()).ToArray();
            Assert.AreEqual(0, result.Length);

        }

        [TestMethod]
        public void SelectDistinct4()
        {
            var array = new string[] { "1", "1", "1", "2", "2" };

            var result = array.GroupBy(id => id).Select(gr => gr.First()).ToArray();
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("2", result[1]);
        }
    }
}
