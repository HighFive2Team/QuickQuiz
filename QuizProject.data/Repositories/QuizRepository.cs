using QuizProject.data.Infrastructure;
using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Repositories
{
    public class QuizRepositry : RepositoryBase<Quiz>, IQuizRepository
    {
        public QuizRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface IQuizRepository : IRepository<Quiz> { }
}
