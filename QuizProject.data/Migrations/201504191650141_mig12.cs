namespace QuickQuiz.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Questions", "PollId", "dbo.Polls");
            DropForeignKey("dbo.Questions", "QuizId", "dbo.Quiz");
            DropForeignKey("dbo.Scores", "EndUserId", "dbo.Users");
            DropForeignKey("dbo.Scores", "QuizId", "dbo.Quiz");
            DropForeignKey("dbo.Users", "QmTenantId", "dbo.Tenants");
            DropIndex("dbo.Polls", new[] { "QuizManagerId" });
            AlterColumn("dbo.Polls", "QuizManagerId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Polls", "QuizManagerId");
            AddForeignKey("dbo.Answers", "QuestionId", "dbo.Questions", "questionId", cascadeDelete: true);
            AddForeignKey("dbo.Questions", "PollId", "dbo.Polls", "PollId", cascadeDelete: true);
            AddForeignKey("dbo.Questions", "QuizId", "dbo.Quiz", "IdQuiz", cascadeDelete: true);
            AddForeignKey("dbo.Scores", "EndUserId", "dbo.Users", "IdUser", cascadeDelete: true);
            AddForeignKey("dbo.Scores", "QuizId", "dbo.Quiz", "IdQuiz", cascadeDelete: true);
            AddForeignKey("dbo.Users", "QmTenantId", "dbo.Tenants", "IdTenant", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "QmTenantId", "dbo.Tenants");
            DropForeignKey("dbo.Scores", "QuizId", "dbo.Quiz");
            DropForeignKey("dbo.Scores", "EndUserId", "dbo.Users");
            DropForeignKey("dbo.Questions", "QuizId", "dbo.Quiz");
            DropForeignKey("dbo.Questions", "PollId", "dbo.Polls");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropIndex("dbo.Polls", new[] { "QuizManagerId" });
            AlterColumn("dbo.Polls", "QuizManagerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Polls", "QuizManagerId");
            AddForeignKey("dbo.Users", "QmTenantId", "dbo.Tenants", "IdTenant");
            AddForeignKey("dbo.Scores", "QuizId", "dbo.Quiz", "IdQuiz");
            AddForeignKey("dbo.Scores", "EndUserId", "dbo.Users", "IdUser");
            AddForeignKey("dbo.Questions", "QuizId", "dbo.Quiz", "IdQuiz");
            AddForeignKey("dbo.Questions", "PollId", "dbo.Polls", "PollId");
            AddForeignKey("dbo.Answers", "QuestionId", "dbo.Questions", "questionId");
        }
    }
}
