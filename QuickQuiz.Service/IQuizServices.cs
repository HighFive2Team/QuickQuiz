using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Service
{
    interface IQuizServices : IDisposable
    {
        public Tenant GetTenant(int id);
        public IEnumerable<Tenant> GetAllTenant();
        public void CreateTenant(Tenant t);
        public void UpdateTenant(Tenant t);
        public void DeleteTenant(Tenant t);


        public void CreateScore(Score S);
        public void UpdateScore(Score S);
        public void DeleteScore(Score S);
        public Score GetScore(int id);
        public IEnumerable<Score> GetAllScore();
        public IEnumerable<Score> GetScoreByQuiz(string quizId);
        public IEnumerable<Score> GetScoreByEnduser(string EndUserEmail);


        public void CreateQuizManager(QuizManager QM);
        public void UpdateQuizManager(QuizManager QM);
        public void DeleteQuizManager(QuizManager QM);
        public QuizManager GetQuizManager(int id);
        public IEnumerable<QuizManager> GetAllQuizManager();


        public void CreatePoll(Poll P);
        public void UpdatePoll(Poll P);
        public void DeletePoll(Poll P);
        public Poll GetPoll(int id);
        public IEnumerable<Poll> GetAllPoll();
        public IEnumerable<Poll> GetPollByQuizManager(string QuizManagerId);

        
        public void CreateQuiz(Quiz Q);
        public void UpdateQuiz(Quiz Q);
        public void DeleteQuiz(Quiz Q);
        public Quiz GetQuiz(int id);
        public IEnumerable<Quiz> GetAllQuiz();
        public IEnumerable<Quiz> GetQuizByQuizManager(string QuizManagerEmail);

        public void CreateQuestion(Question Q);
        public void UpdateQuestion(Question Q);
        public void DeleteQuestion(Question Q);
        public Question GetQuestion(int id);
        public IEnumerable<Question> GetAllQuestion();


        public void CreateEndUser(EndUser E);
        public void UpdateEndUser(EndUser E);
        public void DeleteEndUser(EndUser E);
        public EndUser GetEndUser(int id);
        public IEnumerable<EndUser> GetAllEndUser();

        public void CreateAnswer(Answer A);
        public void UpdateQuiz(Answer A);
        public void DeleteAnswer(Answer A);
        public Answer GetAnswer(String Answerid);
        public IEnumerable<Answer> GetAllAnswer();
        public IEnumerable<Answer> GetAnswerByQuestion(string QuestionID);















    }
}
