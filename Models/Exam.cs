using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Models
{
    public class Exam
    {
        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int Id { get; set; }
        public int Mark { get; set; }
        public int Duration { get; set; }
        [ForeignKey("Subject")]
        public int? SubjectId { get; set; }
        public virtual ICollection<St_Ex>? StudentsExam  { get; set; }
        public virtual ICollection<Questions>? Questions { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
