using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CountryManager.Data.Repositories
{
    public abstract class Repository<T> where T:class
    {
        private readonly DbContext db;

        public Repository(DbContext db)
        {
            this.db = db;
        }
        public async Task Create(T entity)
        {
            this.db.Set<T>().Add(entity);
            await db.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<T>> GetAll()
        {
            return await Task.FromResult(db.Set<T>().AsQueryable());
        }

        public async Task<T> GetById(int id)
        {
            var result = db.Set<T>().Find(id);
            return await Task.FromResult(result);
        }

        public IQueryable<T> Seek(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task Update(T entity)
        {
            db.Set<T>().Update(entity);
            await db.SaveChangesAsync();
        }
    }
}
