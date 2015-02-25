using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickQuiz.Web.Models
{
    public class TenantModel
    {

       
        public string IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }       
        public string ConfirmPassword { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; } 
        public string OfferType { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}