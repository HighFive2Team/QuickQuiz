using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Configuration
{
    class QuizManagerConfiguration : EntityTypeConfiguration<QuizManager>
    {
        public QuizManagerConfiguration()
        {
            HasOptional(t => t.Tenant)
                
                .WithMany(m => m.QuizManagers)
                .HasForeignKey(t => t.QmTenantId)
                .WillCascadeOnDelete(true);

        }
    }
}
