using Domain.Entities;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductApp : IGenericApp<Product>
    {
        Task AddProduct(Product product);
    }
}