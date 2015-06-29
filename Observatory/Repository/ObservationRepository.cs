namespace Observatory.Repository
{
    using Entity;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Observation service repository
    /// </summary>
    public class ObservationRepository : IRepository<Observation>
    {
        /// <summary>
        /// Context for the entity framework
        /// </summary>
        private readonly ObservationContext entityContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationRepository"/> class.
        /// </summary>
        /// <param name="dbContext">An instance of ObservationContext database context.</param>
        public ObservationRepository(ObservationContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException("The database context is required.");
            }

            this.entityContext = dbContext;
        }

        /// <summary>
        /// Create a new observation
        /// </summary>
        /// <param name="obj">The observation to create</param>
        /// <returns>The id of the new observation</returns>
        public async Task<int> Create(Observation obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete an observation
        /// </summary>
        /// <param name="id">The id of the observation to delete</param>
        /// <returns>An awaitable task</returns>
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all the observation
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Observation>> Get()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the detail of an observation
        /// </summary>
        /// <param name="id">The id of the observation</param>
        /// <returns>The observation</returns>
        public async Task<Observation> Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update an existing observation
        /// </summary>
        /// <param name="obj">The updated observation</param>
        /// <returns>An awaitable task</returns>
        public async Task Update(Observation obj)
        {
            throw new NotImplementedException();
        }
    }
}