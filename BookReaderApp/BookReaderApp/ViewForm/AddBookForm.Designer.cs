namespace BookReaderApp.ViewForm
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            cmbCategory = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnBrowseFile = new Button();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtFilePath = new TextBox();
            dtpPublishedDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbUploader = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonComboBoxCategory = new Krypton.Toolkit.KryptonComboBox();
            kryptonComboBoxUploader = new Krypton.Toolkit.KryptonComboBox();
            kryptonTextBoxFilePath = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxTitle = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxAuthor = new Krypton.Toolkit.KryptonTextBox();
            kryptonButtonBrowse = new Krypton.Toolkit.KryptonButton();
            kryptonButtonCancel = new Krypton.Toolkit.KryptonButton();
            kryptonButtonSave = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxUploader).BeginInit();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.None;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "1", "2", "3" });
            cmbCategory.Location = new Point(608, 35);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(133, 23);
            cmbCategory.TabIndex = 0;
            cmbCategory.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(246, 301);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 57);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(75, 301);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 57);
            btnSave.TabIndex = 20;
            btnSave.Text = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Anchor = AnchorStyles.None;
            btnBrowseFile.Location = new Point(416, 301);
            btnBrowseFile.Margin = new Padding(3, 2, 3, 2);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(158, 57);
            btnBrowseFile.TabIndex = 22;
            btnBrowseFile.Text = "btnBrowseFile";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Visible = false;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.None;
            txtTitle.Location = new Point(631, 131);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(110, 23);
            txtTitle.TabIndex = 23;
            txtTitle.Visible = false;
            // 
            // txtAuthor
            // 
            txtAuthor.Anchor = AnchorStyles.None;
            txtAuthor.Location = new Point(631, 158);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(110, 23);
            txtAuthor.TabIndex = 24;
            txtAuthor.Visible = false;
            // 
            // txtFilePath
            // 
            txtFilePath.Anchor = AnchorStyles.None;
            txtFilePath.Location = new Point(631, 187);
            txtFilePath.Margin = new Padding(3, 2, 3, 2);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(110, 23);
            txtFilePath.TabIndex = 25;
            txtFilePath.Visible = false;
            // 
            // dtpPublishedDate
            // 
            dtpPublishedDate.Anchor = AnchorStyles.None;
            dtpPublishedDate.Location = new Point(584, 301);
            dtpPublishedDate.Margin = new Padding(3, 2, 3, 2);
            dtpPublishedDate.Name = "dtpPublishedDate";
            dtpPublishedDate.Size = new Size(219, 23);
            dtpPublishedDate.TabIndex = 27;
            dtpPublishedDate.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label1.Location = new Point(211, 94);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 28;
            label1.Text = "Titile";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label2.Location = new Point(211, 139);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 29;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label3.Location = new Point(211, 184);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 30;
            label3.Text = "FilePath";
            // 
            // cmbUploader
            // 
            cmbUploader.Anchor = AnchorStyles.None;
            cmbUploader.FormattingEnabled = true;
            cmbUploader.Location = new Point(608, 8);
            cmbUploader.Margin = new Padding(3, 2, 3, 2);
            cmbUploader.Name = "cmbUploader";
            cmbUploader.Size = new Size(133, 23);
            cmbUploader.TabIndex = 31;
            cmbUploader.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label4.Location = new Point(59, 35);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 32;
            label4.Text = "Uploader";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10F, FontStyle.Bold);
            label5.Location = new Point(325, 35);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 33;
            label5.Text = "Category";
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
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.Anchor = AnchorStyles.None;
            kryptonDateTimePicker1.Location = new Point(491, 79);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(137, 33);
            kryptonDateTimePicker1.StateCommon.Back.Color1 = Color.White;
            kryptonDateTimePicker1.StateCommon.Border.Color1 = Color.FromArgb(242, 242, 242);
            kryptonDateTimePicker1.StateCommon.Border.Color2 = Color.FromArgb(242, 242, 242);
            kryptonDateTimePicker1.StateCommon.Border.Rounding = 20F;
            kryptonDateTimePicker1.StateCommon.Border.Width = 1;
            kryptonDateTimePicker1.StateCommon.Content.Color1 = Color.Gray;
            kryptonDateTimePicker1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonDateTimePicker1.TabIndex = 51;
            // 
            // kryptonComboBoxCategory
            // 
            kryptonComboBoxCategory.Anchor = AnchorStyles.None;
            kryptonComboBoxCategory.DropDownWidth = 138;
            kryptonComboBoxCategory.Location = new Point(416, 24);
            kryptonComboBoxCategory.Name = "kryptonComboBoxCategory";
            kryptonComboBoxCategory.Size = new Size(150, 34);
            kryptonComboBoxCategory.StateCommon.ComboBox.Back.Color1 = Color.White;
            kryptonComboBoxCategory.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxCategory.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxCategory.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBoxCategory.StateCommon.ComboBox.Border.Rounding = 20F;
            kryptonComboBoxCategory.StateCommon.ComboBox.Border.Width = 1;
            kryptonComboBoxCategory.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            kryptonComboBoxCategory.StateCommon.ComboBox.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxCategory.StateCommon.ComboBox.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxCategory.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBoxCategory.StateCommon.DropBack.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxCategory.StateCommon.DropBack.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxCategory.StateCommon.DropBack.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBoxCategory.StateCommon.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxCategory.StateCommon.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxCategory.StateTracking.Item.Back.Color1 = Color.Blue;
            kryptonComboBoxCategory.StateTracking.Item.Back.Color2 = Color.FromArgb(128, 255, 255);
            kryptonComboBoxCategory.StateTracking.Item.Back.ColorAngle = 10F;
            kryptonComboBoxCategory.StateTracking.Item.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonComboBoxCategory.StateTracking.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxCategory.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            kryptonComboBoxCategory.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            kryptonComboBoxCategory.StateTracking.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxCategory.TabIndex = 50;
            kryptonComboBoxCategory.Text = "Category";
            // 
            // kryptonComboBoxUploader
            // 
            kryptonComboBoxUploader.Anchor = AnchorStyles.None;
            kryptonComboBoxUploader.DropDownWidth = 138;
            kryptonComboBoxUploader.Location = new Point(144, 24);
            kryptonComboBoxUploader.Name = "kryptonComboBoxUploader";
            kryptonComboBoxUploader.Size = new Size(150, 34);
            kryptonComboBoxUploader.StateCommon.ComboBox.Back.Color1 = Color.White;
            kryptonComboBoxUploader.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxUploader.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxUploader.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBoxUploader.StateCommon.ComboBox.Border.Rounding = 20F;
            kryptonComboBoxUploader.StateCommon.ComboBox.Border.Width = 1;
            kryptonComboBoxUploader.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            kryptonComboBoxUploader.StateCommon.ComboBox.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxUploader.StateCommon.ComboBox.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxUploader.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBoxUploader.StateCommon.DropBack.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxUploader.StateCommon.DropBack.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxUploader.StateCommon.DropBack.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBoxUploader.StateCommon.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxUploader.StateCommon.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxUploader.StateTracking.Item.Back.Color1 = Color.Blue;
            kryptonComboBoxUploader.StateTracking.Item.Back.Color2 = Color.FromArgb(128, 255, 255);
            kryptonComboBoxUploader.StateTracking.Item.Back.ColorAngle = 10F;
            kryptonComboBoxUploader.StateTracking.Item.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonComboBoxUploader.StateTracking.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxUploader.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            kryptonComboBoxUploader.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            kryptonComboBoxUploader.StateTracking.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxUploader.TabIndex = 52;
            kryptonComboBoxUploader.Text = "Category";
            // 
            // kryptonTextBoxFilePath
            // 
            kryptonTextBoxFilePath.Anchor = AnchorStyles.None;
            kryptonTextBoxFilePath.Location = new Point(295, 169);
            kryptonTextBoxFilePath.Name = "kryptonTextBoxFilePath";
            kryptonTextBoxFilePath.Size = new Size(150, 30);
            kryptonTextBoxFilePath.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxFilePath.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxFilePath.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxFilePath.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxFilePath.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxFilePath.StateCommon.Border.Width = 1;
            kryptonTextBoxFilePath.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxFilePath.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxFilePath.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxFilePath.TabIndex = 55;
            kryptonTextBoxFilePath.Text = "FilePath";
            // 
            // kryptonTextBoxTitle
            // 
            kryptonTextBoxTitle.Anchor = AnchorStyles.None;
            kryptonTextBoxTitle.Location = new Point(295, 79);
            kryptonTextBoxTitle.Name = "kryptonTextBoxTitle";
            kryptonTextBoxTitle.Size = new Size(150, 30);
            kryptonTextBoxTitle.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxTitle.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxTitle.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxTitle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxTitle.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxTitle.StateCommon.Border.Width = 1;
            kryptonTextBoxTitle.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxTitle.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxTitle.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxTitle.TabIndex = 53;
            kryptonTextBoxTitle.Text = "Title";
            // 
            // kryptonTextBoxAuthor
            // 
            kryptonTextBoxAuthor.Anchor = AnchorStyles.None;
            kryptonTextBoxAuthor.Location = new Point(295, 124);
            kryptonTextBoxAuthor.Margin = new Padding(3, 2, 3, 2);
            kryptonTextBoxAuthor.Name = "kryptonTextBoxAuthor";
            kryptonTextBoxAuthor.Size = new Size(150, 30);
            kryptonTextBoxAuthor.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxAuthor.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxAuthor.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxAuthor.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxAuthor.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxAuthor.StateCommon.Border.Width = 1;
            kryptonTextBoxAuthor.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxAuthor.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxAuthor.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxAuthor.TabIndex = 54;
            kryptonTextBoxAuthor.Text = "Author";
            // 
            // kryptonButtonBrowse
            // 
            kryptonButtonBrowse.Anchor = AnchorStyles.None;
            kryptonButtonBrowse.Location = new Point(417, 243);
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
            kryptonButtonBrowse.TabIndex = 58;
            kryptonButtonBrowse.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonBrowse.Values.Text = "Browse File";
            kryptonButtonBrowse.Click += kryptonButtonBrowse_Click;
            // 
            // kryptonButtonCancel
            // 
            kryptonButtonCancel.Anchor = AnchorStyles.None;
            kryptonButtonCancel.Location = new Point(249, 243);
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
            kryptonButtonCancel.TabIndex = 57;
            kryptonButtonCancel.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonCancel.Values.Text = "Cancel";
            kryptonButtonCancel.Click += kryptonButtonCancel_Click;
            // 
            // kryptonButtonSave
            // 
            kryptonButtonSave.Anchor = AnchorStyles.None;
            kryptonButtonSave.Location = new Point(73, 243);
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
            kryptonButtonSave.TabIndex = 56;
            kryptonButtonSave.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonSave.Values.Text = "Save";
            kryptonButtonSave.Click += kryptonButtonSave_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 383);
            Controls.Add(kryptonButtonBrowse);
            Controls.Add(kryptonButtonCancel);
            Controls.Add(kryptonButtonSave);
            Controls.Add(kryptonTextBoxFilePath);
            Controls.Add(kryptonTextBoxTitle);
            Controls.Add(kryptonTextBoxAuthor);
            Controls.Add(kryptonComboBoxUploader);
            Controls.Add(kryptonDateTimePicker1);
            Controls.Add(kryptonComboBoxCategory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbUploader);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpPublishedDate);
            Controls.Add(txtFilePath);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(btnBrowseFile);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCategory);
            LocalCustomPalette = kryptonCustomPaletteBase1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddBookForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBookForm";
            Load += AddBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxUploader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategory;
        private Button btnCancel;
        private Button btnSave;
        private Button btnBrowseFile;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtFilePath;
        private DateTimePicker dtpPublishedDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbUploader;
        private Label label4;
        private Label label5;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBoxCategory;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBoxUploader;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxFilePath;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxTitle;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxAuthor;
        private Krypton.Toolkit.KryptonButton kryptonButtonBrowse;
        private Krypton.Toolkit.KryptonButton kryptonButtonCancel;
        private Krypton.Toolkit.KryptonButton kryptonButtonSave;
    }
}