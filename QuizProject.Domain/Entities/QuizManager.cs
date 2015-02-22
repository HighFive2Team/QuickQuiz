using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.Domain
{
   public  class QuizManager:User
    {
        

        public virtual ICollection<Quiz> Quiz { get; set; }
        public virtual ICollection<Poll> Poll { get; set; }
       
      
    }
}
