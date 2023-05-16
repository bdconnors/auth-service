using Auth.Business.Interfaces;
using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Business.Services
{
    public class UserService : IUserService
    {
        public IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _unitOfWork.Users.GetAll();
        }
    }
}
