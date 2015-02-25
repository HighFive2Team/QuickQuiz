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
    public class QuizController : ApiController
    {
        // GET: api/Quiz
        public IEnumerable<Quiz> GetAllQuiz()
        {
            CrudQuiz CQ = new CrudQuiz();
            return CQ.GetAllQuiz();
        }

        // GET: api/Quiz/5
        public Quiz GetQuiz(int id)
        {
            CrudQuiz CQ = new CrudQuiz();
            return CQ.GetQuiz(id);
        }

        // POST: api/Quiz
        public void Post([FromBody]Quiz Q)
        {
            CrudQuiz CQ = new CrudQuiz();
            CQ.CreateQuiz(Q);
        }

        // PUT: api/Quiz/5
        public void Put([FromBody]Quiz Q)
        {
            CrudQuiz CQ = new CrudQuiz();
            CQ.UpdateQuiz(Q);

        }

        // DELETE: api/Quiz/5
        public void Delete(Quiz Q)
        {
            CrudQuiz CQ = new CrudQuiz();
            CQ.DeleteQuiz(Q);
        }
    }
}
