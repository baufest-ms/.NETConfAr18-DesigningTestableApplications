using System.Linq;
using DesigningTestableApplications.Model;

namespace DesigningTestableApplications.Repositories
{
    public class CustomersRepository : Repository
    {
        public Customer GetById(int id)
        {
            return Context.Customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
