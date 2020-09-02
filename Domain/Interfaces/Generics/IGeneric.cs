using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGeneric<TEntity> where TEntity : class
    {
        Task Add(TEntity Obj);
    }
}