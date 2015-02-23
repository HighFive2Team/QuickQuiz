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
            ToTable("Question");
            HasKey(q => q.questionId);
            HasMany(q => q.Quizs).WithMany(qu => qu.Questions).Map(m =>
            {
                m.ToTable("QuestionQuiz");
                m.MapLeftKey("Quiz");
                m.MapRightKey("Question");
            });

            HasMany(q => q.Polls).WithMany(qu => qu.Questions).Map(m =>
            {
                m.ToTable("QuestionPoll");
                m.MapRightKey("Question");
                m.MapLeftKey("Poll");
            });

        }
    }
}
