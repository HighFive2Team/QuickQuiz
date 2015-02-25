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
    public class AnswerController : ApiController
    {
        // GET: api/Answer
        public IEnumerable<Answer> GetAllAnswer()
        {
            CrudAnswer CA = new CrudAnswer();
            return CA.GetAllAnswer();
        }

        // GET: api/Answer/5
        public Answer GetAnswer(int id)
        {
            CrudAnswer CA = new CrudAnswer();
            return CA.GetAnswer(id);
        }

        // POST: api/Answer
        public void Post([FromBody]Answer A)
        {
            CrudAnswer CA = new CrudAnswer();
            CA.CreateAnswer(A);
        }

        // PUT: api/Answer/5
        public void Put([FromBody]Answer P)
        {
            CrudAnswer CA = new CrudAnswer();
            CA.UpdateAnswer(P);

        }

        // DELETE: api/Answer/5
        public void Delete(Answer A)
        {
            CrudAnswer CA = new CrudAnswer();
            CA.DeleteAnswer(A);
        }
    }
}
