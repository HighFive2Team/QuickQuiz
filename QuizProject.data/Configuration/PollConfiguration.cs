using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Configuration
{
    public class PollConfiguration:EntityTypeConfiguration<Poll>
    {
        public PollConfiguration()
        {
            ToTable("Poll");
            HasKey(p => p.PollId);
            HasRequired(qm => qm.QuizManager)   //one to many 
                .WithMany(p => p.Polls)
                .HasForeignKey(qm => qm.QuizManagerId)
                .WillCascadeOnDelete(false);
          
            HasMany(qu => qu.EndUsers).WithMany(p=> p.Polls).Map(m =>
            {
                m.ToTable("EndUserPoll");
                m.MapLeftKey("Poll");
                m.MapRightKey("Users");
            });

            //tous les champs monquent les proprietés sur les attribut dans la base de donnée
        }
    }
}
