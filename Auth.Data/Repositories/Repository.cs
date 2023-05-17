using Auth.Data.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Auth.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AuthorizationDbContext _dbContext;

        protected Repository(AuthorizationDbContext context)
        {
            _dbContext = context;
        }
        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).ToList();
        }
        public T Add(T entity)
        {
            var ent = _dbContext.Set<T>().Add(entity);
            return ent;
        }
        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }
        public void Update(T entity)
        {
            _dbContext.Set<T>().AddOrUpdate(entity);
        }
        public void Save() 
        {
            _dbContext.SaveChanges();
        }
    }
}
