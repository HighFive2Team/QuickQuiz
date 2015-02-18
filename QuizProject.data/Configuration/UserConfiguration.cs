using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data
{
   public class UserConfiguration:EntityTypeConfiguration<User>
    {

       public UserConfiguration()
       {
           ToTable("Users");
           HasKey(u => u.IdUser); 
           
          HasRequired(t => t.tenant).WithMany(u =>u.Users).HasForeignKey(t =>t.TenantId).WillCascadeOnDelete(false);

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
          

           //tous les champs monquent les proprietés sur les attribut dans la base de donnée
           
       }


       
    }
}
