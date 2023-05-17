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
            try
            {
                Tenant tenant = new Tenant(name);
                tenant = _unitOfWork.Tenants.Add(tenant);
                _unitOfWork.Tenants.Save();
                return tenant;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Task<Tenant> Get(int id)
        {
            return _unitOfWork.Tenants.GetById(id);
        }

        public async Task<IEnumerable<Tenant>> GetAll()
        {
            return await _unitOfWork.Tenants.GetAll();
        }
    }
}
