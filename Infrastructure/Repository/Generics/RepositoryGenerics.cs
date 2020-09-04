using Domain.Interfaces.Generics;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Generics
{
    public class RepositoryGenerics<TEntity> : IGeneric<TEntity>, IDisposable where TEntity : class
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositoryGenerics()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task Add(TEntity Obj)
        {
            using ContextBase data = new ContextBase(_OptionsBuilder);
            await data.Set<TEntity>().AddAsync(Obj);
            await data.SaveChangesAsync();
        }

        public async Task Delete(TEntity Obj)
        {
            using ContextBase data = new ContextBase(_OptionsBuilder);
            data.Set<TEntity>().Remove(Obj);
            await data.SaveChangesAsync();
        }

        public async Task<TEntity> GetEntityById(int Id)
        {
            using ContextBase data = new ContextBase(_OptionsBuilder);
            var entity = await data.Set<TEntity>().FindAsync(Id);
            return entity;
        }

        public Task<List<TEntity>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity Obj)
        {
            throw new NotImplementedException();
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose

        private bool _disposed = false;
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose() => Dispose(true);

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                _safeHandle?.Dispose();
            }
            _disposed = true;
        }

        #endregion Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
    }
}