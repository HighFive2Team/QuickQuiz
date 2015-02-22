using QuickQuiz.Data.Configuration;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Infrastructure
{
   public class QuizContext:DbContext
    {
       public QuizContext():base("Name=DefaultConnection")
       {

       }

       public DbSet<User> Users { get; set; }
       public DbSet<Tenant> Tenants { get; set; }
       public DbSet<Quiz> Quizs { get; set; }
       public DbSet<Answer> Responses { get; set; }
       public DbSet<Score> Scores { get; set; }
       public DbSet<Question> Questions { get; set; }
       public DbSet<Poll> Polls { get; set; }
       
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Configurations.Add(new PollConfiguration());
           modelBuilder.Configurations.Add(new QuestionConfiguration());
           modelBuilder.Configurations.Add(new QuizConfiguration());
           modelBuilder.Configurations.Add(new AnswerConfiguration());
           modelBuilder.Configurations.Add(new ScoreConfiguration());
           modelBuilder.Configurations.Add(new TenantConfiguration());
           modelBuilder.Configurations.Add(new UserConfiguration());
           
       }
    }
}
