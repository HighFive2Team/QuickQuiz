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

       [Required(ErrorMessage = " Tenant identication required")]
        public string TenantName { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
       [MaxLength(30)]
        public int PhoneNumber { get; set; }
        public string OfferType { get; set; }
       [DataType(DataType.ImageUrl), Display(Name = "votre Logo")]
        public string Logo { get; set; }
        [Required(ErrorMessage = " slogan required")]
        [StringLength(25, ErrorMessage = "must be then 25 characters")]
        [MaxLength(50)]
        public string Slogan { get; set; }

       //navigation Proprietes
  
       public virtual ICollection<EndUser> EndUsers { get; set; }
       public virtual ICollection<QuizManager> QuizManagers { get; set; }

    }
}
