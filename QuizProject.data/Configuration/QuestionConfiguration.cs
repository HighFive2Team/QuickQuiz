using QuickQuiz.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Data.Configuration
{
    public class QuestionConfiguration:EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            ToTable("Questions");

            HasKey(q => q.questionId);
            HasOptional(q => q.quiz)
                .WithMany(qu => qu.Questions)
                .HasForeignKey(q =>  q.QuizId) 
                .WillCascadeOnDelete(true);

            HasOptional(q => q.poll)
                .WithMany(qu => qu.Questions)
                .HasForeignKey(q => q.PollId)
                .WillCascadeOnDelete(true);

        }
    }
}
