namespace BookReaderApp.Views
{
    partial class RegisterForm
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
            label5 = new Label();
            textBox_FullName = new TextBox();
            button_Register = new Button();
            label4 = new Label();
            textBox_Email = new TextBox();
            label3 = new Label();
            textBox_ConfirmPassword = new TextBox();
            label2 = new Label();
            textBox_PassWord = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox_UserName = new TextBox();
            button_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(285, 173);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 52;
            label5.Text = "Họ và tên:";
            // 
            // textBox_FullName
            // 
            textBox_FullName.Location = new Point(391, 171);
            textBox_FullName.Name = "textBox_FullName";
            textBox_FullName.Size = new Size(271, 27);
            textBox_FullName.TabIndex = 51;
            textBox_FullName.KeyDown += textBox_FullName_KeyDown;
            // 
            // button_Register
            // 
            button_Register.BackColor = Color.DarkOrange;
            button_Register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Register.ForeColor = Color.White;
            button_Register.Location = new Point(442, 461);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(152, 69);
            button_Register.TabIndex = 50;
            button_Register.Text = "Đăng ký";
            button_Register.UseVisualStyleBackColor = false;
            button_Register.Click += button_Register_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(322, 391);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 49;
            label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(391, 392);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(271, 27);
            textBox_Email.TabIndex = 48;
            textBox_Email.KeyDown += textBox_Email_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(212, 337);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 47;
            label3.Text = "Nhập lại mật khẩu:";
            // 
            // textBox_ConfirmPassword
            // 
            textBox_ConfirmPassword.Location = new Point(391, 335);
            textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            textBox_ConfirmPassword.PasswordChar = '*';
            textBox_ConfirmPassword.Size = new Size(271, 27);
            textBox_ConfirmPassword.TabIndex = 46;
            textBox_ConfirmPassword.KeyDown += textBox_ConfirmPassword_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(287, 276);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 45;
            label2.Text = "Mật khẩu:";
            // 
            // textBox_PassWord
            // 
            textBox_PassWord.Location = new Point(391, 277);
            textBox_PassWord.Name = "textBox_PassWord";
            textBox_PassWord.PasswordChar = '*';
            textBox_PassWord.Size = new Size(271, 27);
            textBox_PassWord.TabIndex = 44;
            textBox_PassWord.KeyDown += textBox_PassWord_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(253, 220);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 43;
            label1.Text = "Tên tài khoản:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(452, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // textBox_UserName
            // 
            textBox_UserName.Location = new Point(391, 220);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(271, 27);
            textBox_UserName.TabIndex = 41;
            textBox_UserName.KeyDown += textBox_UserName_KeyDown;
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.Red;
            button_Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Exit.ForeColor = Color.White;
            button_Exit.Location = new Point(829, 12);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(152, 69);
            button_Exit.TabIndex = 53;
            button_Exit.Text = "Thoát";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(993, 562);
            Controls.Add(button_Exit);
            Controls.Add(label5);
            Controls.Add(textBox_FullName);
            Controls.Add(button_Register);
            Controls.Add(label4);
            Controls.Add(textBox_Email);
            Controls.Add(label3);
            Controls.Add(textBox_ConfirmPassword);
            Controls.Add(label2);
            Controls.Add(textBox_PassWord);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_UserName);
            DoubleBuffered = true;
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox_FullName;
        private Button button_Register;
        private Label label4;
        private TextBox textBox_Email;
        private Label label3;
        private TextBox textBox_ConfirmPassword;
        private Label label2;
        private TextBox textBox_PassWord;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox_UserName;
        private Button button_Exit;
    }
}