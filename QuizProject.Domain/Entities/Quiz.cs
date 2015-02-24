using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz.Domain
{
    public  class Quiz
    {
        [Key]public string IdQuiz { get; set; }

        [Required(ErrorMessage = "Title is  Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
        [MaxLength(50)]
        public string QuizTitle { get; set; }
      
        public int Size { get; set; }
        //private List<Question> Questionlist { get; set; }
        [Display(Name = " Date of starting")]
        [DataType(DataType.DateTime)]
        public DateTime StartQuiz { get; set; }
        [Display(Name = " Date of finishing")]
        [DataType(DataType.DateTime)]
        public DateTime FinishQuiz { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }

        public string QuizManagerId { get; set; }
        [ForeignKey("QuizManagerId ")]
        public virtual QuizManager QuizManager { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Score> Scores { get; set; }

        

        
    }
}
