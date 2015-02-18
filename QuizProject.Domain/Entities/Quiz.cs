using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.Domain
{
    public partial class Quiz
    {
        [Key]public string IdQuiz { get; set; }
        public string SuizType { get; set; }
        public string Image { get; set; }
        public int Size { get; set; }
        //private List<Question> Questionlist { get; set; }
        public DateTime StartQuiz { get; set; }
        public DateTime FinishQuiz { get; set; }
        public TimeSpan Time { get; set; }
        public List<Question> QuestionQuizList { get; set; }
        

        public virtual QuizManager QuizManager { get; set; }
        public virtual ICollection<EndUser> EndUsers { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Score> Score { get; set; }

        public string QuizManagerID { get; set; }
        

        
    }
}
