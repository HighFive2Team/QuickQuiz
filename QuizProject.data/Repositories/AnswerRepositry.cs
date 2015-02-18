using QuizProject.data.Infrastructure;
using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Repositories
{
  public  class AnswerRepositry:RepositoryBase<Answer>,IAnswerRepository
    {
      public AnswerRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
  public interface IAnswerRepository : IRepository<Answer> { }
}
