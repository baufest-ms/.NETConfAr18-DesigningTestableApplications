using System.Collections.Generic;
using System.Linq;
using DesigningTestableApplications.Interfaces.Repositories;
using DesigningTestableApplications.Model;
using DesigningTestableApplications.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesigningTestableApplications.UnitTests
{
    [TestClass]
    public class OrdersServiceTests
    {
        [TestMethod]
        public void AddOrderWithGift()
        {
            var ordersRepository = new Mock<IOrdersRepository>();
            var productsRepository = new Mock<IProductsRepository>();
            var customersRepository = new Mock<ICustomersRepository>();

            var customer = new Customer { Id = 11 };
            var firstProduct = new Product
            {
                Id = 456,
                Prices = new List<Price> { new Price { ProductId = 456, Currency = new Currency { Id = 1 }, Amount = 999M } }
            };
            var secondProduct = new Product
            {
                Id = 2435,
                Prices = new List<Price> { new Price { ProductId = 2435, Currency = new Currency { Id = 1 }, Amount = 10500M } }
            };
            var gift = new Product
            {
                Id = 6,
                Prices = new List<Price> { new Price { ProductId = 6, Currency = new Currency { Id = 1 }, Amount = 0 } }
            };

            customersRepository.Setup(x => x.GetById(11)).Returns(customer);

            productsRepository.Setup(x => x.GetById(456)).Returns(firstProduct);
            productsRepository.Setup(x => x.GetById(2435)).Returns(secondProduct);
            productsRepository.Setup(x => x.GetGift()).Returns(gift);

            var order = new Order
            {
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { ProductId = 456, Quantity =  1 },
                    new OrderItem { ProductId = 2435, Quantity = 2 }
                },
                CurrencyId = 1,
                CustomerId = 11
            };
            
            var ordersService = new OrdersService(ordersRepository.Object, productsRepository.Object, customersRepository.Object);

            ordersService.AddOrder(order);

            ordersRepository.Verify(
                x =>
                x.AddOrder(
                    It.Is<Order>(
                        y =>
                        y.Customer == customer && y.CurrencyId == 1 && y.OrderItems.Count == 3 &&
                        y.OrderItems.First(o => o.Product == gift).Quantity == 1)),
                Times.Once);

            customersRepository.Verify(x => x.GetById(11), Times.Once);
            productsRepository.Verify(x => x.GetById(456), Times.Once);
            productsRepository.Verify(x => x.GetById(2435), Times.Once);
            productsRepository.Verify(x => x.GetGift(), Times.Once);
        }

        [TestMethod]
        public void AddOrderWithoutGift()
        {
            var ordersRepository = new Mock<IOrdersRepository>();
            var productsRepository = new Mock<IProductsRepository>();
            var customersRepository = new Mock<ICustomersRepository>();

            var customer = new Customer { Id = 11 };
            var product = new Product
            {
                Id = 456,
                Prices = new List<Price> { new Price { ProductId = 456, Currency = new Currency { Id = 1 }, Amount = 999M } }
            };

            customersRepository.Setup(x => x.GetById(11)).Returns(customer);

            productsRepository.Setup(x => x.GetById(456)).Returns(product);

            var order = new Order
            {
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { ProductId = 456, Quantity =  1 }
                },
                CurrencyId = 1,
                CustomerId = 11
            };

            var ordersService = new OrdersService(ordersRepository.Object, productsRepository.Object, customersRepository.Object);

            ordersService.AddOrder(order);

            ordersRepository.Verify(
                x =>
                x.AddOrder(
                    It.Is<Order>(
                        y =>
                        y.Customer == customer && y.CurrencyId == 1 && y.OrderItems.Count == 1)),
                Times.Once);

            customersRepository.Verify(x => x.GetById(11), Times.Once);
            productsRepository.Verify(x => x.GetById(456), Times.Once);
        }
    }
}
