﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
   public  class Poll
    {
       [Key]public string PollId { get; set; }
       public int NbOfQuestions{ get; set; }
       public int NbOfParticipants { get; set; }
      
       public DateTime Startpoll { get; set; }
       public DateTime Finishpoll { get; set; }
       public string QuizManagerId { get; set; }
       public virtual QuizManager QuizManager { get; set; }

       public virtual ICollection<EndUser> EndUsers { get; set; }
       public virtual ICollection<Question> Questions { get; set; }

       

       
    }
}
