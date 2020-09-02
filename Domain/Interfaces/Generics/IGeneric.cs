using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGeneric<TEntity> where TEntity : class
    {
        Task Add(TEntity Obj);

        Task Update(TEntity Obj);

        Task Delete(TEntity Obj);

        Task<TEntity> GetEntityById(int Id);

        Task<List<TEntity>> List();
    }
}