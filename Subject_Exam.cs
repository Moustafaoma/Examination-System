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
	public partial class Subject_Exam : Form
	{
		System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
		ExaminationContext _context = new ExaminationContext();
		private student student;
		List<Questions> questions = new List<Questions>();
		private Subject subject;
		public Subject_Exam(int sub_id, student student)
		{
			InitializeComponent();
			timer.Interval = 20000; 
			timer.Tick += Timer_Tick; 
			timer.Start(); 
			this.student = student;
			questions = _context.Questions.Where(q => q.SubjectId == sub_id).ToList();
			subject = _context.Subjects.FirstOrDefault(s => s.Id == sub_id);
			Shuffle(questions);
			int yOffset = 50;
			int spacing = 100;
		
			foreach (Questions q in questions)
			{

				Panel questionPanel = new Panel();
				questionPanel.Size = new System.Drawing.Size(900, 50);
				questionPanel.Location = new Point(50, yOffset);

				Label questionNumberLabel = new Label();
				questionNumberLabel.Text = "Question";
				questionNumberLabel.Size = new System.Drawing.Size(80, 26);
				questionNumberLabel.Font = new Font("Arial", 9, FontStyle.Regular);
				questionNumberLabel.Location = new Point(0, 0);

				Label questionLabel = new Label();
				questionLabel.Text = q.Body;
				questionLabel.Name = "questionLabel";
				questionLabel.Size = new System.Drawing.Size(820, 26);
				questionLabel.Font = new Font("Arial", 9, FontStyle.Regular);
				questionLabel.Location = new Point(80, 0);

				RadioButton trueRadioButton = new RadioButton();
				trueRadioButton.Text = "true";
				trueRadioButton.Location = new Point(100, 25);

				RadioButton falseRadioButton = new RadioButton();
				falseRadioButton.Text = "false";
				falseRadioButton.Location = new Point(questionPanel.Width / 2 + 50, 25);

				questionPanel.Controls.Add(questionNumberLabel);
				questionPanel.Controls.Add(questionLabel);
				questionPanel.Controls.Add(trueRadioButton);
				questionPanel.Controls.Add(falseRadioButton);

				this.Controls.Add(questionPanel);

				yOffset += 60; 

			}
		}


		private void Exam_Load(object sender, EventArgs e)
		{

		}
		private static void Shuffle<T>(IList<T> list)
		{
			Random rng = new Random();
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			// Stop the timer
			timer.Stop();
			// Hide the form
			this.Hide();
	}
		private void button1_Click(object sender, EventArgs e)
		{
			int mark = 0; 

			
			foreach (Control control in this.Controls)
			{
				if (control is Panel questionPanel)
				{
				
					Label questionLabel = questionPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "questionLabel");
					RadioButton selectedRadioButton = questionPanel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

					if (questionLabel != null && selectedRadioButton != null)
					{
						Questions question = questions.FirstOrDefault(q => q.Body == questionLabel.Text);

						if (question != null)
						{
							if (selectedRadioButton.Text == question.Answer)
							{
								mark+=5; 
							}
						}
					}
				}
			}
			//MessageBox.Show("Your mark: " + mark);
			InfoOfStudent infoOfStudent = new InfoOfStudent(student, subject, mark);
			infoOfStudent.Show();
			this.Hide();
		}

	}
}
