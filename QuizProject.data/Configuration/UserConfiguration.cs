using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data
{
   public class UserConfiguration:EntityTypeConfiguration<User> 
    {

       public UserConfiguration()
       {
           ToTable("Users");
           HasKey(u => u.IdUser); 
           
          Map<EndUser>(p =>
          {             
              p.Requires("isUser").HasValue(0);
            });
          Map<QuizManager>(p =>
          {
              p.Requires("isUser").HasValue(1);

          });
          Map<Admin>(p =>
          {
              p.Requires("isUser").HasValue(2);

          });
         
          

           
       }


       
    }
}
