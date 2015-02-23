using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service.CrudServices
{
    class CrudScore
    {
        DatabaseFactory dbFactory = null;
        UnitOfWork unofWork = null;
        public CrudScore()
        {
            dbFactory = new DatabaseFactory();
            unofWork = new UnitOfWork(dbFactory);

        }
        public void CreateScore(Score S)
        {
            unofWork.ScoreRepository.Add(S);
            unofWork.Commit();
        }
        public void UpdateScore(Score S)
        {
            unofWork.ScoreRepository.Update(S);
            unofWork.Commit();
        }
        public void DeleteScore(Score S)
        {
            unofWork.ScoreRepository.Delete(S);
            unofWork.Commit();
        }
        public Score GetScore(int id)
        {
            var s = unofWork.ScoreRepository.GetById(id);
            return s;
        }
        public IEnumerable<Score> GetScoreByQuiz(string quizId)
        {
            return unofWork.ScoreRepository.GetMany(s => s.Quiz.IdQuiz == quizId);
        }
        public IEnumerable<Score> GetScoreByEnduser(string EndUserEmail)
        {
            return unofWork.ScoreRepository.GetMany(s => s.EndUser.Email == EndUserEmail);
        }
        public void Dispose()
        {
            unofWork.Dispose();
        }
    }
}
