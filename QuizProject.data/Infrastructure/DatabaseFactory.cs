using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Infrastructure
{
   public class DatabaseFactory:Disposable,IDatabaseFactory
    {
       private QuizContext dataContext;
       public QuizContext DataContext { get { return dataContext; } }
       public DatabaseFactory()
       {
           dataContext = new QuizContext();
       }
       protected override void DisposeCore()
       {
           if (DataContext != null)
           {
               DataContext.Dispose();
           }
       }
    }
}
