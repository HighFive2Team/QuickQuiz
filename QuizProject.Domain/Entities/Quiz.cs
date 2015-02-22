using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
    public  class Quiz
    {
        [Key]public string IdQuiz { get; set; }
        public string QuizTitle { get; set; }
        public int Size { get; set; }
        //private List<Question> Questionlist { get; set; }
        public DateTime StartQuiz { get; set; }
        public DateTime FinishQuiz { get; set; }
        public TimeSpan Time { get; set; }

        public string QuizManagerId { get; set; }

        public virtual QuizManager QuizManager { get; set; }
        public virtual ICollection<EndUser> EndUsers { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Score> Scores { get; set; }

        

        
    }
}
