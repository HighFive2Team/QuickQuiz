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
    public class QuestionsController : ApiController
    {
        QuizServices qs = new QuizServices();
        // GET: api/Questions
        public IEnumerable<Question> GetQuestions()
        {
            return qs.GetAllQuestions();
        }

        // GET: api/Questions/5
        public Question Get(string id)
        {
            return qs.GetQuestion(id);
        }

        // POST: api/Questions
        [HttpPost]
        public void Post(Question qu)
        {
            qs.CreateQuestion(qu);
        }

        // PUT: api/Questions/5
        [HttpPut]
        public void Put(Question qu)
        {
            qs.UpdateQuestion(qu);
        }

        // DELETE: api/Questions/5
        [HttpDelete]
        public void Delete(Question qu)
        {
            qs.UpdateQuestion(qu);
        }
    }
}
