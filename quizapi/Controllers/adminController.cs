using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace quizapi.Controllers
{
    public class adminController : ApiController
    {
        // GET: api/admin
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/admin/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/admin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/admin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/admin/5
        public void Delete(int id)
        {
        }
    }
}
