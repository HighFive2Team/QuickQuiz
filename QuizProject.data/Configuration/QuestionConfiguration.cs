using QuizProject.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.data.Configuration
{
    public class QuestionConfiguration:EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            ToTable("Question");
            HasKey(q => q.Idquestion);
            HasMany(q => q.Quizs).WithMany(qu => qu.Questions).Map(m =>
            {
                m.ToTable("QuestionQuiz");
                m.MapLeftKey("Quiz");
                m.MapRightKey("Question");
            });
            HasMany(q => q.Polls).WithMany(qu => qu.Questions).Map(m =>
            {
                m.ToTable("PollResponse");
                m.MapLeftKey("Poll");
                m.MapRightKey("Question");
            });

            //tous les champs monquent les proprietés sur les attribut dans la base de donnée
        }
    }
}
