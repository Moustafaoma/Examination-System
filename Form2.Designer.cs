namespace Examination_System
{
	partial class Form2
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
			label6 = new Label();
			comboBox1 = new ComboBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(329, 28);
			label1.Name = "label1";
			label1.Size = new Size(75, 20);
			label1.TabIndex = 0;
			label1.Text = "Welcome ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(61, 114);
			label2.Name = "label2";
			label2.Size = new Size(82, 20);
			label2.TabIndex = 1;
			label2.Text = "User Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(77, 165);
			label3.Name = "label3";
			label3.Size = new Size(36, 20);
			label3.TabIndex = 2;
			label3.Text = "Age";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(61, 215);
			label4.Name = "label4";
			label4.Size = new Size(58, 20);
			label4.TabIndex = 3;
			label4.Text = "Subject";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(187, 114);
			label5.Name = "label5";
			label5.Size = new Size(50, 20);
			label5.TabIndex = 4;
			label5.Text = "label5";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(187, 165);
			label6.Name = "label6";
			label6.Size = new Size(50, 20);
			label6.TabIndex = 5;
			label6.Text = "label6";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(144, 215);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 28);
			comboBox1.TabIndex = 6;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			comboBox1.SelectedValueChanged += comboBox1_SelectedIndexChanged;
			// 
			// button1
			// 
			button1.Location = new Point(329, 331);
			button1.Name = "button1";
			button1.Size = new Size(194, 29);
			button1.TabIndex = 7;
			button1.Text = "Take Exam";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(comboBox1);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form2";
			Text = "Form2";
			Load += Form2_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private ComboBox comboBox1;
		private Button button1;
	}
}