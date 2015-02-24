namespace QuickQuiz.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "TenantId1", newName: "QmTenantId");
            RenameIndex(table: "dbo.Users", name: "IX_TenantId1", newName: "IX_QmTenantId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Users", name: "IX_QmTenantId", newName: "IX_TenantId1");
            RenameColumn(table: "dbo.Users", name: "QmTenantId", newName: "TenantId1");
        }
    }
}
