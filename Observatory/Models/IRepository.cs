using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Observatory.Models
{
    public interface IRepository<T>
    {
        Task<int> Create(T obj);
        Task<T> Get(int key);
        Task Update(T obj);
        Task Delete(int key);
    }
}