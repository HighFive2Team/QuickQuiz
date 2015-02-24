using QuickQuiz.Domain;
using QuickQuiz.Service.CrudServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuickQuiz.Web.Controllers
{
    public class EndUserController : ApiController
    {
        // GET: api/EndUser
        public IEnumerable<EndUser> GetAllEndUser()
        {
            CrudEndUser CU = new CrudEndUser();
            return CU.GetAllEndUser();
        }

        // GET: api/EndUser/5
        public EndUser GetEndUser(int id)
        {
            CrudEndUser CU = new CrudEndUser();
            return CU.GetEndUser(id);
        }

        // POST: api/EndUser
        public void Post([FromBody]EndUser U)
        {
            CrudEndUser CU = new CrudEndUser();
            CU.CreateEndUser(U);
        }

        // PUT: api/EndUser/5
        public void Put([FromBody]EndUser U)
        {
            CrudEndUser CU = new CrudEndUser();
            CU.UpdateEndUser(U);

        }

        // DELETE: api/EndUser/5
        public void Delete(EndUser U)
        {
            CrudEndUser CU= new CrudEndUser();
            CU.DeleteEndUser(U);
        }
    }
}
