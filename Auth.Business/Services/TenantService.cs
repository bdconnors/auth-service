using Auth.Business.Interfaces;
using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Business.Services
{
    public class TenantService : ITenantService
    {
        public IUnitOfWork _unitOfWork;

        public TenantService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Tenant Create(string name)
        {
            Tenant tenant = new Tenant(name);

            return _unitOfWork.Tenants.Add(tenant);
        }
        public async Task<IEnumerable<Tenant>> GetAll()
        {
            return await _unitOfWork.Tenants.GetAll();
        }
    }
}
