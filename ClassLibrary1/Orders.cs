using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.DP
{
    // from Amazon interview
    public class Orders
    {
        public static Dictionary<string, int> DepartmentsWithIsolatedCustomerCount ( List<Order> orders)
        {
            var departments = new Dictionary<string, int>();
            var customers = new Dictionary<string, string>();
            var notIsolated = "n/i";

            foreach (Order order in orders)
            {
                if (!customers.ContainsKey(order.CustomrId))
                {
                    customers.Add(order.CustomrId, order.DepartmentId);
                    // This is new costomer, potentially isolated
                    if (departments.ContainsKey(order.DepartmentId))
                    {
                        departments[order.DepartmentId]++;
                    }
                    else
                    {
                        departments.Add(order.DepartmentId, 1);
                    }
                }
                else if (customers[order.CustomrId] != order.DepartmentId
                    && customers[order.CustomrId] != notIsolated)
                {
                    // this is not isolated customer
                    departments[customers[order.CustomrId]]--;
                    customers[order.CustomrId] = notIsolated;
                }
            }

            return departments;
        }
    }

    public class Order
    {
        public string CustomrId { get; set; }
        public string DepartmentId { get; set; }
    }
}
