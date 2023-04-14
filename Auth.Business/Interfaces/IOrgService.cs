using Auth.Data.Models;

namespace Auth.Business.Interfaces
{
    public interface IOrgService
    {
        Org Create(string name);
        Task<IEnumerable<Org>> GetAll();
    }
}