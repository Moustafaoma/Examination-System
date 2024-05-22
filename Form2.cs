using Examination_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
	public partial class Form2 : Form
	{
		private student student;
		ExaminationContext _context = new ExaminationContext();
		public Form2(student student)
		{
			InitializeComponent();
			this.student = student;
			//this.Load += Form2_Load;

		}
		
		private void Form2_Load(object sender, EventArgs e)
		{
			
			label5.Text = student.UserName;
			label6.Text = student.Age.ToString();
			var studentSubjects = from s in _context.Subjects
								  join ss in _context.Student_Subjects
								  on s.Id equals ss.SubjectId
								  where ss.studentId == student.Id
								  && !_context.St_Ex.Any(se => se.Exam.SubjectId == s.Id && se.studentId == student.Id)
								  select s;



			if (studentSubjects.Any())
			{
				
						comboBox1.DataSource = studentSubjects.ToList(); // Convert to list
					comboBox1.DisplayMember = "Name"; // Assuming "Name" is 
				
				 // Assuming "Name" is the property of the subject object
			}
			else
			{
				comboBox1.Items.Add("No subjects found for the student.");
			}
		}
		string selectedSubjectName;
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem != null)
			{

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Subject selectedSubject = (Subject)comboBox1.SelectedItem;
			int selectedSubjectId = selectedSubject.Id; // Assuming there's an Id property
			Subject_Exam subject_Exam = new Subject_Exam(selectedSubjectId,student);
			subject_Exam.Show();
			this.Hide();
			
		}
	}
}
