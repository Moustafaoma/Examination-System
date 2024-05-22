using Examination_System.Models;
namespace Examination_System
{
	public partial class Form1 : Form
	{
		ExaminationContext _context = new ExaminationContext();
		public Form1()
		{
			InitializeComponent();

		}


		private void LogIn_Click(object sender, EventArgs e)
		{
			var user_Name = textBox1.Text;
			var password = textBox2.Text;
			if (string.IsNullOrEmpty(user_Name) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Please enter both username and password.");
				return;
			}
			var student = _context.Students.FirstOrDefault(s => s.Password == password && s.UserName == user_Name);
			if (student != null)
			{
				Form2 form2 = new Form2(student);
				form2.Show();
				this.Hide();
			}
			else
				MessageBox.Show("Not your username and password contain.. please try again");
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
