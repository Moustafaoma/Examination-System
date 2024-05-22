namespace Examination_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			LogIn = new Button();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			pictureBox1 = new PictureBox();
			label3 = new Label();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// LogIn
			// 
			LogIn.Location = new Point(295, 486);
			LogIn.Name = "LogIn";
			LogIn.Size = new Size(139, 29);
			LogIn.TabIndex = 0;
			LogIn.Text = "Login";
			LogIn.UseVisualStyleBackColor = true;
			LogIn.Click += LogIn_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(188, 302);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Enter Your UserName";
			textBox1.Size = new Size(239, 27);
			textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(188, 389);
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "Enter Your Password";
			textBox2.Size = new Size(246, 27);
			textBox2.TabIndex = 4;
			textBox2.UseSystemPasswordChar = true;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources._360_F_489996796_3BdHk6wee2MwTX55cM858WXI01tu6Slx;
			pictureBox1.Location = new Point(146, 37);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(150, 140);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.DeepSkyBlue;
			label3.Location = new Point(155, 196);
			label3.Name = "label3";
			label3.Size = new Size(141, 45);
			label3.TabIndex = 6;
			label3.Text = "LOG IN";
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.pngtree_user_icon_png_image_1796659;
			pictureBox2.Location = new Point(126, 302);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(35, 35);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 7;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.download;
			pictureBox3.Location = new Point(126, 389);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(35, 35);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 8;
			pictureBox3.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(482, 671);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(label3);
			Controls.Add(pictureBox1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(LogIn);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button LogIn;
		private TextBox textBox1;
		private TextBox textBox2;
		private PictureBox pictureBox1;
		private Label label3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
	}
}
