namespace QuickQuiz.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        AnswerId = c.String(nullable: false, maxLength: 128),
                        AnswerText = c.String(),
                        EtatResponse = c.Boolean(nullable: false),
                        nbClicks = c.Int(nullable: false),
                        Image = c.String(),
                        QuestionId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.AnswerId)
                .ForeignKey("dbo.Questions", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        questionId = c.String(nullable: false, maxLength: 128),
                        QuestionText = c.String(),
                        Questiontype = c.String(maxLength: 50),
                        Video = c.String(),
                        Image = c.String(),
                        QuizId = c.String(maxLength: 128),
                        PollId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.questionId)
                .ForeignKey("dbo.Polls", t => t.PollId)
                .ForeignKey("dbo.Quiz", t => t.QuizId)
                .Index(t => t.QuizId)
                .Index(t => t.PollId);
            
            CreateTable(
                "dbo.Polls",
                c => new
                    {
                        PollId = c.String(nullable: false, maxLength: 128),
                        NbOfQuestions = c.Int(nullable: false),
                        NbOfParticipants = c.Int(nullable: false),
                        Startpoll = c.DateTime(nullable: false),
                        Finishpoll = c.DateTime(nullable: false),
                        QuizManagerId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PollId)
                .ForeignKey("dbo.Users", t => t.QuizManagerId)
                .Index(t => t.QuizManagerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IdUser = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        TenantId = c.String(maxLength: 128),
                        QmTenantId = c.String(maxLength: 128),
                        isUser = c.Int(),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.Tenants", t => t.QmTenantId)
                .ForeignKey("dbo.Tenants", t => t.TenantId)
                .Index(t => t.TenantId)
                .Index(t => t.QmTenantId);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        ScoreId = c.String(nullable: false, maxLength: 128),
                        EndUserId = c.String(nullable: false, maxLength: 128),
                        QuizId = c.String(nullable: false, maxLength: 128),
                        ScoreResult = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScoreId)
                .ForeignKey("dbo.Users", t => t.EndUserId)
                .ForeignKey("dbo.Quiz", t => t.QuizId)
                .Index(t => t.EndUserId)
                .Index(t => t.QuizId);
            
            CreateTable(
                "dbo.Quiz",
                c => new
                    {
                        IdQuiz = c.String(nullable: false, maxLength: 128),
                        QuizTitle = c.String(nullable: false, maxLength: 50),
                        Size = c.Int(nullable: false),
                        StartQuiz = c.DateTime(nullable: false),
                        FinishQuiz = c.DateTime(nullable: false),
                        Time = c.Time(nullable: false, precision: 7),
                        QuizManagerId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.IdQuiz)
                .ForeignKey("dbo.Users", t => t.QuizManagerId)
                .Index(t => t.QuizManagerId);
            
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
            
            CreateTable(
                "dbo.EndUserPoll",
                c => new
                    {
                        Poll = c.String(nullable: false, maxLength: 128),
                        EndUser = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Poll, t.EndUser })
                .ForeignKey("dbo.Polls", t => t.Poll, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.EndUser, cascadeDelete: true)
                .Index(t => t.Poll)
                .Index(t => t.EndUser);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Questions", "QuizId", "dbo.Quiz");
            DropForeignKey("dbo.Questions", "PollId", "dbo.Polls");
            DropForeignKey("dbo.Polls", "QuizManagerId", "dbo.Users");
            DropForeignKey("dbo.EndUserPoll", "EndUser", "dbo.Users");
            DropForeignKey("dbo.EndUserPoll", "Poll", "dbo.Polls");
            DropForeignKey("dbo.Users", "TenantId", "dbo.Tenants");
            DropForeignKey("dbo.Scores", "QuizId", "dbo.Quiz");
            DropForeignKey("dbo.Quiz", "QuizManagerId", "dbo.Users");
            DropForeignKey("dbo.Users", "QmTenantId", "dbo.Tenants");
            DropForeignKey("dbo.Scores", "EndUserId", "dbo.Users");
            DropIndex("dbo.EndUserPoll", new[] { "EndUser" });
            DropIndex("dbo.EndUserPoll", new[] { "Poll" });
            DropIndex("dbo.Quiz", new[] { "QuizManagerId" });
            DropIndex("dbo.Scores", new[] { "QuizId" });
            DropIndex("dbo.Scores", new[] { "EndUserId" });
            DropIndex("dbo.Users", new[] { "QmTenantId" });
            DropIndex("dbo.Users", new[] { "TenantId" });
            DropIndex("dbo.Polls", new[] { "QuizManagerId" });
            DropIndex("dbo.Questions", new[] { "PollId" });
            DropIndex("dbo.Questions", new[] { "QuizId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.EndUserPoll");
            DropTable("dbo.Tenants");
            DropTable("dbo.Quiz");
            DropTable("dbo.Scores");
            DropTable("dbo.Users");
            DropTable("dbo.Polls");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
