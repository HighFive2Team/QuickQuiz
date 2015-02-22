using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
   public  class EndUser:User
    {
       public virtual ICollection<Poll> Polls { get; set; }
       public virtual ICollection<Score> Scores { get; set; }


       //foreignkey
       public string TenantId { get; set; }
       public virtual Tenant Tenant { get; set; } 

    }
}
