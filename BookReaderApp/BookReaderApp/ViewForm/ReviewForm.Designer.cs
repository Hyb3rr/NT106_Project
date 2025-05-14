namespace BookReaderApp.ViewForm
{
    partial class ReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewForm));
            lblBookTitle = new Label();
            txtComment = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            numericUpDownRating = new NumericUpDown();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPictureBox6 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPictureBox3 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPictureBox4 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Calibri", 14F, FontStyle.Bold);
            lblBookTitle.Location = new Point(30, 21);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(86, 23);
            lblBookTitle.TabIndex = 0;
            lblBookTitle.Text = "BookTitle";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(592, 49);
            txtComment.Margin = new Padding(3, 2, 3, 2);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(110, 23);
            txtComment.TabIndex = 3;
            txtComment.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(579, 11);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(592, 38);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 34);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // numericUpDownRating
            // 
            numericUpDownRating.Location = new Point(147, 11);
            numericUpDownRating.Margin = new Padding(3, 2, 3, 2);
            numericUpDownRating.Name = "numericUpDownRating";
            numericUpDownRating.Size = new Size(131, 23);
            numericUpDownRating.TabIndex = 6;
            numericUpDownRating.Visible = false;
            numericUpDownRating.ValueChanged += numericUpDownRating_ValueChanged;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonButton1.Location = new Point(288, 330);
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
            kryptonButton1.Values.Text = "Save";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonButton2.Location = new Point(472, 330);
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
            kryptonButton2.TabIndex = 13;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Cancel";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonRichTextBox1
            // 
            kryptonRichTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonRichTextBox1.Location = new Point(30, 146);
            kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            kryptonRichTextBox1.Size = new Size(614, 158);
            kryptonRichTextBox1.StateCommon.Back.Color1 = Color.White;
            kryptonRichTextBox1.StateCommon.Border.Color1 = Color.FromArgb(242, 242, 242);
            kryptonRichTextBox1.StateCommon.Border.Color2 = Color.FromArgb(242, 242, 242);
            kryptonRichTextBox1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonRichTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonRichTextBox1.StateCommon.Border.Width = 1;
            kryptonRichTextBox1.StateCommon.Content.Color1 = Color.Black;
            kryptonRichTextBox1.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonRichTextBox1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonRichTextBox1.TabIndex = 14;
            kryptonRichTextBox1.Text = "";
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
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Cursor = Cursors.Hand;
            kryptonPictureBox1.ErrorImage = null;
            kryptonPictureBox1.Image = Properties.Resources.icons8_smiling_face_with_heart_eyes_50;
            kryptonPictureBox1.InitialImage = null;
            kryptonPictureBox1.Location = new Point(448, 49);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(50, 50);
            kryptonPictureBox1.TabIndex = 15;
            kryptonPictureBox1.TabStop = false;
            kryptonPictureBox1.Click += kryptonPictureBox1_Click;
            // 
            // kryptonPictureBox6
            // 
            kryptonPictureBox6.Cursor = Cursors.Hand;
            kryptonPictureBox6.ErrorImage = null;
            kryptonPictureBox6.Image = Properties.Resources.icons8_disappointed_face_50;
            kryptonPictureBox6.InitialImage = null;
            kryptonPictureBox6.Location = new Point(131, 49);
            kryptonPictureBox6.Name = "kryptonPictureBox6";
            kryptonPictureBox6.Size = new Size(50, 50);
            kryptonPictureBox6.TabIndex = 16;
            kryptonPictureBox6.TabStop = false;
            kryptonPictureBox6.Click += kryptonPictureBox6_Click;
            // 
            // kryptonPictureBox2
            // 
            kryptonPictureBox2.Cursor = Cursors.Hand;
            kryptonPictureBox2.ErrorImage = null;
            kryptonPictureBox2.Image = Properties.Resources.icons8_slightly_frowning_face_50;
            kryptonPictureBox2.InitialImage = null;
            kryptonPictureBox2.Location = new Point(205, 49);
            kryptonPictureBox2.Name = "kryptonPictureBox2";
            kryptonPictureBox2.Size = new Size(50, 50);
            kryptonPictureBox2.TabIndex = 17;
            kryptonPictureBox2.TabStop = false;
            kryptonPictureBox2.Click += kryptonPictureBox2_Click;
            // 
            // kryptonPictureBox3
            // 
            kryptonPictureBox3.Cursor = Cursors.Hand;
            kryptonPictureBox3.ErrorImage = null;
            kryptonPictureBox3.Image = Properties.Resources.icons8_expressionless_face_50;
            kryptonPictureBox3.InitialImage = null;
            kryptonPictureBox3.Location = new Point(288, 49);
            kryptonPictureBox3.Name = "kryptonPictureBox3";
            kryptonPictureBox3.Size = new Size(50, 50);
            kryptonPictureBox3.TabIndex = 18;
            kryptonPictureBox3.TabStop = false;
            kryptonPictureBox3.Click += kryptonPictureBox3_Click;
            // 
            // kryptonPictureBox4
            // 
            kryptonPictureBox4.Cursor = Cursors.Hand;
            kryptonPictureBox4.ErrorImage = null;
            kryptonPictureBox4.Image = Properties.Resources.icons8_smiling_face_50;
            kryptonPictureBox4.InitialImage = null;
            kryptonPictureBox4.Location = new Point(367, 49);
            kryptonPictureBox4.Name = "kryptonPictureBox4";
            kryptonPictureBox4.Size = new Size(50, 50);
            kryptonPictureBox4.TabIndex = 19;
            kryptonPictureBox4.TabStop = false;
            kryptonPictureBox4.Click += kryptonPictureBox4_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(88, 20);
            kryptonLabel1.TabIndex = 20;
            kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(288, 120);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(37, 20);
            kryptonLabel2.TabIndex = 21;
            kryptonLabel2.Values.Text = "Stats";
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 379);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonPictureBox4);
            Controls.Add(kryptonPictureBox3);
            Controls.Add(kryptonPictureBox2);
            Controls.Add(kryptonPictureBox6);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(kryptonRichTextBox1);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(numericUpDownRating);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtComment);
            Controls.Add(lblBookTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReviewForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReviewForm";
            Load += ReviewForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookTitle;
        private TextBox txtComment;
        private Button btnSave;
        private Button btnCancel;
        private NumericUpDown numericUpDownRating;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox6;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox3;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}