using QuickQuiz.Domain;
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


            HasRequired(qm => qm.QuizManager)  //one to many
                .WithMany(q => q.Quizzes) 
                .HasForeignKey(qm => qm.QuizManagerId) 
                .WillCascadeOnDelete(false);
            
            
         

           
        }
    }
}
