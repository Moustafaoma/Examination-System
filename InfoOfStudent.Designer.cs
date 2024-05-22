namespace Examination_System
{
	partial class InfoOfStudent
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label9 = new Label();
			label6 = new Label();
			label7 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(300, 78);
			label1.Name = "label1";
			label1.Size = new Size(171, 31);
			label1.TabIndex = 0;
			label1.Text = "Student Name: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(335, 162);
			label2.Name = "label2";
			label2.Size = new Size(66, 31);
			label2.TabIndex = 1;
			label2.Text = "Age: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(323, 243);
			label3.Name = "label3";
			label3.Size = new Size(101, 31);
			label3.TabIndex = 2;
			label3.Text = "Subject: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(324, 342);
			label4.Name = "label4";
			label4.Size = new Size(77, 31);
			label4.TabIndex = 3;
			label4.Text = "Mark: ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(43, 73);
			label5.Name = "label5";
			label5.Size = new Size(222, 38);
			label5.TabIndex = 4;
			label5.Text = "Student Name: ";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.Location = new Point(43, 162);
			label9.Name = "label9";
			label9.Size = new Size(85, 38);
			label9.TabIndex = 8;
			label9.Text = "Age: ";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(31, 243);
			label6.Name = "label6";
			label6.Size = new Size(130, 38);
			label6.TabIndex = 9;
			label6.Text = "Subject :";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(42, 335);
			label7.Name = "label7";
			label7.Size = new Size(102, 38);
			label7.TabIndex = 10;
			label7.Text = "Mark :";
			// 
			// button1
			// 
			button1.Location = new Point(602, 463);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 11;
			button1.Text = "Details";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// InfoOfStudent
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 558);
			Controls.Add(button1);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label9);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "InfoOfStudent";
			Text = "InfoOfStudent";
			Load += InfoOfStudent_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label9;
		private Label label6;
		private Label label7;
		private Button button1;
	}
}