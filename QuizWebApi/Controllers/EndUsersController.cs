using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickQuiz.Service;
using QuickQuiz.Domain;

namespace QuizWebApi.Controllers
{
    public class EndUsersController : ApiController
    {
        QuizServices qs = new QuizServices();
        // GET: api/EndUsers    
        public IEnumerable<EndUser> GetEndUsers()
        {
            return qs.GetAllEndUsers();
        }

        // GET: api/EndUsers/5
        public EndUser Get(string id)
        {
            return qs.GetEndUser(id);
        }

        // POST: api/EndUsers
        [HttpPost]
        public void Post(EndUser eu)
        {
            qs.CreateEndUser(eu);
        }
        [HttpPut]
        // PUT: api/EndUsers/5
        public void Put(EndUser eu)
        {
            qs.CreateEndUser(eu);
        }
        [HttpDelete]
        // DELETE: api/EndUsers/5
        public void Delete(EndUser eu)
        {
            qs.CreateEndUser(eu);
        }
    }
}
