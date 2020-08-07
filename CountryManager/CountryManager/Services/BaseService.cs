using CountryManager_API.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager_API.Services
{
    public abstract class BaseService<R,U> where R: Repository<U> where U: class
    {
        private readonly R repository;

        public BaseService(R repository)
        {
            this.repository = repository;
        }

        internal async Task<List<U>> GetAll()
        {
            var result = await repository.GetAll();
            return result.ToList();
        }

        internal async Task<U> GetById(int id)
        {
            var entity = await repository.GetById(id);
            return entity;
        }

        internal virtual async Task<List<U>> Seek(U filter)
        {
            throw new NotImplementedException();
        }

        virtual internal async Task Create(U entity)
        {            
            await repository.Create(entity);
        }
        virtual internal async Task Update(U entity)
        {            
            await repository.Update(entity);
        }

        virtual internal async Task Delete(int id)
        {
            var entity = await repository.GetById(id);            
            await repository.Update(entity);
        }
    }
}
