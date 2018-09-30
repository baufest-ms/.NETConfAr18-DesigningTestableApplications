using DesigningTestableApplications.Model;

namespace DesigningTestableApplications.Interfaces.Repositories
{
    public interface IProductsRepository
    {
        Product GetGift();
        Product GetById(int id);
    }
}
