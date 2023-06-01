using Auth.Data.Models;

namespace Auth.Business.Interfaces
{
    public interface ITenantService
    {
        Tenant Add(string name);
        Task<IEnumerable<Tenant>> GetAll();
        Task<Tenant> Get(int id);
        IEnumerable<Role> AddDefaultRoles(int tenantId);
        IEnumerable<Permission> AddDefaultPermissions(int tenantId);
        IEnumerable<RolePermission> AddDefaultRolePermissions(IEnumerable<Role> roles, IEnumerable<Permission> permissions);
    }
}