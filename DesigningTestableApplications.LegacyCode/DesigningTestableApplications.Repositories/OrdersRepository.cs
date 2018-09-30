using System.Collections.Generic;
using System.Linq;
using DesigningTestableApplications.Model;

namespace DesigningTestableApplications.Repositories
{
    public class OrdersRepository : Repository
    {
        public IList<Order> GetOrders()
        {
            return Context.Orders.ToList();
        }

        public void AddOrder(Order order)
        {
            Context.Orders.Add(order);
            order.Id = Context.Orders.Max(x => x.Id) + 1;
        }
    }
}
