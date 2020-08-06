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

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Seek(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
