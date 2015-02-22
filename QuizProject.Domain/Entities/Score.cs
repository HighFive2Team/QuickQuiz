using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
    public  class Score
    {
        [Key]
        public string Idscore { get; set; }
        public int ScoreResult { get; set; }


        public virtual EndUser EndUser { get; set; }
        public virtual Quiz Quiz { get; set; }

        public string EndUserId { get; set; }
        public string QuizId { get; set; }

      

    }
}
