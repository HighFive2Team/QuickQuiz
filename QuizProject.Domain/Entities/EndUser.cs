using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.Domain
{
   public partial class EndUser:User
    {
       public virtual ICollection<Quiz> Quizs {get; set;}
       public virtual ICollection<Poll> Polls { get; set; }
       public virtual ICollection<Score> Score { get; set; }
       
      

    }
}
