using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
    public partial class User
    {
        [Key]public string IdUser { get; set; }

        [Required(ErrorMessage = " name required")]
        [StringLength(25, ErrorMessage = "must be then 25 characters")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = " name required")]
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

    



         }
}
