using QuizProject.data.Infrastructure;
using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Repositories
{
   public class AdminRepository:RepositoryBase<Admin>,IAdminRepository
    {
       public AdminRepository(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
   public interface IAdminRepository : IRepository<Admin> { }
}
