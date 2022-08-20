﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShortUrlMVC.DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T item);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetPagedAsync(int page = 1, int pageSize = 15);
        Task<T> GetAsync(string id);
        Task<List<T>> FindAsync(Expression<Func<T, Boolean>> predicate);
        Task UpdateAsync(T item);
        Task DeleteAsync(string id);
        Task<int> GetCountAsync();
    }
}
