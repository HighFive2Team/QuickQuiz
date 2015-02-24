using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
   public  class Question
    {
       [Key]public string questionId { get; set; }

       [DataType(DataType.MultilineText)]
       public string QuestionText{ get; set; }
       [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
       [MaxLength(50)]
       public string Questiontype{get;set;}
       [DataType(DataType.Url), Display(Name = "Schema title")]
       public string Video { get; set; }
        [DataType(DataType.ImageUrl), Display(Name = "Schema title")]
       public string Image { get; set; }


       public virtual ICollection<Answer> Answers { get; set; }
       public virtual ICollection<Quiz> Quizs { get; set; }
       public virtual ICollection<Poll> Polls { get; set; }

       
    }
}
