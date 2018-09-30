using System.Collections.Generic;
using System.Linq;
using DesigningTestableApplications.Interfaces.Repositories;
using DesigningTestableApplications.Model;
using DesigningTestableApplications.Repositories;

namespace DesigningTestableApplications.Services
{
    public class OrdersService
    {
        private readonly IOrdersRepository ordersRepository;
        private readonly IProductsRepository productsRepository;
        private readonly ICustomersRepository customersRepository;

        public OrdersService()
        {
            this.ordersRepository = new OrdersRepository();
            this.productsRepository = new ProductsRepository();
            this.customersRepository = new CustomersRepository();
        }

        public OrdersService(IOrdersRepository ordersRepository, IProductsRepository productsRepository, ICustomersRepository customersRepository)
        {
            this.ordersRepository = ordersRepository;
            this.productsRepository = productsRepository;
            this.customersRepository = customersRepository;
        }

        public IList<Order> GetOrders()
        {
            return this.ordersRepository.GetOrders();
        }

        public void AddOrder(Order order)
        {
            order.Customer = this.customersRepository.GetById(order.CustomerId);
            order.OrderItems.ToList().ForEach(x => x.Product = this.productsRepository.GetById(x.ProductId));

            //Si la suma de los ítems es mayor a 20.000, se le agregará un ítem de regalo
            if (order.OrderItems.Sum(x => x.Quantity * (x.Product.Prices.First(y => y.Currency.Id == order.CurrencyId)).Amount) > 20000)
            {
                var gift = productsRepository.GetGift();
                order.OrderItems.Add(new OrderItem
                {
                    Product = gift,
                    ProductId = gift.Id,
                    Quantity = 1
                });
            }

            this.ordersRepository.AddOrder(order);
        }
    }
}
