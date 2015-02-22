using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Repositories
{
    public class QuestionRepositry : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface IQuestionRepository : IRepository<Question> { }
}
