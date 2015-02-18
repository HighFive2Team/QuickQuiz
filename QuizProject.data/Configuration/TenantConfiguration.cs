using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Configuration
{
    class TenantConfiguration:EntityTypeConfiguration<Tenant>
    {
        public TenantConfiguration()
        {
            ToTable("Tenants");
            HasKey(t => t.IdTenant); 
    
            //tous les champs monquent les proprietés sur les attribut dans la base de donnée 

        }
    }
}
