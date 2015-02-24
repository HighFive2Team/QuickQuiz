using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
   public  class QuizManager:User
    {
        

        public virtual ICollection<Quiz> Quizzes { get; set; }
        public virtual ICollection<Poll> Polls { get; set; }


      
        public string QmTenantId { get; set; }
       [ForeignKey("QmTenantId ")]
        public virtual Tenant Tenant { get; set; } 
    }
}
