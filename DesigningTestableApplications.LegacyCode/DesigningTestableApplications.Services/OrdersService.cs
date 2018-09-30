using System.Collections.Generic;
using System.Linq;
using DesigningTestableApplications.Model;
using DesigningTestableApplications.Repositories;

namespace DesigningTestableApplications.Services
{
    public class OrdersService
    {
        public IList<Order> GetOrders()
        {
            var repository = new OrdersRepository();
            return repository.GetOrders();
        }

        public void AddOrder(Order order)
        {
            var ordersRepository = new OrdersRepository();
            var productsRepository = new ProductsRepository();
            var customersRepository = new CustomersRepository();

            order.Customer = customersRepository.GetById(order.CustomerId);
            order.OrderItems.ToList().ForEach(x => x.Product = productsRepository.GetById(x.ProductId));

            ordersRepository.AddOrder(order);
        }
    }
}
