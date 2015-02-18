using QuizProject.data.Infrastructure;
using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Repositories
{
    public class ScoreRepositry : RepositoryBase<Score>, IScoreRepository
    {
        public ScoreRepositry(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }
    public interface IScoreRepository : IRepository<Score> { }
}
