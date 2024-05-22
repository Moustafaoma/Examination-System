using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Models
{
    public class Student_Subjects
    {
        public int Id { get; set; }
        public int studentId { get; set; }
        [AllowNull]
        public int? SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual student Student { get; set; }

    }
}
