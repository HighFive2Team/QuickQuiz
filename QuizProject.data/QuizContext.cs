﻿using QuickQuiz.Data.Configuration;
using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.Entity.Validation;


namespace QuickQuiz.Data.Infrastructure
{
   public class QuizContext: DbContext  
    {
       public QuizContext()
           : base("Name=QuickQuiz_db")
       {
                       this.Configuration.LazyLoadingEnabled = false;
                  }

       public DbSet<User> Users { get; set; }
       public DbSet<Tenant> Tenants { get; set; }
       public DbSet<Quiz> Quizzes { get; set; }
       public DbSet<Answer> Answers { get; set; }
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
           modelBuilder.Configurations.Add(new EndUserConfiguration());
           modelBuilder.Configurations.Add(new QuizManagerConfiguration());
           
       }

       public  override int SaveChanges()
       {
           try
           {
               return base.SaveChanges();
           }
           catch (DbEntityValidationException dbEx)
           {
               foreach (var validationErrors in dbEx.EntityValidationErrors)
               {
                   foreach (var validationError in validationErrors.ValidationErrors)
                   {
                       Trace.TraceInformation("Class: {0}, Property: {1}, Error: {2}",
                           validationErrors.Entry.Entity.GetType().FullName,
                           validationError.PropertyName,
                           validationError.ErrorMessage);
                   }
               }

               throw;
           }
       }
    }
}
