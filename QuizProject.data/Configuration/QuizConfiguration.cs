﻿using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Configuration
{
    public class QuizConfiguration:EntityTypeConfiguration<Quiz>
    {
        public QuizConfiguration()
        {
            ToTable("Quiz");
            HasKey(q => q.IdQuiz);
            HasRequired(qm => qm.QuizManager).WithMany(q => q.Quiz) .HasForeignKey(qm => qm.QuizManagerID) .WillCascadeOnDelete(false);//one to many
            HasMany(qu => qu.EndUsers).WithMany(q => q.Quizs).Map(m => { m.ToTable("QuizResponse"); 
                    m.MapLeftKey("Quiz");
                    m.MapRightKey("Users"); });

            //tous les champs monquent les proprietés sur les attribut dans la base de donnée
           
        }
    }
}
