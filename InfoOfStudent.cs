using Examination_System.Models;
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
	public partial class InfoOfStudent : Form
	{

		private student student;
		ExaminationContext _context = new ExaminationContext();
		private Subject subject;
		int mark;
		public InfoOfStudent(student student, Subject sub, int mark)
		{
			InitializeComponent();
			this.student = student;
			this.subject = sub;
			this.mark = mark;
			label1.Text = student.UserName;
			label2.Text = student.Age.ToString();
			label3.Text = subject.Name;
			label4.Text = mark.ToString();

		}
		private void InitializeDataGridView()
		{
			DataGridView dataGridView = new DataGridView();
			dataGridView.Dock = DockStyle.Fill; // Fill the entire form

			// Create columns
			dataGridView.Columns.Add("Subject", "Subject");
			dataGridView.Columns.Add("Mark", "Mark");
			dataGridView.Columns.Add("Column3", "Column 3");

			// Create rows
			List<object[]> rows = new List<object[]>();
			rows.Add(new object[] { subject.Name, mark.ToString(), "Row 1, Column 3" });
			rows.Add(new object[] { subject.Name, mark.ToString(), "Row 2, Column 3" });
			rows.Add(new object[] { subject.Name, mark.ToString(), "Row 3, Column 3" });

			// Add rows to the DataGridView
			foreach (object[] row in rows)
			{
				dataGridView.Rows.Add(row);
			}

			// Add the DataGridView to the form
			Controls.Add(dataGridView);
		}
		private void InfoOfStudent_Load(object sender, EventArgs e)
		{
			label1.Text = student.UserName;
			label2.Text = student.Age.ToString();
			label3.Text = subject.Name;
			label4.Text = mark.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Exam exam = new Exam()
			{
				Mark = mark,
				SubjectId = subject.Id,
				Duration = 2
			};

			_context.Exam.Add(exam);
			_context.SaveChanges();
			St_Ex st_Ex = new St_Ex()
			{
				studentId = student.Id,
				ExamId = exam.Id 
			};

			_context.St_Ex.Add(st_Ex);
			_context.SaveChanges();
			ExamsOfStd examsOfStd = new ExamsOfStd(student,subject,mark);
			examsOfStd.Show();
			this.Hide();

		}
	}
}
