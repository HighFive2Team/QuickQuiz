using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickQuiz.Service;
using QuickQuiz.Service.CrudServices;
using QuickQuiz.Domain;

namespace QuickQuiz.Web.Controllers
{
    public class QuizManagerController : ApiController
    {
        // GET: api/QuizManager

        public IEnumerable<QuizManager> GetAllQuizManager()
        {
            CrudQuizManager CQM = new CrudQuizManager();
            return CQM.GetAllQuizManager();
        }

        // GET: api/QuizManager/5
        public QuizManager GetQuizManager(int id)
        {
            CrudQuizManager CQM = new CrudQuizManager();
            return CQM.GetQuizManager(id);
        }

        // POST: api/QuizManager
        public void Post([FromBody]QuizManager QM)
        {
            CrudQuizManager CQM = new CrudQuizManager();
            CQM.CreateQuizManager(QM);
        }

        // PUT: api/QuizManager/5
        public void Put([FromBody]QuizManager QM)
        {
            CrudQuizManager CQM = new CrudQuizManager();
            CQM.UpdateQuizManager(QM);

        }

        // DELETE: api/QuizManager/5
        public void Delete(QuizManager QM)
        {
            CrudQuizManager CQM = new CrudQuizManager();
            CQM.DeleteQuizManager(QM);
        }
    }
}
