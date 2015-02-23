using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service.CrudServices
{
    class CrudQuestion
    {
        DatabaseFactory dbFactory = null;
        UnitOfWork unofWork = null;
        public CrudQuestion()
        {
            dbFactory = new DatabaseFactory();
            unofWork = new UnitOfWork(dbFactory);

        }
        public void CreateQuestion(Question Q)
        {
            unofWork.QuestionRepository.Add(Q);
            unofWork.Commit();
        }
        public void UpdateQuestion(Question Q)
        {
            unofWork.QuestionRepository.Update(Q);
            unofWork.Commit();
        }
        public void DeleteQuestion(Question Q)
        {
            unofWork.QuestionRepository.Delete(Q);
            unofWork.Commit();
        }
        public Question GetQuestion(int id)
        {
            var q = unofWork.QuestionRepository.GetById(id);
            return q;
        }
        public void Dispose()
        {
            unofWork.Dispose();
        }
    }
}
