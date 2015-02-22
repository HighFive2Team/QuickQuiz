using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
    public  class Answer
    {
        [Key]public string AnswerId { get; set; }
        public string AnswerText { get; set; }
        public bool EtatResponse { get; set; }
        public int nbClicks { get; set; } // nombre des selections par les participants 
        public String Image { get; set; }

        public string QuestionId { get; set; }
        public virtual Question Question { get; set; }

        
    }
}
