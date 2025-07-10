namespace BookReaderApp.ViewForm
{
    partial class UserLibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLibraryForm));
            dgvLibrary = new DataGridView();
            btnReadBook = new Button();
            btnRemoveBook = new Button();
            btnSaveNote = new Button();
            btnReview = new Button();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonDataGridViewLibrary = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLibrary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewLibrary).BeginInit();
            SuspendLayout();
            // 
            // dgvLibrary
            // 
            dgvLibrary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibrary.Location = new Point(703, 52);
            dgvLibrary.Margin = new Padding(3, 2, 3, 2);
            dgvLibrary.Name = "dgvLibrary";
            dgvLibrary.RowHeadersWidth = 51;
            dgvLibrary.Size = new Size(15, 22);
            dgvLibrary.TabIndex = 0;
            dgvLibrary.Visible = false;
            // 
            // btnReadBook
            // 
            btnReadBook.Location = new Point(667, 92);
            btnReadBook.Margin = new Padding(3, 2, 3, 2);
            btnReadBook.Name = "btnReadBook";
            btnReadBook.Size = new Size(146, 29);
            btnReadBook.TabIndex = 1;
            btnReadBook.Text = "btnReadBook";
            btnReadBook.UseVisualStyleBackColor = true;
            btnReadBook.Visible = false;
            btnReadBook.Click += btnReadBook_Click;
            // 
            // btnRemoveBook
            // 
            btnRemoveBook.Location = new Point(667, 125);
            btnRemoveBook.Margin = new Padding(3, 2, 3, 2);
            btnRemoveBook.Name = "btnRemoveBook";
            btnRemoveBook.Size = new Size(146, 29);
            btnRemoveBook.TabIndex = 2;
            btnRemoveBook.Text = "btnRemoveBook";
            btnRemoveBook.UseVisualStyleBackColor = true;
            btnRemoveBook.Visible = false;
            btnRemoveBook.Click += btnRemoveBook_Click;
            // 
            // btnSaveNote
            // 
            btnSaveNote.Location = new Point(667, 158);
            btnSaveNote.Margin = new Padding(3, 2, 3, 2);
            btnSaveNote.Name = "btnSaveNote";
            btnSaveNote.Size = new Size(146, 29);
            btnSaveNote.TabIndex = 3;
            btnSaveNote.Text = "btnSaveNote";
            btnSaveNote.UseVisualStyleBackColor = true;
            btnSaveNote.Visible = false;
            btnSaveNote.Click += btnSaveNote_Click;
            // 
            // btnReview
            // 
            btnReview.Location = new Point(667, 191);
            btnReview.Margin = new Padding(3, 2, 3, 2);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(146, 29);
            btnReview.TabIndex = 4;
            btnReview.Text = "btnReview";
            btnReview.UseVisualStyleBackColor = true;
            btnReview.Visible = false;
            btnReview.Click += btnReview_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Bottom;
            kryptonButton1.Location = new Point(3, 288);
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
            kryptonButton1.TabIndex = 9;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Đọc sách";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.Bottom;
            kryptonButton2.Location = new Point(181, 288);
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
            kryptonButton2.StatePressed.Back.Color1 = Color.White;
            kryptonButton2.StatePressed.Back.Color2 = Color.White;
            kryptonButton2.StatePressed.Back.ColorAngle = 135F;
            kryptonButton2.StatePressed.Border.Color1 = Color.FromArgb(255, 71, 66);
            kryptonButton2.StatePressed.Border.Color2 = Color.FromArgb(255, 71, 66);
            kryptonButton2.StatePressed.Border.ColorAngle = 135F;
            kryptonButton2.StatePressed.Border.Rounding = 20F;
            kryptonButton2.StatePressed.Border.Width = 1;
            kryptonButton2.StatePressed.Content.ShortText.Color1 = Color.FromArgb(255, 71, 46);
            kryptonButton2.StateTracking.Back.Color1 = Color.White;
            kryptonButton2.StateTracking.Back.Color2 = Color.White;
            kryptonButton2.StateTracking.Back.ColorAngle = 45F;
            kryptonButton2.StateTracking.Border.Color1 = Color.FromArgb(255, 71, 66);
            kryptonButton2.StateTracking.Border.Color2 = Color.FromArgb(255, 71, 66);
            kryptonButton2.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateTracking.Border.Rounding = 20F;
            kryptonButton2.StateTracking.Border.Width = 1;
            kryptonButton2.StateTracking.Content.ShortText.Color1 = Color.FromArgb(255, 71, 66);
            kryptonButton2.TabIndex = 10;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Xoá sách";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Anchor = AnchorStyles.Bottom;
            kryptonButton3.Location = new Point(354, 288);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton3.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton3.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton3.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton3.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton3.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton3.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton3.OverrideDefault.Border.Rounding = 20F;
            kryptonButton3.OverrideDefault.Border.Width = 1;
            kryptonButton3.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton3.Size = new Size(155, 43);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton3.StateCommon.Back.ColorAngle = 45F;
            kryptonButton3.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton3.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton3.StateCommon.Border.ColorAngle = 45F;
            kryptonButton3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton3.StateCommon.Border.Rounding = 20F;
            kryptonButton3.StateCommon.Border.Width = 1;
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton3.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton3.StatePressed.Back.ColorAngle = 135F;
            kryptonButton3.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton3.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton3.StatePressed.Border.ColorAngle = 135F;
            kryptonButton3.StatePressed.Border.Rounding = 20F;
            kryptonButton3.StatePressed.Border.Width = 1;
            kryptonButton3.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButton3.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButton3.StateTracking.Back.ColorAngle = 45F;
            kryptonButton3.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton3.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton3.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton3.StateTracking.Border.Rounding = 20F;
            kryptonButton3.StateTracking.Border.Width = 1;
            kryptonButton3.TabIndex = 11;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Text = "Lưu ghi chú";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Anchor = AnchorStyles.Bottom;
            kryptonButton4.Location = new Point(515, 288);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton4.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton4.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton4.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton4.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton4.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton4.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton4.OverrideDefault.Border.Rounding = 20F;
            kryptonButton4.OverrideDefault.Border.Width = 1;
            kryptonButton4.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton4.Size = new Size(155, 43);
            kryptonButton4.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton4.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton4.StateCommon.Back.ColorAngle = 45F;
            kryptonButton4.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton4.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton4.StateCommon.Border.ColorAngle = 45F;
            kryptonButton4.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton4.StateCommon.Border.Rounding = 20F;
            kryptonButton4.StateCommon.Border.Width = 1;
            kryptonButton4.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton4.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton4.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton4.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton4.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton4.StatePressed.Back.ColorAngle = 135F;
            kryptonButton4.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton4.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton4.StatePressed.Border.ColorAngle = 135F;
            kryptonButton4.StatePressed.Border.Rounding = 20F;
            kryptonButton4.StatePressed.Border.Width = 1;
            kryptonButton4.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButton4.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButton4.StateTracking.Back.ColorAngle = 45F;
            kryptonButton4.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton4.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton4.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton4.StateTracking.Border.Rounding = 20F;
            kryptonButton4.StateTracking.Border.Width = 1;
            kryptonButton4.TabIndex = 12;
            kryptonButton4.Values.DropDownArrowColor = Color.Empty;
            kryptonButton4.Values.Text = "Đánh giá ";
            kryptonButton4.Click += kryptonButton4_Click;
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
            // kryptonDataGridViewLibrary
            // 
            kryptonDataGridViewLibrary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridViewLibrary.BorderStyle = BorderStyle.None;
            kryptonDataGridViewLibrary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridViewLibrary.Location = new Point(35, 25);
            kryptonDataGridViewLibrary.Name = "kryptonDataGridViewLibrary";
            kryptonDataGridViewLibrary.Size = new Size(602, 257);
            kryptonDataGridViewLibrary.StateCommon.Background.Color1 = Color.White;
            kryptonDataGridViewLibrary.StateCommon.Background.Color2 = Color.White;
            kryptonDataGridViewLibrary.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridViewLibrary.StateCommon.DataCell.Border.Rounding = 20F;
            kryptonDataGridViewLibrary.StateCommon.DataCell.Border.Width = 1;
            kryptonDataGridViewLibrary.TabIndex = 13;
            // 
            // UserLibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(675, 347);
            Controls.Add(kryptonDataGridViewLibrary);
            Controls.Add(kryptonButton4);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(btnReview);
            Controls.Add(btnSaveNote);
            Controls.Add(btnRemoveBook);
            Controls.Add(btnReadBook);
            Controls.Add(dgvLibrary);
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserLibraryForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLibraryForm";
            Load += UserLibraryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibrary).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewLibrary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLibrary;
        private Button btnReadBook;
        private Button btnRemoveBook;
        private Button btnSaveNote;
        private Button btnReview;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewLibrary;
    }
}