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
        public string AnswerName { get; set; }
        public bool EtatResponse { get; set; }
        public int nbClick { get; set; }//pour les click des reponse 

        public virtual Question Question { get; set; }

         public string QuestionId { get; set; }
        
    }
}
