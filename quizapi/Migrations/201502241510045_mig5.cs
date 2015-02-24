namespace quizapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        IdUser = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser);
            
            CreateTable(
                "dbo.Polls",
                c => new
                    {
                        PollId = c.String(nullable: false, maxLength: 128),
                        NbOfQuestions = c.Int(nullable: false),
                        NbOfParticipants = c.Int(nullable: false),
                        Startpoll = c.DateTime(nullable: false),
                        Finishpoll = c.DateTime(nullable: false),
                        QuizManagerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PollId)
                .ForeignKey("dbo.QuizManagers", t => t.QuizManagerId)
                .Index(t => t.QuizManagerId);
            
            CreateTable(
                "dbo.EndUsers",
                c => new
                    {
                        IdUser = c.String(nullable: false, maxLength: 128),
                        TenantId = c.String(maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.Tenants", t => t.TenantId)
                .Index(t => t.TenantId);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        ScoreId = c.String(nullable: false, maxLength: 128),
                        EndUserId = c.String(),
                        QuizId = c.String(),
                        ScoreResult = c.Int(nullable: false),
                        EndUser_IdUser = c.String(maxLength: 128),
                        Quiz_IdQuiz = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ScoreId)
                .ForeignKey("dbo.EndUsers", t => t.EndUser_IdUser)
                .ForeignKey("dbo.Quizs", t => t.Quiz_IdQuiz)
                .Index(t => t.EndUser_IdUser)
                .Index(t => t.Quiz_IdQuiz);
            
            CreateTable(
                "dbo.Quizs",
                c => new
                    {
                        IdQuiz = c.String(nullable: false, maxLength: 128),
                        QuizTitle = c.String(nullable: false, maxLength: 50),
                        Size = c.Int(nullable: false),
                        StartQuiz = c.DateTime(nullable: false),
                        FinishQuiz = c.DateTime(nullable: false),
                        Time = c.Time(nullable: false, precision: 7),
                        QuizManagerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IdQuiz)
                .ForeignKey("dbo.QuizManagers", t => t.QuizManagerId)
                .Index(t => t.QuizManagerId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        questionId = c.String(nullable: false, maxLength: 128),
                        QuestionText = c.String(),
                        Questiontype = c.String(maxLength: 50),
                        Video = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.questionId);
            
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        AnswerId = c.String(nullable: false, maxLength: 128),
                        AnswerText = c.String(),
                        EtatResponse = c.Boolean(nullable: false),
                        nbClicks = c.Int(nullable: false),
                        Image = c.String(),
                        QuestionId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AnswerId)
                .ForeignKey("dbo.Questions", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.QuizManagers",
                c => new
                    {
                        IdUser = c.String(nullable: false, maxLength: 128),
                        QmTenantId = c.String(maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.Tenants", t => t.QmTenantId)
                .Index(t => t.QmTenantId);
            
            CreateTable(
                "dbo.Tenants",
                c => new
                    {
                        IdUser = c.String(nullable: false, maxLength: 128),
                        TenantName = c.String(nullable: false, maxLength: 50),
                        Country = c.String(nullable: false, maxLength: 50),
                        ZipCode = c.Int(nullable: false),
                        OfferType = c.String(maxLength: 50),
                        Logo = c.String(),
                        Slogan = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser);
            
            CreateTable(
                "dbo.EndUserPolls",
                c => new
                    {
                        EndUser_IdUser = c.String(nullable: false, maxLength: 128),
                        Poll_PollId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.EndUser_IdUser, t.Poll_PollId })
                .ForeignKey("dbo.EndUsers", t => t.EndUser_IdUser, cascadeDelete: true)
                .ForeignKey("dbo.Polls", t => t.Poll_PollId, cascadeDelete: true)
                .Index(t => t.EndUser_IdUser)
                .Index(t => t.Poll_PollId);
            
            CreateTable(
                "dbo.QuestionPolls",
                c => new
                    {
                        Question_questionId = c.String(nullable: false, maxLength: 128),
                        Poll_PollId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Question_questionId, t.Poll_PollId })
                .ForeignKey("dbo.Questions", t => t.Question_questionId, cascadeDelete: true)
                .ForeignKey("dbo.Polls", t => t.Poll_PollId, cascadeDelete: true)
                .Index(t => t.Question_questionId)
                .Index(t => t.Poll_PollId);
            
            CreateTable(
                "dbo.QuestionQuizs",
                c => new
                    {
                        Question_questionId = c.String(nullable: false, maxLength: 128),
                        Quiz_IdQuiz = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Question_questionId, t.Quiz_IdQuiz })
                .ForeignKey("dbo.Questions", t => t.Question_questionId, cascadeDelete: true)
                .ForeignKey("dbo.Quizs", t => t.Quiz_IdQuiz, cascadeDelete: true)
                .Index(t => t.Question_questionId)
                .Index(t => t.Quiz_IdQuiz);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scores", "Quiz_IdQuiz", "dbo.Quizs");
            DropForeignKey("dbo.QuizManagers", "QmTenantId", "dbo.Tenants");
            DropForeignKey("dbo.EndUsers", "TenantId", "dbo.Tenants");
            DropForeignKey("dbo.Quizs", "QuizManagerId", "dbo.QuizManagers");
            DropForeignKey("dbo.Polls", "QuizManagerId", "dbo.QuizManagers");
            DropForeignKey("dbo.QuestionQuizs", "Quiz_IdQuiz", "dbo.Quizs");
            DropForeignKey("dbo.QuestionQuizs", "Question_questionId", "dbo.Questions");
            DropForeignKey("dbo.QuestionPolls", "Poll_PollId", "dbo.Polls");
            DropForeignKey("dbo.QuestionPolls", "Question_questionId", "dbo.Questions");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Scores", "EndUser_IdUser", "dbo.EndUsers");
            DropForeignKey("dbo.EndUserPolls", "Poll_PollId", "dbo.Polls");
            DropForeignKey("dbo.EndUserPolls", "EndUser_IdUser", "dbo.EndUsers");
            DropIndex("dbo.QuestionQuizs", new[] { "Quiz_IdQuiz" });
            DropIndex("dbo.QuestionQuizs", new[] { "Question_questionId" });
            DropIndex("dbo.QuestionPolls", new[] { "Poll_PollId" });
            DropIndex("dbo.QuestionPolls", new[] { "Question_questionId" });
            DropIndex("dbo.EndUserPolls", new[] { "Poll_PollId" });
            DropIndex("dbo.EndUserPolls", new[] { "EndUser_IdUser" });
            DropIndex("dbo.QuizManagers", new[] { "QmTenantId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropIndex("dbo.Quizs", new[] { "QuizManagerId" });
            DropIndex("dbo.Scores", new[] { "Quiz_IdQuiz" });
            DropIndex("dbo.Scores", new[] { "EndUser_IdUser" });
            DropIndex("dbo.EndUsers", new[] { "TenantId" });
            DropIndex("dbo.Polls", new[] { "QuizManagerId" });
            DropTable("dbo.QuestionQuizs");
            DropTable("dbo.QuestionPolls");
            DropTable("dbo.EndUserPolls");
            DropTable("dbo.Tenants");
            DropTable("dbo.QuizManagers");
            DropTable("dbo.Answers");
            DropTable("dbo.Questions");
            DropTable("dbo.Quizs");
            DropTable("dbo.Scores");
            DropTable("dbo.EndUsers");
            DropTable("dbo.Polls");
            DropTable("dbo.Admins");
        }
    }
}
