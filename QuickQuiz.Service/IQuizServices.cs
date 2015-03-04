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
         Tenant GetTenant(string id);
         void CreateTenant(Tenant t);
         void UpdateTenant(Tenant t);
         void DeleteTenant(Tenant t);
         IEnumerable<Tenant> GetAllTenants();



         void CreateScore(Score S);
         void UpdateScore(Score S);
         void DeleteScore(Score S);
         Score GetScore(string id);
         IEnumerable<Score> GetAllScores();
         IEnumerable<Score> GetScoreByQuiz(string quizId);
         IEnumerable<Score> GetScoreByEnduser(string EndUserEmail);


         void CreateQuizManager(QuizManager QM);
         void UpdateQuizManager(QuizManager QM);
         void DeleteQuizManager(QuizManager QM);
         QuizManager GetQuizManager(string id);
         IEnumerable<QuizManager> GetAllQuizManagers();


         void CreatePoll(Poll P);
         void UpdatePoll(Poll P);
         void DeletePoll(Poll P);
         Poll GetPoll(string id);
         IEnumerable<Poll> GetAllPolls();
         IEnumerable<Poll> GetPollByQuizManager(string QuizManagerId);

        
         void CreateQuiz(Quiz Q);
         void UpdateQuiz(Quiz Q);
         void DeleteQuiz(Quiz Q);
         Quiz GetQuiz(string id);
         IEnumerable<Quiz> GetAllQuizzes();
         IEnumerable<Quiz> GetQuizByQuizManager(string QuizManagerEmail);

         void CreateQuestion(Question Q);
         void UpdateQuestion(Question Q);
         void DeleteQuestion(Question Q);
         Question GetQuestion(string id);
         IEnumerable<Question> GetAllQuestions();


         void CreateEndUser(EndUser E);
         void UpdateEndUser(EndUser E);
         void DeleteEndUser(EndUser E);
         EndUser GetEndUser(string id);
         IEnumerable<EndUser> GetAllEndUsers();

         void CreateAnswer(Answer A);
         void UpdateAnswer(Answer A);
         void DeleteAnswer(Answer A);
         Answer GetAnswer(string Answerid);
         IEnumerable<Answer> GetAllAnswers();
         IEnumerable<Answer> GetAnswerByQuestion(string QuestionID);



    }
}
