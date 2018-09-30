using System.Collections.Generic;
using DesigningTestableApplications.Model;

namespace DesigningTestableApplications.Interfaces.Repositories
{
    public interface IOrdersRepository
    {
        IList<Order> GetOrders();
        void AddOrder(Order order);
    }
}
