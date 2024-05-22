using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public string Body { get; set; }
        public string Answer { get; set; }
        public int? SubjectId { get; set; }
        public int? ExamId { get; set; }
        public virtual Exam? Exam { get; set; }
    }
}
