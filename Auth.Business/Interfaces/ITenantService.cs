using Auth.Data.Models;

namespace Auth.Business.Interfaces
{
    public interface ITenantService
    {
        Tenant Add(string name);
        Task<IEnumerable<Tenant>> GetAll();
        Task<Tenant> Get(int id);
    }
}