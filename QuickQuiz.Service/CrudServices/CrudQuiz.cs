using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service.CrudServices
{
    class CrudQuiz
    {
        DatabaseFactory dbFactory = null;
        UnitOfWork unofWork = null;
        public CrudQuiz()
        {
            dbFactory = new DatabaseFactory();
            unofWork = new UnitOfWork(dbFactory);

        }
        public void CreateQuiz(Quiz Q)
        {
            unofWork.QuizRepository.Add(Q);
            unofWork.Commit();
        }
        public void UpdateQuiz(Quiz Q)
        {
            unofWork.QuizRepository.Update(Q);
            unofWork.Commit();
        }
        public void DeleteQuiz(Quiz Q)
        {
            unofWork.QuizRepository.Delete(Q);
            unofWork.Commit();
        }
        public Quiz GetQuiz(int id)
        {
            var Q = unofWork.QuizRepository.GetById(id);
            return Q;
        }
        public IEnumerable<Quiz> GetQuizByQuizManager(string QuizManagerEmail)
        {
            return unofWork.QuizRepository.GetMany(q => q.QuizManager.Email == QuizManagerEmail);
        }
        public void Dispose()
        {
            unofWork.Dispose();
        }
    }
}
