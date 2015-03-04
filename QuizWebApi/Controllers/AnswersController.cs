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
    public class AnswersController : ApiController
    {
        QuizServices qs =new QuizServices();
        // GET: api/Answers
        public IEnumerable<Answer> GetAnswers()
        {
            return qs.GetAllAnswers();
        }

        // GET: api/Answers/5
        public Answer Get(string id)
        {
            return qs.GetAnswer(id);
        }

        // POST: api/Answers
        public void Post(Answer a)
        {
            qs.CreateAnswer(a);
        }

        // PUT: api/Answers/5
        public void Put(Answer a)
        {
            qs.UpdateAnswer(a);
        }

        // DELETE: api/Answers/5
        public void Delete(Answer a)
        {
            qs.DeleteAnswer(a);
        }
    }
}
