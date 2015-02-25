namespace QuickQuiz.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migx : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tenants",
                c => new
                    {
                        IdTenant = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        TenantName = c.String(nullable: false, maxLength: 50),
                        Country = c.String(nullable: false, maxLength: 50),
                        ZipCode = c.Int(nullable: false),
                        OfferType = c.String(maxLength: 50),
                        Logo = c.String(),
                        Slogan = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdTenant);
            
     
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Slogan", c => c.String(maxLength: 50));
            AddColumn("dbo.Users", "Logo", c => c.String());
            AddColumn("dbo.Users", "OfferType", c => c.String(maxLength: 50));
            AddColumn("dbo.Users", "ZipCode", c => c.Int());
            AddColumn("dbo.Users", "Country", c => c.String(maxLength: 50));
            AddColumn("dbo.Users", "TenantName", c => c.String(maxLength: 50));
            DropTable("dbo.Tenants");
        }
    }
}
