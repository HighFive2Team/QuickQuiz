using QuizProject.data.Infrastructure;
using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Repositories
{
    public class QuizManagerRepositry : RepositoryBase<QuizManager>, IQuizManagerRepository
    {
        public QuizManagerRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface IQuizManagerRepository : IRepository<QuizManager> { }
}