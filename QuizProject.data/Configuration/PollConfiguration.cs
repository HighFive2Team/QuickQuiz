using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Configuration
{
    public class PollConfiguration:EntityTypeConfiguration<Poll>
    {
        public PollConfiguration()
        {
            ToTable("Poll");
            HasKey(p => p.IdPoll);
            HasRequired(qm => qm.QuizManager).WithMany(p => p.Poll).HasForeignKey(qm => qm.QuizManagerId).WillCascadeOnDelete(false);//one to many 
            HasMany(qu => qu.EndUsers).WithMany(p=> p.Polls).Map(m =>
            {
                m.ToTable("PollResponse");
                m.MapLeftKey("Poll");
                m.MapRightKey("Users");
            });

            //tous les champs monquent les proprietés sur les attribut dans la base de donnée
        }
    }
}
