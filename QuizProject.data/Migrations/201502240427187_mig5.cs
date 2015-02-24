namespace QuickQuiz.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.QuestionPoll", name: "Poll", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.QuestionPoll", name: "Question", newName: "Poll");
            RenameColumn(table: "dbo.QuestionPoll", name: "__mig_tmp__0", newName: "Question");
            RenameIndex(table: "dbo.QuestionPoll", name: "IX_Poll", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.QuestionPoll", name: "IX_Question", newName: "IX_Poll");
            RenameIndex(table: "dbo.QuestionPoll", name: "__mig_tmp__0", newName: "IX_Question");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.QuestionPoll", name: "IX_Question", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.QuestionPoll", name: "IX_Poll", newName: "IX_Question");
            RenameIndex(table: "dbo.QuestionPoll", name: "__mig_tmp__0", newName: "IX_Poll");
            RenameColumn(table: "dbo.QuestionPoll", name: "Question", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.QuestionPoll", name: "Poll", newName: "Question");
            RenameColumn(table: "dbo.QuestionPoll", name: "__mig_tmp__0", newName: "Poll");
        }
    }
}
