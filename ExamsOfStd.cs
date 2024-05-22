using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
	public partial class ExamsOfStd : Form
	{
		ExaminationContext _context=new ExaminationContext();
		private student student;
		private Subject subject;
		int mark;
		public ExamsOfStd(student student, Subject subject, int mark)
		{
			InitializeComponent();
			this.student = student;
			this.subject = subject;
			this.mark = mark;	
		}

		private void ExamsOfStd_Load(object sender, EventArgs e)
		{
			var std_Exams = _context.St_Ex.Include(s => s.Exam).Where(st => st.studentId == student.Id).ToList();
			var subject_names = from std_ex in std_Exams
								join Subject in _context.Subjects on std_ex.Exam.SubjectId equals subject.Id
								select subject.Name;
			DataGridView dataGridView = new DataGridView();
			dataGridView.Dock = DockStyle.Fill; // Fill the entire form
			dataGridView.Columns.Add("SubjectNameColumn", "Subject Name");
			dataGridView.Columns.Add("MarkColumn", "Mark");

			foreach (var std_exam in std_Exams)
{
				string subjectName = _context.Subjects
											  .Where(s => s.Id == std_exam.Exam.SubjectId)
											  .Select(s => s.Name)
											  .FirstOrDefault();
				int stdMark = _context.Exam
						 .Where(e => e.Id == std_exam.ExamId)
						 .Select(e => e.Mark)
						 .FirstOrDefault();

				dataGridView.Rows.Add(subjectName, stdMark+" / 25");
			}

			Controls.Add(dataGridView);


		}
	}
}
