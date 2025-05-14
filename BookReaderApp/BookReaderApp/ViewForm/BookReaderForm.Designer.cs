namespace BookReaderApp.ViewForm
{
    partial class BookReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookReaderForm));
            panel1 = new Panel();
            checkBox_ChangeTheme = new CheckBox();
            txtNote = new TextBox();
            btnBookmark = new Button();
            btnSaveNote = new Button();
            txtPageNumber = new TextBox();
            btnGoToPage = new Button();
            lblPageInfo = new Label();
            listBoxBookmarks = new ListBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonButtonBookmark = new Krypton.Toolkit.KryptonButton();
            kryptonButtonSaveNote = new Krypton.Toolkit.KryptonButton();
            kryptonButtonGoToPage = new Krypton.Toolkit.KryptonButton();
            kryptonTextBoxPageNumber = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxNote = new Krypton.Toolkit.KryptonTextBox();
            kryptonListBoxBookMark = new Krypton.Toolkit.KryptonListBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.Location = new Point(615, 275);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(51, 40);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // checkBox_ChangeTheme
            // 
            checkBox_ChangeTheme.Anchor = AnchorStyles.Bottom;
            checkBox_ChangeTheme.AutoSize = true;
            checkBox_ChangeTheme.Font = new Font("Calibri", 10F);
            checkBox_ChangeTheme.Location = new Point(144, 240);
            checkBox_ChangeTheme.Margin = new Padding(3, 2, 3, 2);
            checkBox_ChangeTheme.Name = "checkBox_ChangeTheme";
            checkBox_ChangeTheme.Size = new Size(104, 21);
            checkBox_ChangeTheme.TabIndex = 1;
            checkBox_ChangeTheme.Text = "Chang Theme";
            checkBox_ChangeTheme.UseVisualStyleBackColor = true;
            checkBox_ChangeTheme.CheckedChanged += checkBox_ChangeTheme_CheckedChanged;
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Bottom;
            txtNote.Location = new Point(569, 307);
            txtNote.Margin = new Padding(3, 2, 3, 2);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(110, 23);
            txtNote.TabIndex = 2;
            txtNote.Visible = false;
            // 
            // btnBookmark
            // 
            btnBookmark.Anchor = AnchorStyles.Bottom;
            btnBookmark.Location = new Point(91, 334);
            btnBookmark.Margin = new Padding(3, 2, 3, 2);
            btnBookmark.Name = "btnBookmark";
            btnBookmark.Size = new Size(82, 22);
            btnBookmark.TabIndex = 3;
            btnBookmark.Text = "btnBookmark";
            btnBookmark.UseVisualStyleBackColor = true;
            btnBookmark.Visible = false;
            btnBookmark.Click += btnBookmark_Click;
            // 
            // btnSaveNote
            // 
            btnSaveNote.Anchor = AnchorStyles.Bottom;
            btnSaveNote.Location = new Point(246, 334);
            btnSaveNote.Margin = new Padding(3, 2, 3, 2);
            btnSaveNote.Name = "btnSaveNote";
            btnSaveNote.Size = new Size(82, 22);
            btnSaveNote.TabIndex = 4;
            btnSaveNote.Text = "btnSaveNote";
            btnSaveNote.UseVisualStyleBackColor = true;
            btnSaveNote.Visible = false;
            btnSaveNote.Click += btnSaveNote_Click;
            // 
            // txtPageNumber
            // 
            txtPageNumber.Anchor = AnchorStyles.Bottom;
            txtPageNumber.Location = new Point(609, 319);
            txtPageNumber.Margin = new Padding(3, 2, 3, 2);
            txtPageNumber.Name = "txtPageNumber";
            txtPageNumber.Size = new Size(110, 23);
            txtPageNumber.TabIndex = 5;
            txtPageNumber.Visible = false;
            // 
            // btnGoToPage
            // 
            btnGoToPage.Anchor = AnchorStyles.Bottom;
            btnGoToPage.Location = new Point(430, 334);
            btnGoToPage.Margin = new Padding(3, 2, 3, 2);
            btnGoToPage.Name = "btnGoToPage";
            btnGoToPage.Size = new Size(82, 22);
            btnGoToPage.TabIndex = 6;
            btnGoToPage.Text = "btnGoToPage";
            btnGoToPage.UseVisualStyleBackColor = true;
            btnGoToPage.Visible = false;
            btnGoToPage.Click += btnGoToPage_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Calibri", 10F);
            lblPageInfo.Location = new Point(42, 245);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(58, 17);
            lblPageInfo.TabIndex = 7;
            lblPageInfo.Text = "PageInfo";
            // 
            // listBoxBookmarks
            // 
            listBoxBookmarks.Anchor = AnchorStyles.Bottom;
            listBoxBookmarks.FormattingEnabled = true;
            listBoxBookmarks.ItemHeight = 15;
            listBoxBookmarks.Location = new Point(672, 206);
            listBoxBookmarks.Margin = new Padding(3, 2, 3, 2);
            listBoxBookmarks.Name = "listBoxBookmarks";
            listBoxBookmarks.Size = new Size(132, 79);
            listBoxBookmarks.TabIndex = 8;
            listBoxBookmarks.Visible = false;
            listBoxBookmarks.SelectedIndexChanged += listBoxBookmarks_SelectedIndexChanged;
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
            // kryptonButtonBookmark
            // 
            kryptonButtonBookmark.Anchor = AnchorStyles.Bottom;
            kryptonButtonBookmark.Location = new Point(45, 275);
            kryptonButtonBookmark.Name = "kryptonButtonBookmark";
            kryptonButtonBookmark.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBookmark.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBookmark.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonBookmark.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBookmark.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBookmark.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonBookmark.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonBookmark.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonBookmark.OverrideDefault.Border.Width = 1;
            kryptonButtonBookmark.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonBookmark.Size = new Size(155, 43);
            kryptonButtonBookmark.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBookmark.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBookmark.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonBookmark.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBookmark.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBookmark.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonBookmark.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonBookmark.StateCommon.Border.Rounding = 20F;
            kryptonButtonBookmark.StateCommon.Border.Width = 1;
            kryptonButtonBookmark.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonBookmark.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonBookmark.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonBookmark.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonBookmark.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonBookmark.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonBookmark.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonBookmark.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonBookmark.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonBookmark.StatePressed.Border.Rounding = 20F;
            kryptonButtonBookmark.StatePressed.Border.Width = 1;
            kryptonButtonBookmark.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonBookmark.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonBookmark.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonBookmark.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBookmark.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBookmark.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonBookmark.StateTracking.Border.Rounding = 20F;
            kryptonButtonBookmark.StateTracking.Border.Width = 1;
            kryptonButtonBookmark.TabIndex = 25;
            kryptonButtonBookmark.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonBookmark.Values.Text = "Bookmark";
            kryptonButtonBookmark.Click += kryptonButtonBookmark_Click;
            // 
            // kryptonButtonSaveNote
            // 
            kryptonButtonSaveNote.Anchor = AnchorStyles.Bottom;
            kryptonButtonSaveNote.Location = new Point(216, 275);
            kryptonButtonSaveNote.Name = "kryptonButtonSaveNote";
            kryptonButtonSaveNote.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSaveNote.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSaveNote.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonSaveNote.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSaveNote.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSaveNote.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonSaveNote.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonSaveNote.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonSaveNote.OverrideDefault.Border.Width = 1;
            kryptonButtonSaveNote.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonSaveNote.Size = new Size(155, 43);
            kryptonButtonSaveNote.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSaveNote.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSaveNote.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonSaveNote.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSaveNote.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSaveNote.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonSaveNote.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonSaveNote.StateCommon.Border.Rounding = 20F;
            kryptonButtonSaveNote.StateCommon.Border.Width = 1;
            kryptonButtonSaveNote.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonSaveNote.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonSaveNote.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonSaveNote.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonSaveNote.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonSaveNote.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonSaveNote.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonSaveNote.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonSaveNote.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonSaveNote.StatePressed.Border.Rounding = 20F;
            kryptonButtonSaveNote.StatePressed.Border.Width = 1;
            kryptonButtonSaveNote.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonSaveNote.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonSaveNote.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonSaveNote.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonSaveNote.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonSaveNote.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonSaveNote.StateTracking.Border.Rounding = 20F;
            kryptonButtonSaveNote.StateTracking.Border.Width = 1;
            kryptonButtonSaveNote.TabIndex = 26;
            kryptonButtonSaveNote.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonSaveNote.Values.Text = "Save note";
            kryptonButtonSaveNote.Click += kryptonButtonSaveNote_Click;
            // 
            // kryptonButtonGoToPage
            // 
            kryptonButtonGoToPage.Anchor = AnchorStyles.Bottom;
            kryptonButtonGoToPage.Location = new Point(396, 275);
            kryptonButtonGoToPage.Name = "kryptonButtonGoToPage";
            kryptonButtonGoToPage.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonGoToPage.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonGoToPage.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonGoToPage.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonGoToPage.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonGoToPage.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonGoToPage.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonGoToPage.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonGoToPage.OverrideDefault.Border.Width = 1;
            kryptonButtonGoToPage.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonGoToPage.Size = new Size(155, 43);
            kryptonButtonGoToPage.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonGoToPage.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonGoToPage.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonGoToPage.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonGoToPage.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonGoToPage.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonGoToPage.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonGoToPage.StateCommon.Border.Rounding = 20F;
            kryptonButtonGoToPage.StateCommon.Border.Width = 1;
            kryptonButtonGoToPage.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonGoToPage.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonGoToPage.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonGoToPage.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonGoToPage.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonGoToPage.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonGoToPage.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonGoToPage.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonGoToPage.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonGoToPage.StatePressed.Border.Rounding = 20F;
            kryptonButtonGoToPage.StatePressed.Border.Width = 1;
            kryptonButtonGoToPage.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonGoToPage.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonGoToPage.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonGoToPage.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonGoToPage.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonGoToPage.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonGoToPage.StateTracking.Border.Rounding = 20F;
            kryptonButtonGoToPage.StateTracking.Border.Width = 1;
            kryptonButtonGoToPage.TabIndex = 27;
            kryptonButtonGoToPage.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonGoToPage.Values.Text = "Go to page";
            kryptonButtonGoToPage.Click += kryptonButtonGoToPage_Click;
            // 
            // kryptonTextBoxPageNumber
            // 
            kryptonTextBoxPageNumber.Anchor = AnchorStyles.Bottom;
            kryptonTextBoxPageNumber.Location = new Point(476, 225);
            kryptonTextBoxPageNumber.Name = "kryptonTextBoxPageNumber";
            kryptonTextBoxPageNumber.Size = new Size(150, 30);
            kryptonTextBoxPageNumber.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxPageNumber.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxPageNumber.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxPageNumber.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxPageNumber.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxPageNumber.StateCommon.Border.Width = 1;
            kryptonTextBoxPageNumber.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxPageNumber.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxPageNumber.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxPageNumber.TabIndex = 28;
            kryptonTextBoxPageNumber.Text = "Page Number";
            // 
            // kryptonTextBoxNote
            // 
            kryptonTextBoxNote.Anchor = AnchorStyles.Bottom;
            kryptonTextBoxNote.Location = new Point(307, 225);
            kryptonTextBoxNote.Name = "kryptonTextBoxNote";
            kryptonTextBoxNote.Size = new Size(150, 30);
            kryptonTextBoxNote.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxNote.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxNote.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxNote.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxNote.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxNote.StateCommon.Border.Width = 1;
            kryptonTextBoxNote.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxNote.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxNote.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxNote.TabIndex = 29;
            kryptonTextBoxNote.Text = "Note";
            // 
            // kryptonListBoxBookMark
            // 
            kryptonListBoxBookMark.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonListBoxBookMark.Location = new Point(639, 12);
            kryptonListBoxBookMark.Name = "kryptonListBoxBookMark";
            kryptonListBoxBookMark.Padding = new Padding(10, 0, 10, 0);
            kryptonListBoxBookMark.Size = new Size(169, 134);
            kryptonListBoxBookMark.StateCommon.Back.Color1 = Color.White;
            kryptonListBoxBookMark.StateCommon.Back.Color2 = Color.White;
            kryptonListBoxBookMark.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonListBoxBookMark.StateCommon.Border.Color1 = Color.Black;
            kryptonListBoxBookMark.StateCommon.Border.Color2 = Color.Black;
            kryptonListBoxBookMark.StateCommon.Border.Rounding = 20F;
            kryptonListBoxBookMark.StateCommon.Border.Width = 1;
            kryptonListBoxBookMark.TabIndex = 30;
            kryptonListBoxBookMark.SelectedIndexChanged += KryptonlistBoxBookmarks_SelectedIndexChanged;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Location = new Point(38, 12);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Padding = new Padding(10, 0, 10, 0);
            kryptonPanel1.Size = new Size(573, 193);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.StateCommon.Color2 = Color.White;
            kryptonPanel1.TabIndex = 0;
            // 
            // BookReaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 336);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonListBoxBookMark);
            Controls.Add(kryptonTextBoxNote);
            Controls.Add(kryptonTextBoxPageNumber);
            Controls.Add(kryptonButtonGoToPage);
            Controls.Add(kryptonButtonSaveNote);
            Controls.Add(kryptonButtonBookmark);
            Controls.Add(listBoxBookmarks);
            Controls.Add(lblPageInfo);
            Controls.Add(btnGoToPage);
            Controls.Add(txtPageNumber);
            Controls.Add(btnSaveNote);
            Controls.Add(btnBookmark);
            Controls.Add(txtNote);
            Controls.Add(checkBox_ChangeTheme);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookReaderForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookReaderForm";
            Load += BookReaderForm_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox_ChangeTheme;
        private TextBox txtNote;
        private Button btnBookmark;
        private Button btnSaveNote;
        private TextBox txtPageNumber;
        private Button btnGoToPage;
        private Label lblPageInfo;
        private ListBox listBoxBookmarks;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonButton kryptonButtonBookmark;
        private Krypton.Toolkit.KryptonButton kryptonButtonSaveNote;
        private Krypton.Toolkit.KryptonButton kryptonButtonGoToPage;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxPageNumber;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxNote;
        private Krypton.Toolkit.KryptonListBox kryptonListBoxBookMark;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}