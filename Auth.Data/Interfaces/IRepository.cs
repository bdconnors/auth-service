namespace Auth.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        IEnumerable<T> Filter(Func<T,bool> predicate);
        T Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save();
    }
}
