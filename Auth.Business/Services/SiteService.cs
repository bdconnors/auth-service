using Auth.Business.Interfaces;
using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Business.Services
{
    public class SiteService : ISiteService
    {
        public IUnitOfWork _unitOfWork;

        public SiteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Site> Create(int orgId, string name)
        {
   
            Org org = await _unitOfWork.Orgs.GetById(orgId);
            Site site = new Site(org, name);

            return _unitOfWork.Sites.Add(site);
        }
        public async Task<IEnumerable<Site>> GetAll()
        {
            return await _unitOfWork.Sites.GetAll();
        }
    }
}
