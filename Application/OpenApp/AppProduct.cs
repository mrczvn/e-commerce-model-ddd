using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.OpenApp
{
    public class AppProduct : IProductApp
    {
        private IProduct _IProduct;
        private IServiceProduct _IServiceProduct;

        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }

        public async Task AddProduct(Product product)
        {
            await _IServiceProduct.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _IServiceProduct.UpdateProduct(product);
        }

        public Task Add(Product Obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product Obj)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(Product Obj)
        {
            throw new NotImplementedException();
        }
    }
}