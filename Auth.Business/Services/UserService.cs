using Auth.Business.Interfaces;
using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Business.Services
{
    public class UserService : IService<User>, IUserService
    {
        public IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public User Create(User entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
