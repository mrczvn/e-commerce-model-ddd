﻿using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
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

        public async Task Add(Product Obj)
        {
            await _IProduct.Add(Obj);
        }

        public async Task Delete(Product Obj)
        {
            await _IProduct.Delete(Obj);
        }

        public async Task<Product> GetEntityById(int Id)
        {
            var productById = await _IProduct.GetEntityById(Id);

            return productById;
        }

        public async Task<List<Product>> List()
        {
            var products = await _IProduct.List();

            return products;
        }

        public async Task Update(Product Obj)
        {
            await _IProduct.Update(Obj);
        }
    }
}