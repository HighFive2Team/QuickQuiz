using QuickQuiz.Data.Infrastructure;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Repositories
{
    public class TenantRepositry : RepositoryBase<Score>, ITenantRepository
    {
        public TenantRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface ITenantRepository : IRepository<Tenant> { }
}
