using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service
{
   public class QuizServices : IQuizServices
    {
        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;

        public QuizServices()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }

        //class answer
        public void CreateAnswer(Answer A)
        {
            utOfWork.AnswerRepository.Add(A);
            utOfWork.Commit();
        }
        public void UpdateQuiz(Answer A)
        {
            utOfWork.AnswerRepository.Update(A);
            utOfWork.Commit();
        }
        public void DeleteAnswer(Answer A)
        {
            utOfWork.AnswerRepository.Delete(A);
            utOfWork.Commit();
        }
        public Answer GetAnswer(String Answerid)
        {
            var A = utOfWork.AnswerRepository.GetById(Answerid);
            return A;
        }
        public IEnumerable<Answer> GetAllAnswer()
        {
            return utOfWork.AnswerRepository.GetAll();
        }
        public IEnumerable<Answer> GetAnswerByQuestion(string QuestionID)
        {
            return utOfWork.AnswerRepository.GetMany(A => A.Question.questionId == QuestionID);
        }


        //class end user
        public void CreateEndUser(EndUser E)
        {
            utOfWork.EndUserRepository.Add(E);
            utOfWork.Commit();
        }
        public void UpdateEndUser(EndUser E)
        {
            utOfWork.EndUserRepository.Update(E);
            utOfWork.Commit();
        }
        public void DeleteEndUser(EndUser E)
        {
            utOfWork.EndUserRepository.Delete(E);
            utOfWork.Commit();
        }
        public EndUser GetEndUser(int id)
        {
            var E = utOfWork.EndUserRepository.GetById(id);
            return E;
        }
        public IEnumerable<EndUser> GetAllEndUser()
        {
            return utOfWork.EndUserRepository.GetAll();
        }


        //class question
        public void CreateQuestion(Question Q)
        {
            utOfWork.QuestionRepository.Add(Q);
            utOfWork.Commit();
        }
        public void UpdateQuestion(Question Q)
        {
            utOfWork.QuestionRepository.Update(Q);
            utOfWork.Commit();
        }
        public void DeleteQuestion(Question Q)
        {
            utOfWork.QuestionRepository.Delete(Q);
            utOfWork.Commit();
        }
        public Question GetQuestion(int id)
        {
            var q = utOfWork.QuestionRepository.GetById(id);
            return q;
        }
        public IEnumerable<Question> GetAllQuestion()
        {
            return utOfWork.QuestionRepository.GetAll();
        }
 

        // class quiz
        public void CreateQuiz(Quiz Q)
        {
            utOfWork.QuizRepository.Add(Q);
            utOfWork.Commit();
        }
        public void UpdateQuiz(Quiz Q)
        {
            utOfWork.QuizRepository.Update(Q);
            utOfWork.Commit();
        }
        public void DeleteQuiz(Quiz Q)
        {
            utOfWork.QuizRepository.Delete(Q);
            utOfWork.Commit();
        }
        public Quiz GetQuiz(int id)
        {
            var Q = utOfWork.QuizRepository.GetById(id);
            return Q;
        }
        public IEnumerable<Quiz> GetAllQuiz()
        {
            return utOfWork.QuizRepository.GetAll();
        }
        public IEnumerable<Quiz> GetQuizByQuizManager(string QuizManagerEmail)
        {
            return utOfWork.QuizRepository.GetMany(q => q.QuizManager.Email == QuizManagerEmail);
        }

        //class poll
        public void CreatePoll(Poll P)
        {
            utOfWork.PollRepository.Add(P);
            utOfWork.Commit();
        }
        public void UpdatePoll(Poll P)
        {
            utOfWork.PollRepository.Update(P);
            utOfWork.Commit();
        }
        public void DeletePoll(Poll P)
        {
            utOfWork.PollRepository.Delete(P);
            utOfWork.Commit();
        }
        public Poll GetPoll(int id)
        {
            var P = utOfWork.PollRepository.GetById(id);
            return P;
        }
        public IEnumerable<Poll> GetAllPoll()
        {
            return utOfWork.PollRepository.GetAll();
        }
        public IEnumerable<Poll> GetPollByQuizManager(string QuizManagerId)
        {
            return utOfWork.PollRepository.GetMany(p => p.QuizManager.IdUser == QuizManagerId);
        }

        //class score
        public void CreateScore(Score S)
        {
            utOfWork.ScoreRepository.Add(S);
            utOfWork.Commit();
        }
        public void UpdateScore(Score S)
        {
            utOfWork.ScoreRepository.Update(S);
            utOfWork.Commit();
        }
        public void DeleteScore(Score S)
        {
            utOfWork.ScoreRepository.Delete(S);
            utOfWork.Commit();
        }
        public Score GetScore(int id)
        {
            var s = utOfWork.ScoreRepository.GetById(id);
            return s;
        }
        public IEnumerable<Score> GetAllScore()
        {
            return utOfWork.ScoreRepository.GetAll();
        }
        public IEnumerable<Score> GetScoreByQuiz(string quizId)
        {
            return utOfWork.ScoreRepository.GetMany(s => s.Quiz.IdQuiz == quizId);
        }
        public IEnumerable<Score> GetScoreByEnduser(string EndUserEmail)
        {
            return utOfWork.ScoreRepository.GetMany(s => s.EndUser.Email == EndUserEmail);
        }

        //class tenant
        public void CreateTenant(Tenant t)
        {
            utOfWork.TenantRepository.Add(t);
            utOfWork.Commit();
        }
        public void UpdateTenant(Tenant t)
        {
            utOfWork.TenantRepository.Update(t);
            utOfWork.Commit();
        }
        public void DeleteTenant(Tenant t)
        {
            utOfWork.TenantRepository.Delete(t);
            utOfWork.Commit();
        }
        public Tenant GetTenant(int id)
        {
            var t = utOfWork.TenantRepository.GetById(id);
            return t;
        }
        public IEnumerable<Tenant> GetAllTenant()
        {
            return utOfWork.TenantRepository.GetAll();
        }

        public void CreateQuizManager(QuizManager QM)
        {
            utOfWork.QuizManagerRepository.Add(QM);
            utOfWork.Commit();
        }
        public void UpdateQuizManager(QuizManager QM)
        {
            utOfWork.QuizManagerRepository.Update(QM);
            utOfWork.Commit();
        }
        public void DeleteQuizManager(QuizManager QM)
        {
            utOfWork.QuizManagerRepository.Delete(QM);
            utOfWork.Commit();
        }
        public QuizManager GetQuizManager(int id)
        {
            var Q = utOfWork.QuizManagerRepository.GetById(id);
            return Q;
        }
        public IEnumerable<QuizManager> GetAllQuizManager()
        {
            return utOfWork.QuizManagerRepository.GetAll();
        }



        public void Dispose()
        {
            utOfWork.Dispose();
        }


    }
}
