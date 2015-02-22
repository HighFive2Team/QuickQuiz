using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Repositories
{
    public class QuizRepositry : RepositoryBase<Quiz>, IQuizRepository
    {
        public QuizRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface IQuizRepository : IRepository<Quiz> { }
}
