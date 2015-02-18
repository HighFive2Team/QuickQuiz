using QuizProject.data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Infrastructure
{
   public interface IUnitOfWork:IDisposable
    {
       void Commit();
       IAdminRepository AdminRepository { get; }
       IAnswerRepository AnswerRepository { get; }
       IEndUserRepository EndUserRepository { get; }
       IPollRepository PollRepository { get; }
       IQuestionRepository QuestionRepository { get; }
       IQuizManagerRepository QuizManagerRepository { get; }
       IQuizRepository QuizRepository { get; }
       IScoreRepository ScoreRepository { get; }
       ITenantRepository TenantRepository { get; }
       IUserRepository UserRepository { get; }

    }
}
