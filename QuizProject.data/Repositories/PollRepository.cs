using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Repositories
{
    public class PollRepositry : RepositoryBase<Poll>, IPollRepository
    {
        public PollRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface IPollRepository : IRepository<Poll> { }
}
