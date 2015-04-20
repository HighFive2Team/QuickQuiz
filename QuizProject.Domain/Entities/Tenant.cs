using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
   public  class Tenant
    {

        [Key]
        public string IdTenant { get; set; }

        [Required(ErrorMessage = " FirstName  is required")]
        [StringLength(25, ErrorMessage = "must be less than 25 characters")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = " LastName is required")]
        [StringLength(25, ErrorMessage = "must be then 25 characters")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = " login required")]
        [StringLength(25, ErrorMessage = "must be then 25 characters")]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required(ErrorMessage = " email required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

       [Required(ErrorMessage = " Tenant identication required")]
       [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
       [MaxLength(50)]
        public string TenantName { get; set; }
       [Required(ErrorMessage = "Name of country is  Required")]
       [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
       [MaxLength(50)] 
        public string Country { get; set; }
       [Range(0, int.MaxValue)]
        public int ZipCode { get; set; }
       [MaxLength(50)]
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
