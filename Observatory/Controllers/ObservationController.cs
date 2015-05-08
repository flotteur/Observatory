using Observatory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Observatory.Controllers
{
    public class ObservationController : ApiController
    {
        /// <summary>
        /// Repository for the obervation controller
        /// </summary>
        private IRepository<object> repository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public ObservationController(IRepository<object> repository)
        {
            this.repository = repository;
        }

        // GET: api/Observation
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Observation/5
        public string Get(int id)
        {
            return "value";
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
