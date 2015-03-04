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
    public class QuizManagersController : ApiController
    {
        QuizServices qs = new QuizServices();
        // GET: api/QuizManagers
        public IEnumerable<QuizManager> GetAllQuizManagers()
        {
            return qs.GetAllQuizManagers();
        }

        // GET: api/QuizManagers/5
        public QuizManager GetQuizManager(string id)
        {
            return qs.GetQuizManager(id);
        }

        // POST: api/QuizManagers
        public void Post(QuizManager qm)
        {
            qs.CreateQuizManager(qm);
        }

        // PUT: api/QuizManagers/5
        public void Put(QuizManager qm)
        {
            qs.UpdateQuizManager(qm);
        }

        // DELETE: api/QuizManagers/5
        public void Delete(QuizManager qm)
        {
            qs.DeleteQuizManager(qm);
        }
    }
}
