using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Configuration
{
    class TenantConfiguration:EntityTypeConfiguration<Tenant>
    {
        public TenantConfiguration()
        {
            ToTable("Tenants");
          
    

        }
    }
}
