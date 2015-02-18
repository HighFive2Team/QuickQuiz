using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject.Domain
{
   public partial class Poll
    {
       [Key]public string IdPoll { get; set; }
       public int Size { get; set; }
       public int nbparticipant { get; set; }
      
       public DateTime Startpoll { get; set; }
       public DateTime Finishpoll { get; set; }
       public List<Question> QuestionPollList { get; set; }
       public virtual QuizManager QuizManager { get; set; }
       public virtual ICollection<EndUser> EndUsers { get; set; }
       public virtual ICollection<Question> Questions { get; set; }

       public string QuizManagerId { get; set; }
       

       
    }
}
