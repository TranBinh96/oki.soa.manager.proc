﻿using System.Linq.Expressions;

namespace Production.DataAccess.Repository.IRespository;

public interface IRepository<T> where T : class
{
    //T - Category
    T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null,bool tracked = true);
    IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null, string? includeProperties = null);
    void Add(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entity);
}