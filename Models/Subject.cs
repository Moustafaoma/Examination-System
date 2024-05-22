using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public virtual ICollection<Student_Subjects>? Students { get; set; }
    }
}
