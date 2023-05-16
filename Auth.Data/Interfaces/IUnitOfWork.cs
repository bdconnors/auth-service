namespace Auth.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITenantRepository Tenants { get; }
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        IPermissionRepository Permissions { get; }
        IUserRoleRepository UserRoles { get; }
        IRolePermissionRepository RolePermissions { get; }
        int Save();
    }
}
