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

        public User Register(string email, string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            User user = new User(email, passwordHash);

            return _unitOfWork.Users.Add(user);
        }
        public async Task<User> RegisterUserSite(int userId, int siteId, string role)
        {
            User user = await _unitOfWork.Users.GetById(userId);
            Site site = await _unitOfWork.Sites.GetById(siteId);
            UserSite userSite = new UserSite(user, site, role);
            _unitOfWork.UserSites.Add(userSite);

            return await _unitOfWork.Users.GetById(userId);
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _unitOfWork.Users.GetAll();
        }
    }
}
