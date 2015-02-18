using QuizProject.data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Infrastructure
{
   public class UnitOfWork:IUnitOfWork
    {
       private QuizContext dataContext;
       IDatabaseFactory dbFactory;
       public UnitOfWork(IDatabaseFactory dbFactory)
       {
           this.dbFactory = dbFactory;
       }
       private IAdminRepository adminRepository;
       public IAdminRepository AdminRepository
       {
           get { return adminRepository=new AdminRepository(dbFactory);}
       }

       private IAnswerRepository answerRepository;
       public IAnswerRepository AnswerRepository
       {
           get { return answerRepository = new AnswerRepositry(dbFactory); }
       }

       private IEndUserRepository endUserRepository;
       public IEndUserRepository EndUserRepository
       {
           get { return endUserRepository = new EndUserRepositry(dbFactory); }
       }

       private IPollRepository pollRepository;
       public IPollRepository PollRepository
       {
           get { return pollRepository = new PollRepositry(dbFactory); }
       }
       private IQuestionRepository questionRepository;
       public IQuestionRepository QuestionRepository
       {
           get { return questionRepository = new QuestionRepositry(dbFactory); }
       }
       private IQuizManagerRepository quizManagerRepository;
       public IQuizManagerRepository QuizManagerRepository
       {
           get { return quizManagerRepository = new QuizManagerRepositry(dbFactory); }
       }

       private IQuizRepository quizRepository;
       public IQuizRepository AdminRepository
       {
           get { return quizRepository = new QuizRepositry(dbFactory); }
       }

       private IScoreRepository scoreRepository;
       public IScoreRepository ScoreRepository
       {
           get { return scoreRepository = new ScoreRepositry(dbFactory); }
       }

       private ITenantRepository tenantRepository;
       public ITenantRepository TenantRepository
       {
           get { return tenantRepository = new TenantRepositry(dbFactory); }
       }
       private IUserRepository userRepository;
       public IUserRepository UserRepository
       {
           get { return userRepository = new UserRepositry(dbFactory); }
       }
    }
}
