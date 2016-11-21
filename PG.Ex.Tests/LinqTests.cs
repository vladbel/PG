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
    }
}
