﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mini.Interfaces
{
    public interface IDataProvider<T>
    {
        Task AddAsync(T entity);

        Task RemoveAsync(T entity);

        Task UpdateAsync(T entity);

        IQueryable<T> GetAlls();

        T GetByID(Guid id);

        IQueryable<T> GetByLamada(Expression<Func<T, bool>> func);
    }
}
