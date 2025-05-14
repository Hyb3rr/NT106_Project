namespace BookReaderApp.ViewForm
{
    partial class BookDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetailForm));
            lblTitle = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            txtDescription = new TextBox();
            lblPublishedDate = new Label();
            btnReadBook = new Button();
            btnClose = new Button();
            btnReview = new Button();
            lblAverageRating = new Label();
            kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonButtonReadBook = new Krypton.Toolkit.KryptonButton();
            kryptonButtonReview = new Krypton.Toolkit.KryptonButton();
            kryptonButtonClose = new Krypton.Toolkit.KryptonButton();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblTitle.Location = new Point(25, -8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 17);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.Anchor = AnchorStyles.None;
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblAuthor.Location = new Point(25, 24);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(50, 17);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.None;
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblCategory.Location = new Point(25, 56);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(61, 17);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(564, 390);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(110, 23);
            txtDescription.TabIndex = 4;
            txtDescription.Visible = false;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.Anchor = AnchorStyles.None;
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblPublishedDate.Location = new Point(25, 88);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(97, 17);
            lblPublishedDate.TabIndex = 5;
            lblPublishedDate.Text = "Published Date";
            // 
            // btnReadBook
            // 
            btnReadBook.Location = new Point(54, 405);
            btnReadBook.Margin = new Padding(3, 2, 3, 2);
            btnReadBook.Name = "btnReadBook";
            btnReadBook.Size = new Size(82, 22);
            btnReadBook.TabIndex = 6;
            btnReadBook.Text = "btnReadBook";
            btnReadBook.UseVisualStyleBackColor = true;
            btnReadBook.Visible = false;
            btnReadBook.Click += btnReadBook_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(461, 405);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 7;
            btnClose.Text = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Visible = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnReview
            // 
            btnReview.Location = new Point(257, 405);
            btnReview.Margin = new Padding(3, 2, 3, 2);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(82, 22);
            btnReview.TabIndex = 8;
            btnReview.Text = "btnReview";
            btnReview.UseVisualStyleBackColor = true;
            btnReview.Visible = false;
            btnReview.Click += btnReview_Click;
            // 
            // lblAverageRating
            // 
            lblAverageRating.Anchor = AnchorStyles.None;
            lblAverageRating.AutoSize = true;
            lblAverageRating.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblAverageRating.Location = new Point(25, 120);
            lblAverageRating.Name = "lblAverageRating";
            lblAverageRating.Size = new Size(97, 17);
            lblAverageRating.TabIndex = 9;
            lblAverageRating.Text = "Average Rating";
            // 
            // kryptonRichTextBox1
            // 
            kryptonRichTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonRichTextBox1.Location = new Point(24, 160);
            kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            kryptonRichTextBox1.Size = new Size(652, 118);
            kryptonRichTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonRichTextBox1.StateCommon.Border.Width = 1;
            kryptonRichTextBox1.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonRichTextBox1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonRichTextBox1.TabIndex = 10;
            kryptonRichTextBox1.Text = "Review";
            // 
            // kryptonButtonReadBook
            // 
            kryptonButtonReadBook.Anchor = AnchorStyles.Bottom;
            kryptonButtonReadBook.Location = new Point(25, 296);
            kryptonButtonReadBook.Name = "kryptonButtonReadBook";
            kryptonButtonReadBook.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReadBook.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReadBook.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonReadBook.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReadBook.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReadBook.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonReadBook.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonReadBook.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonReadBook.OverrideDefault.Border.Width = 1;
            kryptonButtonReadBook.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonReadBook.Size = new Size(155, 43);
            kryptonButtonReadBook.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReadBook.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReadBook.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonReadBook.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReadBook.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReadBook.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonReadBook.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonReadBook.StateCommon.Border.Rounding = 20F;
            kryptonButtonReadBook.StateCommon.Border.Width = 1;
            kryptonButtonReadBook.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonReadBook.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonReadBook.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonReadBook.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonReadBook.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonReadBook.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonReadBook.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonReadBook.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonReadBook.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonReadBook.StatePressed.Border.Rounding = 20F;
            kryptonButtonReadBook.StatePressed.Border.Width = 1;
            kryptonButtonReadBook.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonReadBook.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonReadBook.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonReadBook.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReadBook.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReadBook.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonReadBook.StateTracking.Border.Rounding = 20F;
            kryptonButtonReadBook.StateTracking.Border.Width = 1;
            kryptonButtonReadBook.TabIndex = 25;
            kryptonButtonReadBook.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonReadBook.Values.Text = "Read ";
            kryptonButtonReadBook.Click += kryptonButtonReadBook_Click;
            // 
            // kryptonButtonReview
            // 
            kryptonButtonReview.Anchor = AnchorStyles.Bottom;
            kryptonButtonReview.Location = new Point(214, 296);
            kryptonButtonReview.Name = "kryptonButtonReview";
            kryptonButtonReview.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReview.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReview.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonReview.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReview.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReview.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonReview.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonReview.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonReview.OverrideDefault.Border.Width = 1;
            kryptonButtonReview.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonReview.Size = new Size(155, 43);
            kryptonButtonReview.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReview.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReview.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonReview.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReview.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReview.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonReview.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonReview.StateCommon.Border.Rounding = 20F;
            kryptonButtonReview.StateCommon.Border.Width = 1;
            kryptonButtonReview.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonReview.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonReview.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonReview.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonReview.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonReview.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonReview.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonReview.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonReview.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonReview.StatePressed.Border.Rounding = 20F;
            kryptonButtonReview.StatePressed.Border.Width = 1;
            kryptonButtonReview.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonReview.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonReview.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonReview.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonReview.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonReview.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonReview.StateTracking.Border.Rounding = 20F;
            kryptonButtonReview.StateTracking.Border.Width = 1;
            kryptonButtonReview.TabIndex = 26;
            kryptonButtonReview.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonReview.Values.Text = "Review";
            kryptonButtonReview.Click += kryptonButtonReview_Click;
            // 
            // kryptonButtonClose
            // 
            kryptonButtonClose.Anchor = AnchorStyles.Bottom;
            kryptonButtonClose.Location = new Point(416, 296);
            kryptonButtonClose.Name = "kryptonButtonClose";
            kryptonButtonClose.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonClose.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonClose.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonClose.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonClose.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonClose.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonClose.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonClose.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonClose.OverrideDefault.Border.Width = 1;
            kryptonButtonClose.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonClose.Size = new Size(155, 43);
            kryptonButtonClose.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonClose.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonClose.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonClose.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonClose.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonClose.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonClose.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonClose.StateCommon.Border.Rounding = 20F;
            kryptonButtonClose.StateCommon.Border.Width = 1;
            kryptonButtonClose.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonClose.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonClose.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonClose.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonClose.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonClose.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonClose.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonClose.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonClose.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonClose.StatePressed.Border.Rounding = 20F;
            kryptonButtonClose.StatePressed.Border.Width = 1;
            kryptonButtonClose.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonClose.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonClose.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonClose.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonClose.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonClose.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonClose.StateTracking.Border.Rounding = 20F;
            kryptonButtonClose.StateTracking.Border.Width = 1;
            kryptonButtonClose.TabIndex = 27;
            kryptonButtonClose.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonClose.Values.Text = "Close";
            kryptonButtonClose.Click += kryptonButtonClose_Click;
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
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 362);
            Controls.Add(kryptonButtonClose);
            Controls.Add(kryptonButtonReview);
            Controls.Add(kryptonButtonReadBook);
            Controls.Add(kryptonRichTextBox1);
            Controls.Add(lblAverageRating);
            Controls.Add(btnReview);
            Controls.Add(btnClose);
            Controls.Add(btnReadBook);
            Controls.Add(lblPublishedDate);
            Controls.Add(txtDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookDetailForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookDetailForm";
            Load += BookDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblCategory;
        private TextBox txtDescription;
        private Label lblPublishedDate;
        private Button btnReadBook;
        private Button btnClose;
        private Button btnReview;
        private Label lblAverageRating;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButtonReadBook;
        private Krypton.Toolkit.KryptonButton kryptonButtonReview;
        private Krypton.Toolkit.KryptonButton kryptonButtonClose;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}