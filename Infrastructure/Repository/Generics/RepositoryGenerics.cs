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