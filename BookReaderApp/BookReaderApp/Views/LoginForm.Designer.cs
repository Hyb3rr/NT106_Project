namespace BookReaderApp.Views
{
    partial class LoginForm
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
            linkLabel_Register = new LinkLabel();
            linkLabel_ForgotPassword = new LinkLabel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox_PasswordAccount = new TextBox();
            textBox_UserAccount = new TextBox();
            button_Login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel_Register
            // 
            linkLabel_Register.AutoSize = true;
            linkLabel_Register.BackColor = Color.Transparent;
            linkLabel_Register.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel_Register.Location = new Point(644, 379);
            linkLabel_Register.Name = "linkLabel_Register";
            linkLabel_Register.Size = new Size(110, 31);
            linkLabel_Register.TabIndex = 26;
            linkLabel_Register.TabStop = true;
            linkLabel_Register.Text = "Đăng ký!";
            linkLabel_Register.LinkClicked += linkLabel_Register_LinkClicked;
            // 
            // linkLabel_ForgotPassword
            // 
            linkLabel_ForgotPassword.AutoSize = true;
            linkLabel_ForgotPassword.BackColor = Color.Transparent;
            linkLabel_ForgotPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel_ForgotPassword.Location = new Point(204, 379);
            linkLabel_ForgotPassword.Name = "linkLabel_ForgotPassword";
            linkLabel_ForgotPassword.Size = new Size(188, 31);
            linkLabel_ForgotPassword.TabIndex = 25;
            linkLabel_ForgotPassword.TabStop = true;
            linkLabel_ForgotPassword.Text = "Quên mật khẩu?";
            linkLabel_ForgotPassword.LinkClicked += linkLabel_ForgotPassword_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icon_password;
            pictureBox3.Location = new Point(289, 291);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icon_user1;
            pictureBox2.Location = new Point(289, 190);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_user;
            pictureBox1.Location = new Point(429, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // textBox_PasswordAccount
            // 
            textBox_PasswordAccount.Location = new Point(364, 307);
            textBox_PasswordAccount.Name = "textBox_PasswordAccount";
            textBox_PasswordAccount.PasswordChar = '*';
            textBox_PasswordAccount.Size = new Size(271, 27);
            textBox_PasswordAccount.TabIndex = 21;
            textBox_PasswordAccount.KeyDown += PassEnter;
            // 
            // textBox_UserAccount
            // 
            textBox_UserAccount.Location = new Point(364, 207);
            textBox_UserAccount.Name = "textBox_UserAccount";
            textBox_UserAccount.Size = new Size(271, 27);
            textBox_UserAccount.TabIndex = 20;
            textBox_UserAccount.KeyDown += UserEnter;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.DarkOrange;
            button_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Login.ForeColor = Color.White;
            button_Login.Location = new Point(405, 453);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(152, 69);
            button_Login.TabIndex = 19;
            button_Login.Text = "Đăng nhập";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(364, 184);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 27;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(364, 284);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 28;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(441, 380);
            label3.Name = "label3";
            label3.Size = new Size(209, 30);
            label3.TabIndex = 29;
            label3.Text = "Chưa có tài khoản?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(993, 562);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel_Register);
            Controls.Add(linkLabel_ForgotPassword);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_PasswordAccount);
            Controls.Add(textBox_UserAccount);
            Controls.Add(button_Login);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel_Register;
        private LinkLabel linkLabel_ForgotPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox_PasswordAccount;
        private TextBox textBox_UserAccount;
        private Button button_Login;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}