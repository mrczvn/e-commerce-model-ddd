using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Generics
{
    public class RepositoryGenerics<TEntity> : IGeneric<TEntity> where TEntity : class
    {
        public Task Add(TEntity Obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(TEntity Obj)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity Obj)
        {
            throw new NotImplementedException();
        }
    }
}
