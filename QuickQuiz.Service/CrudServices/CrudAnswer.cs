using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service.CrudServices
{
   public class CrudAnswer
    {
        DatabaseFactory dbFactory = null;
        UnitOfWork unofWork = null;
        public CrudAnswer()
        {
            dbFactory = new DatabaseFactory();
            unofWork = new UnitOfWork(dbFactory);

        }
        public void CreateAnswer(Answer A)
        {
            unofWork.AnswerRepository.Add(A);
            unofWork.Commit();
        }
        public void UpdateQuiz(Answer A)
        {
            unofWork.AnswerRepository.Update(A);
            unofWork.Commit();
        }
        public void DeleteAnswer(Answer A)
        {
            unofWork.AnswerRepository.Delete(A);
            unofWork.Commit();
        }
        public Answer GetQuiz(int id)
        {
            var A = unofWork.AnswerRepository.GetById(id);
            return A;
        }
        public IEnumerable<Answer> GetAllAnswer()
        {
            return unofWork.AnswerRepository.GetAll();
        }
        public IEnumerable<Answer> GetAnswerByQuestion(string QuestionID)
        {
            return unofWork.AnswerRepository.GetMany(A => A.Question.questionId == QuestionID);
        }
        public void Dispose()
        {
            unofWork.Dispose();
        }
    }
}
