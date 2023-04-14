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
            Org org = new Org();
            org.Name = name;
            return _unitOfWork.Orgs.Add(org);
        }
        public async Task<IEnumerable<Org>> GetAll()
        {
            return await _unitOfWork.Orgs.GetAll();
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
