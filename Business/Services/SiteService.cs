using Auth.Business.Interfaces;
using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Business.Services
{
    public class SiteService : IService<Site>, ISiteService
    {
        public IUnitOfWork _unitOfWork;

        public SiteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Site Create(Site entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(Site entity)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Site>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<Site> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(Site entity)
        {
            throw new NotImplementedException();
        }
    }
}
