using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service.CrudServices
{
    public class CrudQuizManager
    {
        DatabaseFactory dbFactory = null;
        UnitOfWork unofWork = null;
        public CrudQuizManager()
        {
            dbFactory = new DatabaseFactory();
            unofWork = new UnitOfWork(dbFactory);

        }
        public void CreateQuizManager(QuizManager QM)
        {
            unofWork.QuizManagerRepository.Add(QM);
            unofWork.Commit();
        }
        public void UpdateQuizManager(QuizManager QM)
        {
            unofWork.QuizManagerRepository.Update(QM);
            unofWork.Commit();
        }
        public void DeleteQuizManager(QuizManager QM)
        {
            unofWork.QuizManagerRepository.Delete(QM);
            unofWork.Commit();
        }
        public QuizManager GetQuizManager(int id)
        {
            var Q = unofWork.QuizManagerRepository.GetById(id);
            return Q;
        }
        public IEnumerable<QuizManager> GetAllQuizManager()
        {
            return unofWork.QuizManagerRepository.GetAll();
        }
        public void Dispose()
        {
            unofWork.Dispose();
        }
    }
}
