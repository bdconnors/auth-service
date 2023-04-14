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
        public Site Create(int orgId, string name)
        {
            Site site = new Site()
            {
                Name = name,
                Org = new Org()
                {
                    Id = orgId,
                },
                Roles = _unitOfWork.Roles.GetDefaultRoles().ToList(),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            return _unitOfWork.Sites.Add(site);

        }
        public async Task<IEnumerable<Site>> GetAll()
        {
            return await _unitOfWork.Sites.GetAll();
        }


        /** public async Task<Org> GetById(int id)
        {
            return await _unitOfWork.Orgs.GetById(id);
        }
        public void Update(Org entity)
        {
            _unitOfWork.Orgs.Update(entity);  
        }
        public void Delete(Org entity)
        {
            _unitOfWork.Orgs.Delete(entity);   
        }**/
    }
}
