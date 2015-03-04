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
            HasMany(q => q.Quizs).WithMany(qu => qu.Questions).Map(m =>
            {
                m.ToTable("QuestionQuiz");
                m.MapLeftKey("Question"); 
                m.MapRightKey("Quiz");
                

            });

            HasMany(q => q.Polls).WithMany(qu => qu.Questions).Map(m =>
            {
                m.ToTable("QuestionPoll");
                m.MapLeftKey("Question");
                m.MapRightKey("Poll");
            });

        }
    }
}
