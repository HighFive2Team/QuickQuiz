using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Infrastructure
{
   public interface IDatabaseFactory:IDisposable
    {
       QuizContext DataContext { get; }
    }
}
