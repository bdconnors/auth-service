using Auth.Business.Interfaces;
using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Business.Services
{
    public class OrgService : IOrgService
    {
        public IUnitOfWork _unitOfWork;

        public OrgService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Org Create(string name)
        {
            Org org = new Org(name);

            return _unitOfWork.Orgs.Add(org);
        }
        public async Task<IEnumerable<Org>> GetAll()
        {
            return await _unitOfWork.Orgs.GetAll();
        }
    }
}
