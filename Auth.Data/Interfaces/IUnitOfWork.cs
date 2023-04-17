namespace Auth.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IOrgRepository Orgs { get; }
        ISiteRepository Sites { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; } 
        int Save();
    }
}
