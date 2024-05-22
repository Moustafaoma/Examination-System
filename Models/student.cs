using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Models
{
    public class student
    {
        public int Id { get; set; }
		[Required(ErrorMessage = "Username is required")]
		[StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 3)]
		public string UserName { get; set; }
        //[AllowNull]
        //public int TotalMarks { get; set; }
		[Required(ErrorMessage = "Password is required")]
		[StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
		[DataType(DataType.Password)]
		public string Password { get; set; }
        
        public int Age { get; set; }
        //[AllowNull]
        //public int Mark { get; set; }

        public virtual ICollection<Student_Subjects> Subjects { get; set; } 
    }
}
