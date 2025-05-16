namespace BookReaderApp.ViewForm
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            txtSearch = new TextBox();
            dgvBooks = new DataGridView();
            cmbSearchType = new ComboBox();
            button1 = new Button();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButtonViewDetails = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            kryptonColorDialog1 = new Krypton.Toolkit.KryptonColorDialog();
            fontDialog1 = new FontDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            kryptonDataGridViewLibrary = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewLibrary).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(739, 109);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(110, 23);
            txtSearch.TabIndex = 0;
            txtSearch.Visible = false;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvBooks
            // 
            dgvBooks.Anchor = AnchorStyles.None;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(707, 66);
            dgvBooks.Margin = new Padding(3, 2, 3, 2);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(57, 27);
            dgvBooks.TabIndex = 1;
            dgvBooks.Visible = false;
            // 
            // cmbSearchType
            // 
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Items.AddRange(new object[] { "Tiêu đề", "Tác giả", "Thể loại" });
            cmbSearchType.Location = new Point(739, 82);
            cmbSearchType.Margin = new Padding(3, 2, 3, 2);
            cmbSearchType.Name = "cmbSearchType";
            cmbSearchType.Size = new Size(133, 23);
            cmbSearchType.TabIndex = 2;
            cmbSearchType.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(739, 136);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
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
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Bottom;
            kryptonButton1.Location = new Point(35, 356);
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
            kryptonButton1.TabIndex = 8;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Read book";
            kryptonButton1.Click += kryptonButtonReadBook;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.Bottom;
            kryptonButton2.Location = new Point(196, 356);
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
            kryptonButton2.TabIndex = 9;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Add to library";
            kryptonButton2.Click += kryptonButtonAddToLib;
            // 
            // kryptonButtonViewDetails
            // 
            kryptonButtonViewDetails.Anchor = AnchorStyles.Bottom;
            kryptonButtonViewDetails.Location = new Point(357, 356);
            kryptonButtonViewDetails.Name = "kryptonButtonViewDetails";
            kryptonButtonViewDetails.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonViewDetails.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonViewDetails.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonViewDetails.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonViewDetails.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonViewDetails.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonViewDetails.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonViewDetails.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonViewDetails.OverrideDefault.Border.Width = 1;
            kryptonButtonViewDetails.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonViewDetails.Size = new Size(155, 43);
            kryptonButtonViewDetails.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonViewDetails.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonViewDetails.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonViewDetails.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonViewDetails.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonViewDetails.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonViewDetails.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonViewDetails.StateCommon.Border.Rounding = 20F;
            kryptonButtonViewDetails.StateCommon.Border.Width = 1;
            kryptonButtonViewDetails.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonViewDetails.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonViewDetails.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonViewDetails.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonViewDetails.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonViewDetails.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonViewDetails.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonViewDetails.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonViewDetails.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonViewDetails.StatePressed.Border.Rounding = 20F;
            kryptonButtonViewDetails.StatePressed.Border.Width = 1;
            kryptonButtonViewDetails.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonViewDetails.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonViewDetails.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonViewDetails.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonViewDetails.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonViewDetails.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonViewDetails.StateTracking.Border.Rounding = 20F;
            kryptonButtonViewDetails.StateTracking.Border.Width = 1;
            kryptonButtonViewDetails.TabIndex = 10;
            kryptonButtonViewDetails.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonViewDetails.Values.Text = "View details";
            kryptonButtonViewDetails.Click += kryptonButtonViewDetailsClick;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Anchor = AnchorStyles.Bottom;
            kryptonButton3.Location = new Point(523, 356);
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
            kryptonButton3.Values.Text = "Open library";
            kryptonButton3.Click += kryptonButtonOpenLib;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonTextBox1.Location = new Point(524, 16);
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
            kryptonTextBox1.TabIndex = 12;
            kryptonTextBox1.Text = "Search";
            kryptonTextBox1.TextChanged += kryptonSearch_TextChanged;
            kryptonTextBox1.Enter += kryptonTextBox1_Enter;
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonComboBox1.DropDownWidth = 138;
            kryptonComboBox1.Location = new Point(355, 16);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(150, 34);
            kryptonComboBox1.StateCommon.ComboBox.Back.Color1 = Color.White;
            kryptonComboBox1.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBox1.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBox1.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 20F;
            kryptonComboBox1.StateCommon.ComboBox.Border.Width = 1;
            kryptonComboBox1.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            kryptonComboBox1.StateCommon.ComboBox.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBox1.StateCommon.ComboBox.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.StateCommon.DropBack.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBox1.StateCommon.DropBack.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBox1.StateCommon.DropBack.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBox1.StateCommon.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBox1.StateCommon.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBox1.StateTracking.Item.Back.Color1 = Color.Blue;
            kryptonComboBox1.StateTracking.Item.Back.Color2 = Color.FromArgb(128, 255, 255);
            kryptonComboBox1.StateTracking.Item.Back.ColorAngle = 10F;
            kryptonComboBox1.StateTracking.Item.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonComboBox1.StateTracking.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBox1.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            kryptonComboBox1.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            kryptonComboBox1.StateTracking.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBox1.TabIndex = 13;
            // 
            // kryptonColorDialog1
            // 
            kryptonColorDialog1.Color = Color.Black;
            kryptonColorDialog1.Icon = (Icon)resources.GetObject("kryptonColorDialog1.Icon");
            kryptonColorDialog1.Title = null;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // kryptonDataGridViewLibrary
            // 
            kryptonDataGridViewLibrary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridViewLibrary.BorderStyle = BorderStyle.None;
            kryptonDataGridViewLibrary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridViewLibrary.Location = new Point(37, 56);
            kryptonDataGridViewLibrary.Name = "kryptonDataGridViewLibrary";
            kryptonDataGridViewLibrary.Size = new Size(637, 278);
            kryptonDataGridViewLibrary.StateCommon.Background.Color1 = Color.White;
            kryptonDataGridViewLibrary.StateCommon.Background.Color2 = Color.White;
            kryptonDataGridViewLibrary.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridViewLibrary.StateCommon.DataCell.Border.Rounding = 20F;
            kryptonDataGridViewLibrary.StateCommon.DataCell.Border.Width = 1;
            kryptonDataGridViewLibrary.TabIndex = 14;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 405);
            Controls.Add(kryptonDataGridViewLibrary);
            Controls.Add(kryptonComboBox1);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButtonViewDetails);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(button1);
            Controls.Add(cmbSearchType);
            Controls.Add(dgvBooks);
            Controls.Add(txtSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewLibrary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgvBooks;
        private ComboBox cmbSearchType;
        private Button button1;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButtonViewDetails;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonColorDialog kryptonColorDialog1;
        private FontDialog fontDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewLibrary;
    }
}