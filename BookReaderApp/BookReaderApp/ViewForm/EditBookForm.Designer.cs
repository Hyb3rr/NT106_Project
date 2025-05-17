namespace BookReaderApp.ViewForm
{
    partial class EditBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookForm));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpPublishedDate = new DateTimePicker();
            txtFilePath = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            btnBrowseFile = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            cmbCategory = new ComboBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonComboBoxRole = new Krypton.Toolkit.KryptonComboBox();
            kryptonTextBoxTitle = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxAuthor = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxFilePath = new Krypton.Toolkit.KryptonTextBox();
            kryptonButtonSave = new Krypton.Toolkit.KryptonButton();
            kryptonButtonCancel = new Krypton.Toolkit.KryptonButton();
            kryptonButtonBrowse = new Krypton.Toolkit.KryptonButton();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxRole).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label3.Location = new Point(53, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 41;
            label3.Text = "FilePath";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label2.Location = new Point(53, 113);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 40;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label1.Location = new Point(53, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 39;
            label1.Text = "Titile";
            // 
            // dtpPublishedDate
            // 
            dtpPublishedDate.Anchor = AnchorStyles.None;
            dtpPublishedDate.Location = new Point(637, 152);
            dtpPublishedDate.Margin = new Padding(2);
            dtpPublishedDate.Name = "dtpPublishedDate";
            dtpPublishedDate.Size = new Size(219, 24);
            dtpPublishedDate.TabIndex = 38;
            dtpPublishedDate.Visible = false;
            // 
            // txtFilePath
            // 
            txtFilePath.Anchor = AnchorStyles.None;
            txtFilePath.Location = new Point(623, 224);
            txtFilePath.Margin = new Padding(2);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(110, 24);
            txtFilePath.TabIndex = 37;
            txtFilePath.Visible = false;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(0, 0);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.None;
            txtTitle.Location = new Point(613, 184);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(110, 24);
            txtTitle.TabIndex = 35;
            txtTitle.Visible = false;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Location = new Point(408, 273);
            btnBrowseFile.Margin = new Padding(2);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(159, 57);
            btnBrowseFile.TabIndex = 34;
            btnBrowseFile.Text = "btnBrowseFile";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Visible = false;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 273);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 57);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(65, 273);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 57);
            btnSave.TabIndex = 32;
            btnSave.Text = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.None;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Tình yêu", "Học đường" });
            cmbCategory.Location = new Point(686, 37);
            cmbCategory.Margin = new Padding(2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(132, 23);
            cmbCategory.TabIndex = 31;
            cmbCategory.Visible = false;
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
            kryptonComboBoxRole.Location = new Point(288, 55);
            kryptonComboBoxRole.Margin = new Padding(2, 3, 2, 3);
            kryptonComboBoxRole.Name = "kryptonComboBoxRole";
            kryptonComboBoxRole.Size = new Size(149, 34);
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
            kryptonComboBoxRole.TabIndex = 42;
            // 
            // kryptonTextBoxTitle
            // 
            kryptonTextBoxTitle.Anchor = AnchorStyles.None;
            kryptonTextBoxTitle.Location = new Point(116, 55);
            kryptonTextBoxTitle.Margin = new Padding(2, 3, 2, 3);
            kryptonTextBoxTitle.Name = "kryptonTextBoxTitle";
            kryptonTextBoxTitle.Size = new Size(149, 30);
            kryptonTextBoxTitle.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxTitle.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxTitle.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxTitle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxTitle.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxTitle.StateCommon.Border.Width = 1;
            kryptonTextBoxTitle.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxTitle.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxTitle.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxTitle.TabIndex = 43;
            // 
            // kryptonTextBoxAuthor
            // 
            kryptonTextBoxAuthor.Anchor = AnchorStyles.None;
            kryptonTextBoxAuthor.Location = new Point(116, 100);
            kryptonTextBoxAuthor.Margin = new Padding(2);
            kryptonTextBoxAuthor.Name = "kryptonTextBoxAuthor";
            kryptonTextBoxAuthor.Size = new Size(149, 30);
            kryptonTextBoxAuthor.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxAuthor.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxAuthor.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxAuthor.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxAuthor.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxAuthor.StateCommon.Border.Width = 1;
            kryptonTextBoxAuthor.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxAuthor.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxAuthor.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxAuthor.TabIndex = 44;
            kryptonTextBoxAuthor.TextChanged += kryptonTextBoxAuthor_TextChanged;
            // 
            // kryptonTextBoxFilePath
            // 
            kryptonTextBoxFilePath.Anchor = AnchorStyles.None;
            kryptonTextBoxFilePath.Location = new Point(116, 145);
            kryptonTextBoxFilePath.Margin = new Padding(2, 3, 2, 3);
            kryptonTextBoxFilePath.Name = "kryptonTextBoxFilePath";
            kryptonTextBoxFilePath.Size = new Size(149, 30);
            kryptonTextBoxFilePath.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxFilePath.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxFilePath.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxFilePath.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxFilePath.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxFilePath.StateCommon.Border.Width = 1;
            kryptonTextBoxFilePath.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxFilePath.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxFilePath.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxFilePath.TabIndex = 45;
            // 
            // kryptonButtonSave
            // 
            kryptonButtonSave.Anchor = AnchorStyles.None;
            kryptonButtonSave.Location = new Point(71, 237);
            kryptonButtonSave.Margin = new Padding(2, 3, 2, 3);
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
            kryptonButtonSave.TabIndex = 46;
            kryptonButtonSave.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonSave.Values.Text = "Save";
            kryptonButtonSave.Click += kryptonButtonSave_Click;
            // 
            // kryptonButtonCancel
            // 
            kryptonButtonCancel.Anchor = AnchorStyles.None;
            kryptonButtonCancel.Location = new Point(247, 237);
            kryptonButtonCancel.Margin = new Padding(2, 3, 2, 3);
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
            kryptonButtonCancel.TabIndex = 47;
            kryptonButtonCancel.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonCancel.Values.Text = "Cancel";
            kryptonButtonCancel.Click += kryptonButtonCancel_Click;
            // 
            // kryptonButtonBrowse
            // 
            kryptonButtonBrowse.Anchor = AnchorStyles.None;
            kryptonButtonBrowse.Location = new Point(415, 237);
            kryptonButtonBrowse.Margin = new Padding(2, 3, 2, 3);
            kryptonButtonBrowse.Name = "kryptonButtonBrowse";
            kryptonButtonBrowse.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBrowse.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBrowse.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonBrowse.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBrowse.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBrowse.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonBrowse.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonBrowse.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonBrowse.OverrideDefault.Border.Width = 1;
            kryptonButtonBrowse.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonBrowse.Size = new Size(155, 43);
            kryptonButtonBrowse.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBrowse.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBrowse.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonBrowse.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBrowse.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBrowse.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonBrowse.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonBrowse.StateCommon.Border.Rounding = 20F;
            kryptonButtonBrowse.StateCommon.Border.Width = 1;
            kryptonButtonBrowse.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonBrowse.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonBrowse.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonBrowse.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonBrowse.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonBrowse.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonBrowse.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonBrowse.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonBrowse.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonBrowse.StatePressed.Border.Rounding = 20F;
            kryptonButtonBrowse.StatePressed.Border.Width = 1;
            kryptonButtonBrowse.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonBrowse.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonBrowse.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonBrowse.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonBrowse.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonBrowse.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonBrowse.StateTracking.Border.Rounding = 20F;
            kryptonButtonBrowse.StateTracking.Border.Width = 1;
            kryptonButtonBrowse.TabIndex = 48;
            kryptonButtonBrowse.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonBrowse.Values.Text = "Browse File";
            kryptonButtonBrowse.Click += kryptonButtonBrowse_Click;
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.Anchor = AnchorStyles.None;
            kryptonDateTimePicker1.Location = new Point(462, 55);
            kryptonDateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(182, 33);
            kryptonDateTimePicker1.StateCommon.Back.Color1 = Color.White;
            kryptonDateTimePicker1.StateCommon.Border.Color1 = Color.FromArgb(242, 242, 242);
            kryptonDateTimePicker1.StateCommon.Border.Color2 = Color.FromArgb(242, 242, 242);
            kryptonDateTimePicker1.StateCommon.Border.Rounding = 20F;
            kryptonDateTimePicker1.StateCommon.Border.Width = 1;
            kryptonDateTimePicker1.StateCommon.Content.Color1 = Color.Gray;
            kryptonDateTimePicker1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonDateTimePicker1.TabIndex = 49;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 299);
            Controls.Add(kryptonDateTimePicker1);
            Controls.Add(kryptonButtonBrowse);
            Controls.Add(kryptonButtonCancel);
            Controls.Add(kryptonButtonSave);
            Controls.Add(kryptonTextBoxFilePath);
            Controls.Add(kryptonTextBoxTitle);
            Controls.Add(kryptonComboBoxRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpPublishedDate);
            Controls.Add(txtFilePath);
            Controls.Add(kryptonTextBoxAuthor);
            Controls.Add(txtTitle);
            Controls.Add(btnBrowseFile);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCategory);
            Font = new Font("Calibri", 10F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(2);
            Name = "EditBookForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditBookForm";
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxRole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpPublishedDate;
        private TextBox txtFilePath;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Button btnBrowseFile;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbCategory;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBoxRole;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxTitle;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxAuthor;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxFilePath;
        private Krypton.Toolkit.KryptonButton kryptonButtonSave;
        private Krypton.Toolkit.KryptonButton kryptonButtonCancel;
        private Krypton.Toolkit.KryptonButton kryptonButtonBrowse;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
    }
}