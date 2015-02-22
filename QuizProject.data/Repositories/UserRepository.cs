using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Repositories
{
    public class UserRepositry : RepositoryBase<User>, IUserRepository
    {
        public UserRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface IUserRepository : IRepository<User> { }
}
