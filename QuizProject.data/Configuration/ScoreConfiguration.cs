using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Configuration
{
    public class ScoreConfiguration:EntityTypeConfiguration<Score>
    {
        public ScoreConfiguration()
        {
            ToTable("Scores");
            HasKey(s => s.ScoreId);
            
            
            HasRequired(s=>s.EndUser)
                .WithMany(u => u.Scores)
                .HasForeignKey(s =>s.EndUserId)
                .WillCascadeOnDelete(false);
            
            
            HasRequired(s => s.Quiz)
                .WithMany(u => u.Scores)
                .HasForeignKey(s => s.QuizId)
                .WillCascadeOnDelete(false);
           

            //tous les champs monquent les proprietés sur les attribut dans la base de donnée
        }
    }
}
