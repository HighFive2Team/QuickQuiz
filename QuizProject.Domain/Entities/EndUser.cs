using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
   public  class EndUser:User
    {
       public virtual ICollection<Poll> Polls { get; set; }
       public virtual ICollection<Score> Scores { get; set; }


      
       public string TenantId { get; set; }
       [ForeignKey("TenantId ")]
       public virtual Tenant Tenant { get; set; } 

    }
}
