using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.Domain
{
    public partial class Answer
    {
        [Key]public string IdAnswer { get; set; }
        public string AnswerText { get; set; }
        public bool EtatResponse { get; set; }
        public int nbClicks { get; set; } // nombre des selections par les participants 

        public virtual Question Question { get; set; }

        public string QuestionId { get; set; }
        
    }
}
