using System;
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
        /// <summary>
        /// Handle the creation of a ressource.
        /// </summary>
        /// <param name="obj">The object to create</param>
        /// <returns>The id of the created object</returns>
        Task<int> Create(T obj);

        /// <summary>
        /// Get all the ressources of a type T
        /// </summary>
        /// <returns>All the ressources of a type T</returns>
        Task<IEnumerable<T>> Get();

        /// <summary>
        /// Get a ressource by it's id
        /// </summary>
        /// <param name="id">The id of the ressource</param>
        /// <returns>The requested ressource</returns>
        Task<T> Get(int id);

        /// <summary>
        /// Handle the update of a ressource
        /// </summary>
        /// <param name="obj">The ressource to update</param>
        /// <returns>An awaitable task</returns>
        Task Update(T obj);

        /// <summary>
        /// Delete a ressource by it's id
        /// </summary>
        /// <param name="id">The id of the ressource to delete</param>
        /// <returns>An awaitable task</returns>
        Task Delete(int id);
    }
}