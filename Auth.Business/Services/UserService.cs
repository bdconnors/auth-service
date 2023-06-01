using Auth.Business.Dto;
using Auth.Business.Interfaces;
using Auth.Business.Util;
using Auth.Data.Interfaces;
using Auth.Data.Models;
using System.Security.Cryptography;
using System.Text;

namespace Auth.Business.Services
{
    public class UserService : IUserService
    {
        public IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<User> Get(int id)
        {
            return _unitOfWork.Users.GetById(id);
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _unitOfWork.Users.GetAll();
        }
        public User Add(CreateUserDto data)
        {
            try
            {
                string hashedPass = SHA256Encryption.Hash(data.Password);
                User user = new User(data.TenantID, data.FirstName, data.LastName, data.Email, hashedPass, data.MobileNumber);
                user = _unitOfWork.Users.Add(user);
                user.UserRoles = MakeUserRoles(user.Id, data.Roles);
                _unitOfWork.Users.Save();

                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ICollection<UserRole> MakeUserRoles(int userId, IEnumerable<int> roleIds) 
        { 
            ICollection<UserRole> result = new HashSet<UserRole>();

            UserRole userRole;
            foreach (int roleId in roleIds) 
            { 
                userRole = new UserRole(userId, roleId);
                result.Add(userRole);
            }

            return result;
        }
    }
}
