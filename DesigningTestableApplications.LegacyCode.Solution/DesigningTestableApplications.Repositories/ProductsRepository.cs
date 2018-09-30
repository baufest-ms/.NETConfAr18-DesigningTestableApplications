using System.Linq;
using DesigningTestableApplications.Interfaces.Repositories;
using DesigningTestableApplications.Model;

namespace DesigningTestableApplications.Repositories
{
    public class ProductsRepository : Repository, IProductsRepository
    {
        public Product GetGift()
        {
            return Context.Products.FirstOrDefault(x => x.Name == "Pen Drive");
        }

        public Product GetById(int id)
        {
            return Context.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}
