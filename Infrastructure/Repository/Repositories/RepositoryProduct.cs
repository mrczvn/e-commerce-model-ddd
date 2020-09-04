using Domain.Entities;
using Domain.Interfaces.InterfaceProduct;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Product>, IProduct
    {
    }
}