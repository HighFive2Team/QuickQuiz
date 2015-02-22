using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Repositories
{
    public class EndUserRepositry : RepositoryBase<EndUser>, IEndUserRepository
    {
        public EndUserRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface IEndUserRepository : IRepository<EndUser> { }
}
