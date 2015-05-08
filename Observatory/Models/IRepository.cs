﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Observatory.Models
{
    /// <summary>
    /// Interface for basic CRUD operation on a repository
    /// </summary>
    /// <typeparam name="T">Any DTO datatype</typeparam>
    public interface IRepository<T>
    {
        Task<int> Create(T obj);
        Task<T> Get(int key);
        Task Update(T obj);
        Task Delete(int key);
    }
}