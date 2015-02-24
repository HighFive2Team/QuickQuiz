using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
   public  class Poll
    {
       [Key]public string PollId { get; set; }
       [Range(1, int.MaxValue)]
       public int NbOfQuestions{ get; set; }
       [Range(0, int.MaxValue)]
       public int NbOfParticipants { get; set; }
       [Display(Name = "Date of starting")]
       [DataType(DataType.DateTime)]
       public DateTime Startpoll { get; set; }
       [Display(Name = "Date of finishing")]
       [DataType(DataType.DateTime)]
       public DateTime Finishpoll { get; set; }
       public string QuizManagerId { get; set; }

      [ForeignKey("QuizManagerId")]
       public virtual QuizManager QuizManager { get; set; }

       public virtual ICollection<EndUser> EndUsers { get; set; }
       public virtual ICollection<Question> Questions { get; set; }

       

       
    }
}
