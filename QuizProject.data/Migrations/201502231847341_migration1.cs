namespace QuickQuiz.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
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
                        Questiontype = c.String(),
                        Video = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.questionId);
            
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
                        TenantId1 = c.String(maxLength: 128),
                        isUser = c.Int(),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.Tenants", t => t.TenantId1)
                .ForeignKey("dbo.Tenants", t => t.TenantId)
                .Index(t => t.TenantId)
                .Index(t => t.TenantId1);
            
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
                        QuizTitle = c.String(),
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
            
            CreateTable(
                "dbo.QuestionPoll",
                c => new
                    {
                        Poll = c.String(nullable: false, maxLength: 128),
                        Question = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Poll, t.Question })
                .ForeignKey("dbo.Questions", t => t.Poll, cascadeDelete: true)
                .ForeignKey("dbo.Polls", t => t.Question, cascadeDelete: true)
                .Index(t => t.Poll)
                .Index(t => t.Question);
            
            CreateTable(
                "dbo.QuestionQuiz",
                c => new
                    {
                        Quiz = c.String(nullable: false, maxLength: 128),
                        Question = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Quiz, t.Question })
                .ForeignKey("dbo.Questions", t => t.Quiz, cascadeDelete: true)
                .ForeignKey("dbo.Quiz", t => t.Question, cascadeDelete: true)
                .Index(t => t.Quiz)
                .Index(t => t.Question);
            
            CreateTable(
                "dbo.Tenants",
                c => new
                    {
                        IdUser = c.String(nullable: false, maxLength: 128),
                        TenantName = c.String(nullable: false),
                        Country = c.String(),
                        ZipCode = c.Int(nullable: false),
                        OfferType = c.String(),
                        Logo = c.String(),
                        Slogan = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.Users", t => t.IdUser)
                .Index(t => t.IdUser);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tenants", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.QuestionQuiz", "Question", "dbo.Quiz");
            DropForeignKey("dbo.QuestionQuiz", "Quiz", "dbo.Questions");
            DropForeignKey("dbo.QuestionPoll", "Question", "dbo.Polls");
            DropForeignKey("dbo.QuestionPoll", "Poll", "dbo.Questions");
            DropForeignKey("dbo.Polls", "QuizManagerId", "dbo.Users");
            DropForeignKey("dbo.EndUserPoll", "EndUser", "dbo.Users");
            DropForeignKey("dbo.EndUserPoll", "Poll", "dbo.Polls");
            DropForeignKey("dbo.Users", "TenantId", "dbo.Tenants");
            DropForeignKey("dbo.Scores", "QuizId", "dbo.Quiz");
            DropForeignKey("dbo.Quiz", "QuizManagerId", "dbo.Users");
            DropForeignKey("dbo.Users", "TenantId1", "dbo.Tenants");
            DropForeignKey("dbo.Scores", "EndUserId", "dbo.Users");
            DropIndex("dbo.Tenants", new[] { "IdUser" });
            DropIndex("dbo.QuestionQuiz", new[] { "Question" });
            DropIndex("dbo.QuestionQuiz", new[] { "Quiz" });
            DropIndex("dbo.QuestionPoll", new[] { "Question" });
            DropIndex("dbo.QuestionPoll", new[] { "Poll" });
            DropIndex("dbo.EndUserPoll", new[] { "EndUser" });
            DropIndex("dbo.EndUserPoll", new[] { "Poll" });
            DropIndex("dbo.Quiz", new[] { "QuizManagerId" });
            DropIndex("dbo.Scores", new[] { "QuizId" });
            DropIndex("dbo.Scores", new[] { "EndUserId" });
            DropIndex("dbo.Users", new[] { "TenantId1" });
            DropIndex("dbo.Users", new[] { "TenantId" });
            DropIndex("dbo.Polls", new[] { "QuizManagerId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.Tenants");
            DropTable("dbo.QuestionQuiz");
            DropTable("dbo.QuestionPoll");
            DropTable("dbo.EndUserPoll");
            DropTable("dbo.Quiz");
            DropTable("dbo.Scores");
            DropTable("dbo.Users");
            DropTable("dbo.Polls");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
