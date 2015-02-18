using QuizProject.data.Configuration;
using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Infrastructure
{
   public class QuizContext:DbContext
    {
       public QuizContext():base("Name=QuizProject")
       {

       }

       public DbSet<User> User { get; set; }
       public DbSet<Tenant> Tenant { get; set; }
       public DbSet<Quiz> Quiz { get; set; }
       public DbSet<Answer> Response { get; set; }
       public DbSet<Score> Score { get; set; }
       public DbSet<Question> Question { get; set; }
       public DbSet<Poll> Poll { get; set; }
       
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
