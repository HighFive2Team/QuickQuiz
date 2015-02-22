using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.Domain
{
   public  class Question
    {
       [Key]public string questionId { get; set; }
       public string QuestionText{ get; set; }
       public string Questiontype{get;set;}
       public string Video { get; set; }
       public string Image { get; set; }


       public virtual ICollection<Answer> Answers { get; set; }
       public virtual ICollection<Quiz> Quizs { get; set; }
       public virtual ICollection<Poll> Polls { get; set; }

       
    }
}
