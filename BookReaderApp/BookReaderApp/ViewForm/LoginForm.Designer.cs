﻿namespace BookReaderApp.ViewForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsernameOrEmail = new TextBox();
            txtPassword = new TextBox();
            chkRememberMe = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            Register = new LinkLabel();
            lblMessage = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            SuspendLayout();
            // 
            // txtUsernameOrEmail
            // 
            txtUsernameOrEmail.Anchor = AnchorStyles.None;
            txtUsernameOrEmail.Location = new Point(419, 38);
            txtUsernameOrEmail.Margin = new Padding(3, 2, 3, 2);
            txtUsernameOrEmail.Name = "txtUsernameOrEmail";
            txtUsernameOrEmail.Size = new Size(156, 23);
            txtUsernameOrEmail.TabIndex = 0;
            txtUsernameOrEmail.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(434, 63);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(156, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Visible = false;
            // 
            // chkRememberMe
            // 
            chkRememberMe.Anchor = AnchorStyles.None;
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Calibri", 10F);
            chkRememberMe.Location = new Point(163, 194);
            chkRememberMe.Margin = new Padding(3, 2, 3, 2);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(111, 21);
            chkRememberMe.TabIndex = 3;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = true;
            chkRememberMe.CheckedChanged += chkRememberMe_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label1.Location = new Point(89, 113);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 4;
            label1.Text = "Username or Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label2.Location = new Point(89, 157);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // Register
            // 
            Register.Anchor = AnchorStyles.None;
            Register.AutoSize = true;
            Register.Location = new Point(569, 46);
            Register.Name = "Register";
            Register.Size = new Size(49, 15);
            Register.TabIndex = 7;
            Register.TabStop = true;
            Register.Text = "Register";
            Register.Visible = false;
            Register.LinkClicked += Register_LinkClicked;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.None;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(387, 194);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(31, 15);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "hide";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(163, 234);
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
            kryptonButton1.Size = new Size(157, 49);
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
            kryptonButton1.TabIndex = 9;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Login";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Anchor = AnchorStyles.None;
            kryptonTextBox1.Location = new Point(243, 100);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(152, 30);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox1.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonTextBox1.StateCommon.Border.Width = 1;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBox1.TabIndex = 10;
            kryptonTextBox1.Text = "Username or Email";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Anchor = AnchorStyles.None;
            kryptonTextBox2.Location = new Point(243, 144);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(152, 30);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox2.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            kryptonTextBox2.StateCommon.Border.Width = 1;
            kryptonTextBox2.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox2.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox2.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBox2.TabIndex = 11;
            kryptonTextBox2.Text = "Password";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.None;
            kryptonButton2.Location = new Point(347, 234);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton2.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton2.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton2.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton2.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton2.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton2.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton2.OverrideDefault.Border.Rounding = 20F;
            kryptonButton2.OverrideDefault.Border.Width = 1;
            kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton2.Size = new Size(157, 49);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            kryptonButton2.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton2.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            kryptonButton2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateCommon.Border.Rounding = 20F;
            kryptonButton2.StateCommon.Border.Width = 1;
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton2.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton2.StatePressed.Back.ColorAngle = 135F;
            kryptonButton2.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton2.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton2.StatePressed.Border.ColorAngle = 135F;
            kryptonButton2.StatePressed.Border.Rounding = 20F;
            kryptonButton2.StatePressed.Border.Width = 1;
            kryptonButton2.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButton2.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButton2.StateTracking.Back.ColorAngle = 45F;
            kryptonButton2.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton2.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton2.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateTracking.Border.Rounding = 20F;
            kryptonButton2.StateTracking.Border.Width = 1;
            kryptonButton2.TabIndex = 12;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Register";
            kryptonButton2.Click += kryptonButton2_Click;
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 307);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonButton1);
            Controls.Add(lblMessage);
            Controls.Add(Register);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(txtUsernameOrEmail);
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsernameOrEmail;
        private TextBox txtPassword;
        private CheckBox chkRememberMe;
        private Label label1;
        private Label label2;
        private LinkLabel Register;
        private Label lblMessage;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}