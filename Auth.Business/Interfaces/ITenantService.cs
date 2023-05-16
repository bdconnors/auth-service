using Auth.Data.Models;

namespace Auth.Business.Interfaces
{
    public interface ITenantService
    {
        Tenant Create(string name);
        Task<IEnumerable<Tenant>> GetAll();
    }
}