using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
    public  class Answer
    {
        [Key]public string AnswerId { get; set; }
        [DataType(DataType.MultilineText)]
        public string AnswerText { get; set; }
        [MaxLength(50)]
        public bool EtatResponse { get; set; }
        [Range(0, int.MaxValue)]
        public int nbClicks { get; set; } // nombre des selections par les participants 
        [DataType(DataType.ImageUrl), Display(Name = "Image")]
        public String Image { get; set; }

        public string QuestionId { get; set; }
        [ForeignKey("QuestionId ")]
        public virtual Question Question { get; set; }

        
    }
}
