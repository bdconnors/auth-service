﻿using Auth.Business.Interfaces;
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
        public async Task<IEnumerable<Org>> GetAll()
        {
            return await _unitOfWork.Orgs.GetAll();
        }
        public async Task<Org> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(Org entity)
        {
            throw new NotImplementedException();
        }
    }
}
