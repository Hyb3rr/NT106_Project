namespace BookReaderApp.Views
{
    partial class ResetPassForm
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
            button_Reset = new Button();
            textBox_NewPassword = new TextBox();
            label_KQ = new Label();
            label_Email = new Label();
            textBox_Email = new TextBox();
            pictureBox1 = new PictureBox();
            textBox_ConfirmPassword = new TextBox();
            label1 = new Label();
            button_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Reset
            // 
            button_Reset.BackColor = Color.Blue;
            button_Reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Reset.ForeColor = Color.White;
            button_Reset.Location = new Point(381, 437);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(212, 69);
            button_Reset.TabIndex = 52;
            button_Reset.Text = "Reset";
            button_Reset.UseVisualStyleBackColor = false;
            button_Reset.Click += button_Reset_Click;
            // 
            // textBox_NewPassword
            // 
            textBox_NewPassword.Location = new Point(381, 326);
            textBox_NewPassword.Name = "textBox_NewPassword";
            textBox_NewPassword.PasswordChar = '*';
            textBox_NewPassword.Size = new Size(271, 27);
            textBox_NewPassword.TabIndex = 51;
            textBox_NewPassword.KeyDown += textBox_NewPassword_KeyDown;
            // 
            // label_KQ
            // 
            label_KQ.AutoSize = true;
            label_KQ.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_KQ.ForeColor = Color.Blue;
            label_KQ.Location = new Point(159, 325);
            label_KQ.Name = "label_KQ";
            label_KQ.Size = new Size(185, 25);
            label_KQ.TabIndex = 50;
            label_KQ.Text = "Nhập mật khẩu mới:";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Email.ForeColor = Color.Blue;
            label_Email.Location = new Point(159, 267);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(162, 25);
            label_Email.TabIndex = 49;
            label_Email.Text = "Email đã đăng ký:";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(381, 268);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(271, 27);
            textBox_Email.TabIndex = 48;
            textBox_Email.TextChanged += textBox_Email_TextChanged;
            textBox_Email.KeyDown += textBox_Email_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FogotPass;
            pictureBox1.Location = new Point(378, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // textBox_ConfirmPassword
            // 
            textBox_ConfirmPassword.Location = new Point(381, 373);
            textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            textBox_ConfirmPassword.PasswordChar = '*';
            textBox_ConfirmPassword.Size = new Size(271, 27);
            textBox_ConfirmPassword.TabIndex = 54;
            textBox_ConfirmPassword.KeyDown += textBox_ConfirmPassword_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(156, 372);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 53;
            label1.Text = "Xác nhận lại mật khẩu:";
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.Blue;
            button_Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Exit.ForeColor = Color.White;
            button_Exit.Location = new Point(769, 47);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(212, 69);
            button_Exit.TabIndex = 55;
            button_Exit.Text = "Thoát";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // ResetPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(993, 562);
            Controls.Add(button_Exit);
            Controls.Add(textBox_ConfirmPassword);
            Controls.Add(label1);
            Controls.Add(button_Reset);
            Controls.Add(textBox_NewPassword);
            Controls.Add(label_KQ);
            Controls.Add(label_Email);
            Controls.Add(textBox_Email);
            Controls.Add(pictureBox1);
            Name = "ResetPassForm";
            Text = "ResetPassForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Reset;
        private TextBox textBox_NewPassword;
        private Label label_KQ;
        private Label label_Email;
        private TextBox textBox_Email;
        private PictureBox pictureBox1;
        private TextBox textBox_ConfirmPassword;
        private Label label1;
        private Button button_Exit;
    }
}