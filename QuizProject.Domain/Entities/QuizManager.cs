using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
   public  class QuizManager:User
    {
        

        public virtual ICollection<Quiz> Quizzes { get; set; }
        public virtual ICollection<Poll> Polls { get; set; }


        //foreignkey
        public string QmTenantId { get; set; }
        public virtual Tenant Tenant { get; set; } 
    }
}
