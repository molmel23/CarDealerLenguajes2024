﻿using System.Linq.Expressions;

namespace CarDealer.Data.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);

        IEnumerable<T> GetAll(string? includeProperties = null);

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);


    }
}

