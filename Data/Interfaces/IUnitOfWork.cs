namespace Auth.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        int Save();
    }
}
