using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Configuration
{
    class EndUserConfiguration : EntityTypeConfiguration<EndUser>
    {
        public EndUserConfiguration()
        {
            HasRequired(t => t.Tenant).WithMany(e => e.EndUsers).HasForeignKey(t => t.TenantId).WillCascadeOnDelete(false);

        }
    }
}
