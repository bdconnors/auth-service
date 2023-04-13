using Auth.Business.Interfaces;
using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Business.Services
{
    public class OrgService : IService<Org>, IOrgService
    {
        public IUnitOfWork _unitOfWork;

        public OrgService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Org Create(Org entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(Org entity)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Org>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<Org> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(Org entity)
        {
            throw new NotImplementedException();
        }
    }
}
