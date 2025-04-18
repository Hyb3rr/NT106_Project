namespace BookReaderApp.ViewForm
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
            chkRememberMe = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            lblMessage = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsernameOrEmail = new TextBox();
            SuspendLayout();
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(292, 204);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(125, 24);
            chkRememberMe.TabIndex = 13;
            chkRememberMe.Text = "RememberMe";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 160);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 12;
            label3.Text = "PassWord:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 99);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 11;
            label2.Text = "User Name OR Email:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(413, 329);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(38, 20);
            lblMessage.TabIndex = 10;
            lblMessage.Text = "hide";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(349, 251);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 57);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(319, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(243, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtUsernameOrEmail
            // 
            txtUsernameOrEmail.Location = new Point(319, 99);
            txtUsernameOrEmail.Name = "txtUsernameOrEmail";
            txtUsernameOrEmail.Size = new Size(243, 27);
            txtUsernameOrEmail.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkRememberMe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsernameOrEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkRememberMe;
        private Label label3;
        private Label label2;
        private Label lblMessage;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsernameOrEmail;
    }
}