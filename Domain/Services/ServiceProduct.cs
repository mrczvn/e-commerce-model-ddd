using Domain.Entities;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using System;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;

        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public async Task AddProduct(Product product)
        {
            var validateName = product.ValidateStringProperty(product.Name, "Nome");
            var validateValue = product.ValidateDecimalProperty(product.Value, "Valor");

            if (validateName && validateValue)
            {
                product.Status = true;
                await _IProduct.Add(product);
            }
        }

        public Task UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}