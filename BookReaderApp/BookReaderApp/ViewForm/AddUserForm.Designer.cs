﻿namespace BookReaderApp.ViewForm
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            btnSave = new Button();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            cmbRole = new ComboBox();
            chkIsActive = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonTextBoxPassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxEmail = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxUsrname = new Krypton.Toolkit.KryptonTextBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonComboBoxRole = new Krypton.Toolkit.KryptonComboBox();
            kryptonTextBoxFullName = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxRole).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(178, 281);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 46);
            btnSave.TabIndex = 0;
            btnSave.Text = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(578, 50);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(110, 23);
            txtUsername.TabIndex = 1;
            txtUsername.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(578, 66);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 2;
            txtEmail.Visible = false;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.None;
            txtFullName.Location = new Point(578, 77);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(110, 23);
            txtFullName.TabIndex = 3;
            txtFullName.Visible = false;
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.None;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "User", "Admin" });
            cmbRole.Location = new Point(588, 23);
            cmbRole.Margin = new Padding(3, 2, 3, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(133, 23);
            cmbRole.TabIndex = 4;
            cmbRole.Visible = false;
            // 
            // chkIsActive
            // 
            chkIsActive.Anchor = AnchorStyles.None;
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Calibri", 10F);
            chkIsActive.Location = new Point(167, 191);
            chkIsActive.Margin = new Padding(3, 2, 3, 2);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(71, 21);
            chkIsActive.TabIndex = 5;
            chkIsActive.Text = "IsActive";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label1.Location = new Point(178, 53);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label2.Location = new Point(178, 89);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label3.Location = new Point(178, 161);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(373, 274);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 46);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(578, 86);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(110, 23);
            txtPassword.TabIndex = 10;
            txtPassword.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label4.Location = new Point(178, 125);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 11;
            label4.Text = "FullName";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.None;
            kryptonButton2.Location = new Point(361, 226);
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
            kryptonButton2.Size = new Size(155, 43);
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
            kryptonButton2.TabIndex = 31;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Cancel";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(200, 226);
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
            kryptonButton1.TabIndex = 30;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Save";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonTextBoxPassword
            // 
            kryptonTextBoxPassword.Anchor = AnchorStyles.None;
            kryptonTextBoxPassword.Location = new Point(261, 146);
            kryptonTextBoxPassword.Name = "kryptonTextBoxPassword";
            kryptonTextBoxPassword.Size = new Size(150, 30);
            kryptonTextBoxPassword.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxPassword.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxPassword.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxPassword.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxPassword.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxPassword.StateCommon.Border.Width = 1;
            kryptonTextBoxPassword.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxPassword.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxPassword.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxPassword.TabIndex = 28;
            kryptonTextBoxPassword.Text = "Password";
            // 
            // kryptonTextBoxEmail
            // 
            kryptonTextBoxEmail.Anchor = AnchorStyles.None;
            kryptonTextBoxEmail.Location = new Point(261, 74);
            kryptonTextBoxEmail.Name = "kryptonTextBoxEmail";
            kryptonTextBoxEmail.Size = new Size(150, 30);
            kryptonTextBoxEmail.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxEmail.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxEmail.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxEmail.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxEmail.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxEmail.StateCommon.Border.Width = 1;
            kryptonTextBoxEmail.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxEmail.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxEmail.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxEmail.TabIndex = 27;
            kryptonTextBoxEmail.Text = " Email";
            // 
            // kryptonTextBoxUsrname
            // 
            kryptonTextBoxUsrname.Anchor = AnchorStyles.None;
            kryptonTextBoxUsrname.Location = new Point(261, 38);
            kryptonTextBoxUsrname.Name = "kryptonTextBoxUsrname";
            kryptonTextBoxUsrname.Size = new Size(150, 30);
            kryptonTextBoxUsrname.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxUsrname.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxUsrname.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxUsrname.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxUsrname.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxUsrname.StateCommon.Border.Width = 1;
            kryptonTextBoxUsrname.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxUsrname.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxUsrname.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxUsrname.TabIndex = 26;
            kryptonTextBoxUsrname.Text = "Username ";
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
            // kryptonComboBoxRole
            // 
            kryptonComboBoxRole.Anchor = AnchorStyles.None;
            kryptonComboBoxRole.DropDownWidth = 138;
            kryptonComboBoxRole.Location = new Point(417, 23);
            kryptonComboBoxRole.Name = "kryptonComboBoxRole";
            kryptonComboBoxRole.Size = new Size(150, 34);
            kryptonComboBoxRole.StateCommon.ComboBox.Back.Color1 = Color.White;
            kryptonComboBoxRole.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxRole.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxRole.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBoxRole.StateCommon.ComboBox.Border.Rounding = 20F;
            kryptonComboBoxRole.StateCommon.ComboBox.Border.Width = 1;
            kryptonComboBoxRole.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            kryptonComboBoxRole.StateCommon.ComboBox.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxRole.StateCommon.ComboBox.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxRole.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBoxRole.StateCommon.DropBack.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxRole.StateCommon.DropBack.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxRole.StateCommon.DropBack.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBoxRole.StateCommon.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxRole.StateCommon.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxRole.StateTracking.Item.Back.Color1 = Color.Blue;
            kryptonComboBoxRole.StateTracking.Item.Back.Color2 = Color.FromArgb(128, 255, 255);
            kryptonComboBoxRole.StateTracking.Item.Back.ColorAngle = 10F;
            kryptonComboBoxRole.StateTracking.Item.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonComboBoxRole.StateTracking.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxRole.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            kryptonComboBoxRole.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            kryptonComboBoxRole.StateTracking.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxRole.TabIndex = 29;
            kryptonComboBoxRole.Text = "kryptonComboBox1";
            // 
            // kryptonTextBoxFullName
            // 
            kryptonTextBoxFullName.Anchor = AnchorStyles.None;
            kryptonTextBoxFullName.Location = new Point(261, 110);
            kryptonTextBoxFullName.Name = "kryptonTextBoxFullName";
            kryptonTextBoxFullName.Size = new Size(150, 30);
            kryptonTextBoxFullName.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxFullName.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxFullName.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxFullName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxFullName.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxFullName.StateCommon.Border.Width = 1;
            kryptonTextBoxFullName.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxFullName.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxFullName.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxFullName.TabIndex = 32;
            kryptonTextBoxFullName.Text = "FullName";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 290);
            Controls.Add(kryptonTextBoxFullName);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonTextBoxPassword);
            Controls.Add(kryptonTextBoxEmail);
            Controls.Add(kryptonTextBoxUsrname);
            Controls.Add(kryptonComboBoxRole);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkIsActive);
            Controls.Add(cmbRole);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(btnSave);
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddUserForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUserForm";
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxRole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private ComboBox cmbRole;
        private CheckBox chkIsActive;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private TextBox txtPassword;
        private Label label4;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxPassword;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxEmail;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxUsrname;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBoxRole;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxFullName;
    }
}