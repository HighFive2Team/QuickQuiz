using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service
{
    public interface IQuizServices : IDisposable
    {
         Tenant GetTenant(int id);
         IEnumerable<Tenant> GetAllTenant();
         void CreateTenant(Tenant t);
         void UpdateTenant(Tenant t);
         void DeleteTenant(Tenant t);


         void CreateScore(Score S);
         void UpdateScore(Score S);
         void DeleteScore(Score S);
         Score GetScore(int id);
         IEnumerable<Score> GetAllScore();
         IEnumerable<Score> GetScoreByQuiz(string quizId);
         IEnumerable<Score> GetScoreByEnduser(string EndUserEmail);


         void CreateQuizManager(QuizManager QM);
         void UpdateQuizManager(QuizManager QM);
         void DeleteQuizManager(QuizManager QM);
         QuizManager GetQuizManager(int id);
         IEnumerable<QuizManager> GetAllQuizManager();


         void CreatePoll(Poll P);
         void UpdatePoll(Poll P);
         void DeletePoll(Poll P);
         Poll GetPoll(int id);
         IEnumerable<Poll> GetAllPoll();
         IEnumerable<Poll> GetPollByQuizManager(string QuizManagerId);

        
         void CreateQuiz(Quiz Q);
         void UpdateQuiz(Quiz Q);
         void DeleteQuiz(Quiz Q);
         Quiz GetQuiz(int id);
         IEnumerable<Quiz> GetAllQuiz();
         IEnumerable<Quiz> GetQuizByQuizManager(string QuizManagerEmail);

         void CreateQuestion(Question Q);
         void UpdateQuestion(Question Q);
         void DeleteQuestion(Question Q);
         Question GetQuestion(int id);
         IEnumerable<Question> GetAllQuestion();


         void CreateEndUser(EndUser E);
         void UpdateEndUser(EndUser E);
         void DeleteEndUser(EndUser E);
         EndUser GetEndUser(int id);
         IEnumerable<EndUser> GetAllEndUser();

         void CreateAnswer(Answer A);
         void UpdateQuiz(Answer A);
         void DeleteAnswer(Answer A);
         Answer GetAnswer(String Answerid);
         IEnumerable<Answer> GetAllAnswer();
         IEnumerable<Answer> GetAnswerByQuestion(string QuestionID);















    }
}
