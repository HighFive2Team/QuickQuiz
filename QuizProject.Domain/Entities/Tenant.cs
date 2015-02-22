using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
   public  class Tenant:User
    {

       
        [Key] public string TenantId { get; set; }
        
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public int PhoneNumber { get; set; }
        public string OfferType { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }

       //navigation Proprietes
  
       public virtual ICollection<EndUser> EndUsers { get; set; }
       public virtual ICollection<QuizManager> QuizManagers { get; set; }


       // public virtual ICollection<QuizManager> QuizManagers { get; set; }

    }
}
