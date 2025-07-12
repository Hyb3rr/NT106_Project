namespace BookReaderApp.ViewForm
{
    partial class EditCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategoryForm));
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            label1 = new Label();
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonButtonSave = new Krypton.Toolkit.KryptonButton();
            kryptonButtonCancel = new Krypton.Toolkit.KryptonButton();
            kryptonTextBoxCategory = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxDescription = new Krypton.Toolkit.KryptonTextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(327, 214);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 57);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(143, 214);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 57);
            btnSave.TabIndex = 23;
            btnSave.Text = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label2.Location = new Point(188, 71);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 30;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label1.Location = new Point(188, 34);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 29;
            label1.Text = "Thể loại";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.Location = new Point(570, 28);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(110, 23);
            txtDescription.TabIndex = 28;
            txtDescription.Visible = false;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Anchor = AnchorStyles.None;
            txtCategoryName.Location = new Point(556, 119);
            txtCategoryName.Margin = new Padding(3, 2, 3, 2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(110, 23);
            txtCategoryName.TabIndex = 27;
            txtCategoryName.Visible = false;
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
            // kryptonButtonSave
            // 
            kryptonButtonSave.Anchor = AnchorStyles.None;
            kryptonButtonSave.Location = new Point(143, 156);
            kryptonButtonSave.Name = "kryptonButtonSave";
            kryptonButtonSave.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSave.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSave.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonSave.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSave.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSave.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonSave.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonSave.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonSave.OverrideDefault.Border.Width = 1;
            kryptonButtonSave.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonSave.Size = new Size(155, 43);
            kryptonButtonSave.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSave.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSave.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonSave.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSave.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSave.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonSave.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonSave.StateCommon.Border.Rounding = 20F;
            kryptonButtonSave.StateCommon.Border.Width = 1;
            kryptonButtonSave.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonSave.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonSave.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonSave.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonSave.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonSave.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonSave.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonSave.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonSave.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonSave.StatePressed.Border.Rounding = 20F;
            kryptonButtonSave.StatePressed.Border.Width = 1;
            kryptonButtonSave.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonSave.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonSave.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonSave.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSave.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSave.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonSave.StateTracking.Border.Rounding = 20F;
            kryptonButtonSave.StateTracking.Border.Width = 1;
            kryptonButtonSave.TabIndex = 31;
            kryptonButtonSave.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonSave.Values.Text = "Save";
            kryptonButtonSave.Click += kryptonButtonSave_Click;
            // 
            // kryptonButtonCancel
            // 
            kryptonButtonCancel.Anchor = AnchorStyles.None;
            kryptonButtonCancel.Location = new Point(330, 156);
            kryptonButtonCancel.Name = "kryptonButtonCancel";
            kryptonButtonCancel.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonCancel.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonCancel.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonCancel.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonCancel.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonCancel.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonCancel.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonCancel.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonCancel.OverrideDefault.Border.Width = 1;
            kryptonButtonCancel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonCancel.Size = new Size(155, 43);
            kryptonButtonCancel.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonCancel.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonCancel.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonCancel.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonCancel.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonCancel.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonCancel.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonCancel.StateCommon.Border.Rounding = 20F;
            kryptonButtonCancel.StateCommon.Border.Width = 1;
            kryptonButtonCancel.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonCancel.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonCancel.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonCancel.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonCancel.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonCancel.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonCancel.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonCancel.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonCancel.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonCancel.StatePressed.Border.Rounding = 20F;
            kryptonButtonCancel.StatePressed.Border.Width = 1;
            kryptonButtonCancel.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonCancel.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonCancel.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonCancel.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonCancel.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonCancel.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonCancel.StateTracking.Border.Rounding = 20F;
            kryptonButtonCancel.StateTracking.Border.Width = 1;
            kryptonButtonCancel.TabIndex = 32;
            kryptonButtonCancel.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonCancel.Values.Text = "Cancel";
            kryptonButtonCancel.Click += kryptonButtonCancel_Click;
            // 
            // kryptonTextBoxCategory
            // 
            kryptonTextBoxCategory.Anchor = AnchorStyles.None;
            kryptonTextBoxCategory.Location = new Point(308, 21);
            kryptonTextBoxCategory.Name = "kryptonTextBoxCategory";
            kryptonTextBoxCategory.Size = new Size(150, 30);
            kryptonTextBoxCategory.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxCategory.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxCategory.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxCategory.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxCategory.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxCategory.StateCommon.Border.Width = 1;
            kryptonTextBoxCategory.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxCategory.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxCategory.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxCategory.TabIndex = 33;
            // 
            // kryptonTextBoxDescription
            // 
            kryptonTextBoxDescription.Anchor = AnchorStyles.None;
            kryptonTextBoxDescription.Location = new Point(308, 58);
            kryptonTextBoxDescription.Name = "kryptonTextBoxDescription";
            kryptonTextBoxDescription.Size = new Size(150, 30);
            kryptonTextBoxDescription.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxDescription.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxDescription.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxDescription.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxDescription.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxDescription.StateCommon.Border.Width = 1;
            kryptonTextBoxDescription.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxDescription.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxDescription.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxDescription.TabIndex = 34;
            // 
            // EditCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 227);
            Controls.Add(kryptonTextBoxDescription);
            Controls.Add(kryptonTextBoxCategory);
            Controls.Add(kryptonButtonCancel);
            Controls.Add(kryptonButtonSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditCategoryForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonButton kryptonButtonSave;
        private Krypton.Toolkit.KryptonButton kryptonButtonCancel;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxCategory;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxDescription;
    }
}