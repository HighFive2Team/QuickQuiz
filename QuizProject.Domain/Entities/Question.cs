using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.Domain
{
   public partial class Question
    {
       [Key]public string Idquestion { get; set; }
       public string QuestionName { get; set; }
       private List<Answer> AnswerList { get; set; }
       public string Questiontype{get;set;}//pour savoir est ce que le question pour le quiz ou Poll
       public string Video { get; set; }
       public string Shart { get; set; }


       public virtual ICollection<Answer> Answers { get; set; }
       public virtual ICollection<Quiz> Quizs { get; set; }
       public virtual ICollection<Poll> Polls { get; set; }

       
    }
}
