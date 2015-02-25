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
    public class ScoreController : ApiController
    {
        // GET: api/Score
        public IEnumerable<Score> GetAllAnswer()
        {
            CrudScore CS = new CrudScore();
            return CS.GetAllScore();
        }

        // GET: api/Score/5
        public Score GetScore(int id)
        {
            CrudScore CS = new CrudScore();
            return CS.GetScore(id);
        }

        // POST: api/Score
        public void Post([FromBody]Score S)
        {
            CrudScore CS = new CrudScore();
            CS.CreateScore(S);
        }

        // PUT: api/Score/5
        public void Put([FromBody]Score S)
        {
            CrudScore CS = new CrudScore();
            CS.UpdateScore(S);

        }

        // DELETE: api/Score/5
        public void Delete(Score S)
        {
            CrudScore CS = new CrudScore();
            CS.DeleteScore(S);
        }
    }
}
