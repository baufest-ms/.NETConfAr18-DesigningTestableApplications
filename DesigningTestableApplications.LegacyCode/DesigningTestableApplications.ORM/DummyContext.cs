using System.Collections.Generic;
using System.Linq;
using DesigningTestableApplications.Model;

namespace DesigningTestableApplications.ORM
{
    public class DummyContext
    {
        public IList<Currency> Currencies { get; set; }

        public IList<Customer> Customers { get; set; }

        public IList<Order> Orders { get; set; }

        public IList<OrderItem> OrderItems { get; set; }

        public IList<Price> Prices { get; set; }

        public IList<Product> Products { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; }

        public DummyContext()
        {
            this.InitializeData();
        }

        private void InitializeData()
        {
            var currencyArs = new Currency { Id = 1, Code = "ARS", Description = "Argentine Peso" };
            var currencyUsd = new Currency { Id = 2, Code = "USD", Description = "US Dollar" };
            this.Currencies = new List<Currency> { currencyArs, currencyUsd };

            var productDesktop = new Product { Id = 1, Name = "Desktop Computer", Active = true };
            var productNotebook = new Product { Id = 2, Name = "Notebook Computer", Active = true };
            var productTablet = new Product { Id = 3, Name = "Tablet", Active = true };
            var productSmartphone = new Product { Id = 4, Name = "Smartphone", Active = true };
            var productSmartwatch = new Product { Id = 5, Name = "SmartWatch", Active = false };
            var productGift = new Product { Id = 6, Name = "Pen Drive", Active = true };
            this.Products = new List<Product> { productDesktop, productNotebook, productTablet, productSmartphone, productSmartwatch, productGift };

            this.Prices = new List<Price>
            {
                new Price { Id = 1, Product = productDesktop, ProductId = 1, Currency = currencyArs, CurrencyId = 1, Amount = 8999.99M },
                new Price { Id = 2, Product = productNotebook, ProductId = 2, Currency = currencyArs, CurrencyId = 1, Amount = 14799.79M },
                new Price { Id = 3, Product = productTablet, ProductId = 3, Currency = currencyArs, CurrencyId = 1, Amount = 2399.99M },
                new Price { Id = 4, Product = productSmartphone, ProductId = 4, Currency = currencyArs, CurrencyId = 1, Amount = 7999.99M },
                new Price { Id = 5, Product = productSmartwatch, ProductId = 5, Currency = currencyArs, CurrencyId = 1, Amount = 4999.99M },
                new Price { Id = 6, Product = productGift, ProductId = 6, Currency = currencyArs, CurrencyId = 1, Amount = 0 }
            };

            foreach (var product in this.Products)
            {
                product.Prices = this.Prices.Where(x => x.ProductId == product.Id).ToList();
            }

            this.Customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "jdoe@baufest.com", Address = "Roosevelt 1655", Phone = "4855-5572", Active = true },
                new Customer { Id = 2, FirstName = "Mary", LastName = "Jane", Email = "mjane@baufest.com", Address = "Calle Falsa 123", Phone = "4962-3699", Active = true }
            };

            this.Orders = new List<Order>();

            this.OrderItems = new List<OrderItem>();

            this.OrderDetails = new List<OrderDetail>();
        }
    }
}
 