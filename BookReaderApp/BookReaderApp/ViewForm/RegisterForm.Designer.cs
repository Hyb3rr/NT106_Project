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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            lblMessage = new Label();
            btnRegister = new Button();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox4 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox5 = new Krypton.Toolkit.KryptonTextBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Calibri", 10F);
            lblMessage.Location = new Point(294, 220);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(58, 17);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Message";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Location = new Point(511, 236);
            btnRegister.Margin = new Padding(4, 2, 4, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(133, 43);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "btnRegister";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Visible = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Location = new Point(511, 41);
            txtUserName.Margin = new Padding(4, 2, 4, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(110, 24);
            txtUserName.TabIndex = 2;
            txtUserName.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(511, 68);
            txtEmail.Margin = new Padding(4, 2, 4, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 24);
            txtEmail.TabIndex = 3;
            txtEmail.Visible = false;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.None;
            txtFullName.Location = new Point(511, 108);
            txtFullName.Margin = new Padding(4, 2, 4, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(110, 24);
            txtFullName.TabIndex = 4;
            txtFullName.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(511, 149);
            txtPassword.Margin = new Padding(4, 2, 4, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(110, 24);
            txtPassword.TabIndex = 5;
            txtPassword.Visible = false;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.None;
            txtConfirmPassword.Location = new Point(511, 185);
            txtConfirmPassword.Margin = new Padding(4, 2, 4, 2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(110, 24);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.Visible = false;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label1.Location = new Point(133, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 7;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label2.Location = new Point(133, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label3.Location = new Point(133, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 9;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label4.Location = new Point(133, 151);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label5.Location = new Point(133, 187);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 11;
            label5.Text = "Confirm Password";
            label5.Click += label5_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(251, 239);
            kryptonButton1.Margin = new Padding(4, 3, 4, 3);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.OverrideDefault.Border.Rounding = 20F;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(155, 43);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            kryptonButton1.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton1.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            kryptonButton1.StatePressed.Border.Rounding = 20F;
            kryptonButton1.StatePressed.Border.Width = 1;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateTracking.Border.Rounding = 20F;
            kryptonButton1.StateTracking.Border.Width = 1;
            kryptonButton1.TabIndex = 12;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Register";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(268, 32);
            kryptonTextBox1.Margin = new Padding(4, 3, 4, 3);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(150, 30);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox1.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonTextBox1.StateCommon.Border.Width = 1;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBox1.TabIndex = 13;
            kryptonTextBox1.Text = "UserName";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(268, 68);
            kryptonTextBox2.Margin = new Padding(4, 3, 4, 3);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(150, 30);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox2.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            kryptonTextBox2.StateCommon.Border.Width = 1;
            kryptonTextBox2.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox2.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox2.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBox2.TabIndex = 14;
            kryptonTextBox2.Text = "Email";
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.Location = new Point(268, 104);
            kryptonTextBox3.Margin = new Padding(4, 3, 4, 3);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(150, 30);
            kryptonTextBox3.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox3.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox3.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox3.StateCommon.Border.Rounding = 20F;
            kryptonTextBox3.StateCommon.Border.Width = 1;
            kryptonTextBox3.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox3.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox3.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBox3.TabIndex = 15;
            kryptonTextBox3.Text = "FullName";
            // 
            // kryptonTextBox4
            // 
            kryptonTextBox4.Location = new Point(268, 140);
            kryptonTextBox4.Margin = new Padding(4, 3, 4, 3);
            kryptonTextBox4.Name = "kryptonTextBox4";
            kryptonTextBox4.Size = new Size(150, 30);
            kryptonTextBox4.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox4.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox4.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox4.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox4.StateCommon.Border.Rounding = 20F;
            kryptonTextBox4.StateCommon.Border.Width = 1;
            kryptonTextBox4.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox4.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox4.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBox4.TabIndex = 16;
            kryptonTextBox4.Text = "Password";
            // 
            // kryptonTextBox5
            // 
            kryptonTextBox5.Location = new Point(268, 176);
            kryptonTextBox5.Margin = new Padding(4, 3, 4, 3);
            kryptonTextBox5.Name = "kryptonTextBox5";
            kryptonTextBox5.Size = new Size(150, 30);
            kryptonTextBox5.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox5.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox5.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox5.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox5.StateCommon.Border.Rounding = 20F;
            kryptonTextBox5.StateCommon.Border.Width = 1;
            kryptonTextBox5.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox5.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox5.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBox5.TabIndex = 17;
            kryptonTextBox5.Text = "ConfirmPassword";
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.Image = (Image)resources.GetObject("resource.Image");
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.ImageStates.ImagePressed = (Image)resources.GetObject("resource.ImagePressed");
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.ImageStates.ImageTracking = (Image)resources.GetObject("resource.ImageTracking");
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.Image = (Image)resources.GetObject("resource.Image1");
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.ImageStates.ImagePressed = Properties.Resources.yellow_circle;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.ImageStates.ImageTracking = Properties.Resources.yellow_circle;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.Image = Properties.Resources.green_circle;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.ImageStates.ImagePressed = Properties.Resources.green_circle;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.ImageStates.ImageTracking = Properties.Resources.green_circle;
            kryptonCustomPaletteBase1.ButtonSpecs.FormRestore.Image = Properties.Resources.yellow_circle;
            kryptonCustomPaletteBase1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = Properties.Resources.yellow_circle;
            kryptonCustomPaletteBase1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = Properties.Resources.yellow_circle;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateCommon.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateActive.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateActive.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateActive.Border.Rounding = 12F;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCommon.StateCommon.ButtonEdgeInset = 10;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 284);
            Controls.Add(kryptonTextBox5);
            Controls.Add(kryptonTextBox4);
            Controls.Add(kryptonTextBox3);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(btnRegister);
            Controls.Add(lblMessage);
            Font = new Font("Calibri", 10F, FontStyle.Bold);
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(4, 2, 4, 2);
            Name = "RegisterForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button btnRegister;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox5;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}