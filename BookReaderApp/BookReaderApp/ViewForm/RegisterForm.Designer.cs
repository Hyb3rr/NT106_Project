namespace BookReaderApp.ViewForm
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
            txtUserName = new TextBox();
            lblMessage = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRegister = new Button();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 82);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 23;
            label5.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(331, 81);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 22;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(310, 333);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(38, 20);
            lblMessage.TabIndex = 21;
            lblMessage.Text = "hide";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 291);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 20;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 218);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 19;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 145);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 18;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 17;
            label1.Text = "Full Name:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(322, 356);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(168, 57);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(331, 284);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(125, 27);
            txtConfirmPassword.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(331, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.AutoCompleteMode = AutoCompleteMode.Append;
            txtEmail.Location = new Point(331, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(331, 33);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 12;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtUserName);
            Controls.Add(lblMessage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtUserName;
        private Label lblMessage;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRegister;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtFullName;
    }
}