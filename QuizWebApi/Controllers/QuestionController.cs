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
    public class QuestionController : ApiController
    {
        // GET: api/Question
        public IEnumerable<Question> GetAllQuestion()
        {
            CrudQuestion CQ = new CrudQuestion();
            return CQ.GetAllQuestion();
        }

        // GET: api/Question/5
        public Question GetQuestion(int id)
        {
            CrudQuestion CQ = new CrudQuestion();
            return CQ.GetQuestion(id);
        }

        // POST: api/Question
        public void Post([FromBody]Question Q)
        {
            CrudQuestion CQ = new CrudQuestion();
            CQ.CreateQuestion(Q);
        }

        // PUT: api/Question/5
        public void Put([FromBody]Question Q)
        {
            CrudQuestion CQ = new CrudQuestion();
            CQ.UpdateQuestion(Q);

        }

        // DELETE: api/Question/5
        public void Delete(Question Q)
        {
            CrudQuestion CQ = new CrudQuestion();
            CQ.DeleteQuestion(Q);
        }
    }
}
