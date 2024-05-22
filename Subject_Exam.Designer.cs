namespace Examination_System
{
	partial class Subject_Exam
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			button1 = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			timer2 = new System.Windows.Forms.Timer(components);
			timer3 = new System.Windows.Forms.Timer(components);
			timer4 = new System.Windows.Forms.Timer(components);
			timer5 = new System.Windows.Forms.Timer(components);
			timer6 = new System.Windows.Forms.Timer(components);
			timer7 = new System.Windows.Forms.Timer(components);
			timer8 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(0, 117, 214);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(551, 377);
			button1.Name = "button1";
			button1.Size = new Size(192, 45);
			button1.TabIndex = 0;
			button1.Text = "Submit";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// Subject_Exam
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Name = "Subject_Exam";
			Text = "Exam";
			Load += Exam_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Timer timer4;
		private System.Windows.Forms.Timer timer5;
		private System.Windows.Forms.Timer timer6;
		private System.Windows.Forms.Timer timer7;
		private System.Windows.Forms.Timer timer8;
	}
}