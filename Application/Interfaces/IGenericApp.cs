using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericApp<TEntity> where TEntity : class
    {
        Task Add(TEntity Obj);

        Task Update(TEntity Obj);

        Task Delete(TEntity Obj);

        Task<TEntity> GetEntityById(int Id);

        Task<List<TEntity>> List();
    }
}