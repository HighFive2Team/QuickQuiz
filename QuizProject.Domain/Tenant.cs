using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.Domain
{
   public partial class Tenant:User
    {

       
        [Key] public string IdTenant { get; set; }
        
       public string Country { get; set; }
        public int PostalCode { get; set; }
        public int PhoneNumber { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
        public string OffreType { get; set; }
        public List<User> UserList { get; set; } 

       //navigation Proprietes
  
       public virtual ICollection<User> Users { get; set; }
      // public virtual ICollection<QuizManager> QuizManagers { get; set; }

    }
}
