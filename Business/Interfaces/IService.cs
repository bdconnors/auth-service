namespace Auth.Business.Interfaces
{
    public interface IService<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        T Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
