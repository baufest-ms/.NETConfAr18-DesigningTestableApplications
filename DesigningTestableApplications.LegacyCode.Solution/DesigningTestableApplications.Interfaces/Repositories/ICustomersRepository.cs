using DesigningTestableApplications.Model;

namespace DesigningTestableApplications.Interfaces.Repositories
{
    public interface ICustomersRepository
    {
        Customer GetById(int id);
    }
}
