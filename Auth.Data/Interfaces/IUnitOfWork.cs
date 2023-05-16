namespace Auth.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITenantRepository Tenants { get; }
        IUserRepository Users { get; }
        int Save();
    }
}
