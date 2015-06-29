using Entity;
using Observatory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Observatory.Controllers
{
    public class ObservationController : ApiController
    {
        /// <summary>
        /// Repository for the obervation controller
        /// </summary>
        private readonly IRepository<Observation> repository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public ObservationController(IRepository<Observation> repository)
        {
            this.repository = repository;
        }

        // GET: api/Observation
        public async Task<IEnumerable<Observation>> Get()
        {
            return await Task.FromResult(new Observation[] { });
        }

        // GET: api/Observation/5
        public async Task<Observation> Get(int id)
        {
            return await this.repository.Get(id);
        }

        // POST: api/Observation
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Observation/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Observation/5
        public void Delete(int id)
        {
        }
    }
}
