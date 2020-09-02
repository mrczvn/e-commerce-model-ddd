﻿using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericApp<TEntity> where : class
    {
        Task Add(TEntity Obj);
    }
}