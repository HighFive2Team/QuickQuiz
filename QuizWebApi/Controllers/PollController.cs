using QuickQuiz.Domain;
using QuickQuiz.Service.CrudServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizWebApi.Controllers
{
    public class PollController : ApiController
    {
        // GET: api/Poll
        public IEnumerable<Poll> GetAllPoll()
        {
            CrudPoll CP = new CrudPoll();
            return CP.GetAllPoll();
        }

        // GET: api/Poll/5
        public Poll GetPoll(int id)
        {
            CrudPoll CP = new CrudPoll();
            return CP.GetPoll(id);
        }

        // POST: api/Poll
        public void Post([FromBody]Poll P)
        {
            CrudPoll CP = new CrudPoll();
            CP.CreatePoll(P);
        }

        // PUT: api/Poll/5
        public void Put([FromBody]Poll P)
        {
            CrudPoll CP = new CrudPoll();
            CP.UpdatePoll(P);

        }

        // DELETE: api/Quiz/5
        public void Delete(Poll P)
        {
            CrudPoll CP = new CrudPoll();
            CP.DeletePoll(P);
        }
    }
}
