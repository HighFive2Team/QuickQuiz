using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.Domain
{
    public partial class User
    {
        [Key]public string IdUser { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
      
        //public List<QuizManager> listquizmanager { get; set; }
        //public List<QuizUser> listquizuser { get; set; }

        public virtual Tenant tenant { get; set; } 
        

        //foreignkey
        public string TenantId { get; set; }

         }
}
