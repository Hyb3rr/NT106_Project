namespace BookReaderApp.ViewForm
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            menuStripAdmin = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuLogoutToolStripMenuItem = new ToolStripMenuItem();
            menuExitToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            menuManageUsersToolStripMenuItem = new ToolStripMenuItem();
            menuManageBooksToolStripMenuItem = new ToolStripMenuItem();
            menuManageCategoriesToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            menuStatisticsToolStripMenuItem = new ToolStripMenuItem();
            cấuHìnhToolStripMenuItem = new ToolStripMenuItem();
            menuSettingsToolStripMenuItem = new ToolStripMenuItem();
            tabControlAdmin = new TabControl();
            tabPage1 = new TabPage();
            kryptonTextBoxSearchUser = new Krypton.Toolkit.KryptonTextBox();
            kryptonButtonDeleteUser = new Krypton.Toolkit.KryptonButton();
            kryptonButtonEditUser = new Krypton.Toolkit.KryptonButton();
            txtSearchUser = new TextBox();
            btnDeleteUser = new Button();
            kryptonButtonAddUser = new Krypton.Toolkit.KryptonButton();
            btnEditUser = new Button();
            btnAddUser = new Button();
            dgvUsers = new DataGridView();
            tabPage2 = new TabPage();
            kryptonTextBoxSearch = new Krypton.Toolkit.KryptonTextBox();
            kryptonButtonUploadToDrive = new Krypton.Toolkit.KryptonButton();
            kryptonButtonDeleteBook = new Krypton.Toolkit.KryptonButton();
            kryptonButtonEditBook = new Krypton.Toolkit.KryptonButton();
            kryptonButtonAddBook = new Krypton.Toolkit.KryptonButton();
            txtSearch = new TextBox();
            btnUploadToDrive = new Button();
            btnDeleteBook = new Button();
            btnEditBook = new Button();
            btnAddBook = new Button();
            dgvBooks = new DataGridView();
            tabPage3 = new TabPage();
            kryptonButtonDeleteCategory = new Krypton.Toolkit.KryptonButton();
            kryptonButtonEditCategory = new Krypton.Toolkit.KryptonButton();
            kryptonTextBoxSearchCate = new Krypton.Toolkit.KryptonTextBox();
            kryptonButtonAddCategory = new Krypton.Toolkit.KryptonButton();
            SearchCate = new TextBox();
            dgvCategories = new DataGridView();
            btnDeleteCategory = new Button();
            btnEditCategory = new Button();
            btnAddCategory = new Button();
            ChooseTag = new ComboBox();
            SearchAll = new TextBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSplitButton2 = new ToolStripSplitButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            kryptonComboBoxChooseTag = new Krypton.Toolkit.KryptonComboBox();
            kryptonTextBoxSearchAll = new Krypton.Toolkit.KryptonTextBox();
            menuStripAdmin.SuspendLayout();
            tabControlAdmin.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            kryptonToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxChooseTag).BeginInit();
            SuspendLayout();
            // 
            // menuStripAdmin
            // 
            menuStripAdmin.Font = new Font("Segoe UI", 9F);
            menuStripAdmin.ImageScalingSize = new Size(20, 20);
            menuStripAdmin.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêToolStripMenuItem, cấuHìnhToolStripMenuItem });
            menuStripAdmin.Location = new Point(0, 0);
            menuStripAdmin.Name = "menuStripAdmin";
            menuStripAdmin.Padding = new Padding(6, 3, 0, 3);
            menuStripAdmin.Size = new Size(886, 30);
            menuStripAdmin.TabIndex = 0;
            menuStripAdmin.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuLogoutToolStripMenuItem, menuExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuLogoutToolStripMenuItem
            // 
            menuLogoutToolStripMenuItem.Name = "menuLogoutToolStripMenuItem";
            menuLogoutToolStripMenuItem.Size = new Size(176, 26);
            menuLogoutToolStripMenuItem.Text = "menuLogout";
            menuLogoutToolStripMenuItem.Click += menuLogoutToolStripMenuItem_Click;
            // 
            // menuExitToolStripMenuItem
            // 
            menuExitToolStripMenuItem.Name = "menuExitToolStripMenuItem";
            menuExitToolStripMenuItem.Size = new Size(176, 26);
            menuExitToolStripMenuItem.Text = "menuExit";
            menuExitToolStripMenuItem.Click += menuExitToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuManageUsersToolStripMenuItem, menuManageBooksToolStripMenuItem, menuManageCategoriesToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(75, 24);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // menuManageUsersToolStripMenuItem
            // 
            menuManageUsersToolStripMenuItem.Name = "menuManageUsersToolStripMenuItem";
            menuManageUsersToolStripMenuItem.Size = new Size(254, 26);
            menuManageUsersToolStripMenuItem.Text = "menuManageUsers";
            // 
            // menuManageBooksToolStripMenuItem
            // 
            menuManageBooksToolStripMenuItem.Name = "menuManageBooksToolStripMenuItem";
            menuManageBooksToolStripMenuItem.Size = new Size(254, 26);
            menuManageBooksToolStripMenuItem.Text = "menuManageBooks";
            // 
            // menuManageCategoriesToolStripMenuItem
            // 
            menuManageCategoriesToolStripMenuItem.Name = "menuManageCategoriesToolStripMenuItem";
            menuManageCategoriesToolStripMenuItem.Size = new Size(254, 26);
            menuManageCategoriesToolStripMenuItem.Text = "menuManageCategories";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuStatisticsToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(84, 24);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // menuStatisticsToolStripMenuItem
            // 
            menuStatisticsToolStripMenuItem.Name = "menuStatisticsToolStripMenuItem";
            menuStatisticsToolStripMenuItem.Size = new Size(187, 26);
            menuStatisticsToolStripMenuItem.Text = "menuStatistics";
            // 
            // cấuHìnhToolStripMenuItem
            // 
            cấuHìnhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSettingsToolStripMenuItem });
            cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            cấuHìnhToolStripMenuItem.Size = new Size(80, 24);
            cấuHìnhToolStripMenuItem.Text = "Cấu hình";
            // 
            // menuSettingsToolStripMenuItem
            // 
            menuSettingsToolStripMenuItem.Name = "menuSettingsToolStripMenuItem";
            menuSettingsToolStripMenuItem.Size = new Size(182, 26);
            menuSettingsToolStripMenuItem.Text = "menuSettings";
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlAdmin.Controls.Add(tabPage1);
            tabControlAdmin.Controls.Add(tabPage2);
            tabControlAdmin.Controls.Add(tabPage3);
            tabControlAdmin.Location = new Point(14, 75);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(840, 380);
            tabControlAdmin.TabIndex = 1;
            tabControlAdmin.SelectedIndexChanged += tabControlAdmin_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(kryptonTextBoxSearchUser);
            tabPage1.Controls.Add(kryptonButtonDeleteUser);
            tabPage1.Controls.Add(kryptonButtonEditUser);
            tabPage1.Controls.Add(txtSearchUser);
            tabPage1.Controls.Add(btnDeleteUser);
            tabPage1.Controls.Add(kryptonButtonAddUser);
            tabPage1.Controls.Add(btnEditUser);
            tabPage1.Controls.Add(btnAddUser);
            tabPage1.Controls.Add(dgvUsers);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(832, 347);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabUsers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // kryptonTextBoxSearchUser
            // 
            kryptonTextBoxSearchUser.Anchor = AnchorStyles.Top;
            kryptonTextBoxSearchUser.Location = new Point(606, 15);
            kryptonTextBoxSearchUser.Margin = new Padding(3, 4, 3, 4);
            kryptonTextBoxSearchUser.Name = "kryptonTextBoxSearchUser";
            kryptonTextBoxSearchUser.Size = new Size(171, 35);
            kryptonTextBoxSearchUser.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxSearchUser.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxSearchUser.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxSearchUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxSearchUser.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxSearchUser.StateCommon.Border.Width = 1;
            kryptonTextBoxSearchUser.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxSearchUser.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxSearchUser.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxSearchUser.TabIndex = 17;
            kryptonTextBoxSearchUser.Text = "search";
            kryptonTextBoxSearchUser.TextChanged += kryptonTextBoxSearchUser_TextChanged;
            // 
            // kryptonButtonDeleteUser
            // 
            kryptonButtonDeleteUser.Anchor = AnchorStyles.Bottom;
            kryptonButtonDeleteUser.Location = new Point(505, 270);
            kryptonButtonDeleteUser.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonDeleteUser.Name = "kryptonButtonDeleteUser";
            kryptonButtonDeleteUser.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteUser.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonDeleteUser.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteUser.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonDeleteUser.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteUser.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonDeleteUser.OverrideDefault.Border.Width = 1;
            kryptonButtonDeleteUser.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonDeleteUser.Size = new Size(177, 57);
            kryptonButtonDeleteUser.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteUser.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonDeleteUser.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteUser.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonDeleteUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteUser.StateCommon.Border.Rounding = 20F;
            kryptonButtonDeleteUser.StateCommon.Border.Width = 1;
            kryptonButtonDeleteUser.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonDeleteUser.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonDeleteUser.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonDeleteUser.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonDeleteUser.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonDeleteUser.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonDeleteUser.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonDeleteUser.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonDeleteUser.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonDeleteUser.StatePressed.Border.Rounding = 20F;
            kryptonButtonDeleteUser.StatePressed.Border.Width = 1;
            kryptonButtonDeleteUser.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteUser.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonDeleteUser.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteUser.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteUser.StateTracking.Border.Rounding = 20F;
            kryptonButtonDeleteUser.StateTracking.Border.Width = 1;
            kryptonButtonDeleteUser.TabIndex = 16;
            kryptonButtonDeleteUser.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonDeleteUser.Values.Text = "Delete User";
            kryptonButtonDeleteUser.Click += kryptonButtonDeleteUser_Click;
            // 
            // kryptonButtonEditUser
            // 
            kryptonButtonEditUser.Anchor = AnchorStyles.Bottom;
            kryptonButtonEditUser.Location = new Point(322, 270);
            kryptonButtonEditUser.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonEditUser.Name = "kryptonButtonEditUser";
            kryptonButtonEditUser.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditUser.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditUser.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonEditUser.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditUser.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditUser.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonEditUser.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonEditUser.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonEditUser.OverrideDefault.Border.Width = 1;
            kryptonButtonEditUser.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonEditUser.Size = new Size(177, 57);
            kryptonButtonEditUser.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditUser.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditUser.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonEditUser.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditUser.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditUser.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonEditUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonEditUser.StateCommon.Border.Rounding = 20F;
            kryptonButtonEditUser.StateCommon.Border.Width = 1;
            kryptonButtonEditUser.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonEditUser.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonEditUser.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonEditUser.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonEditUser.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonEditUser.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonEditUser.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonEditUser.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonEditUser.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonEditUser.StatePressed.Border.Rounding = 20F;
            kryptonButtonEditUser.StatePressed.Border.Width = 1;
            kryptonButtonEditUser.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditUser.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditUser.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonEditUser.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditUser.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditUser.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonEditUser.StateTracking.Border.Rounding = 20F;
            kryptonButtonEditUser.StateTracking.Border.Width = 1;
            kryptonButtonEditUser.TabIndex = 15;
            kryptonButtonEditUser.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonEditUser.Values.Text = "Edit User";
            kryptonButtonEditUser.Click += kryptonButtonEditUser_Click;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(422, 19);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(125, 27);
            txtSearchUser.TabIndex = 4;
            txtSearchUser.Visible = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(499, 273);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(185, 35);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "btnDeleteUser";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Visible = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // kryptonButtonAddUser
            // 
            kryptonButtonAddUser.Anchor = AnchorStyles.Bottom;
            kryptonButtonAddUser.Location = new Point(129, 270);
            kryptonButtonAddUser.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonAddUser.Name = "kryptonButtonAddUser";
            kryptonButtonAddUser.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddUser.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddUser.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonAddUser.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddUser.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddUser.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonAddUser.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonAddUser.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonAddUser.OverrideDefault.Border.Width = 1;
            kryptonButtonAddUser.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonAddUser.Size = new Size(177, 57);
            kryptonButtonAddUser.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddUser.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddUser.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonAddUser.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddUser.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddUser.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonAddUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonAddUser.StateCommon.Border.Rounding = 20F;
            kryptonButtonAddUser.StateCommon.Border.Width = 1;
            kryptonButtonAddUser.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonAddUser.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonAddUser.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonAddUser.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonAddUser.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonAddUser.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonAddUser.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonAddUser.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonAddUser.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonAddUser.StatePressed.Border.Rounding = 20F;
            kryptonButtonAddUser.StatePressed.Border.Width = 1;
            kryptonButtonAddUser.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddUser.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddUser.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonAddUser.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddUser.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddUser.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonAddUser.StateTracking.Border.Rounding = 20F;
            kryptonButtonAddUser.StateTracking.Border.Width = 1;
            kryptonButtonAddUser.TabIndex = 14;
            kryptonButtonAddUser.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonAddUser.Values.Text = "Add User";
            kryptonButtonAddUser.Click += kryptonButtonAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(307, 273);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(185, 35);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "btnEditUser";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Visible = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(115, 273);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(185, 35);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "btnAddUser";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Visible = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(38, 61);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(743, 127);
            dgvUsers.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(kryptonTextBoxSearch);
            tabPage2.Controls.Add(kryptonButtonUploadToDrive);
            tabPage2.Controls.Add(kryptonButtonDeleteBook);
            tabPage2.Controls.Add(kryptonButtonEditBook);
            tabPage2.Controls.Add(kryptonButtonAddBook);
            tabPage2.Controls.Add(txtSearch);
            tabPage2.Controls.Add(btnUploadToDrive);
            tabPage2.Controls.Add(btnDeleteBook);
            tabPage2.Controls.Add(btnEditBook);
            tabPage2.Controls.Add(btnAddBook);
            tabPage2.Controls.Add(dgvBooks);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(832, 347);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabBooks";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // kryptonTextBoxSearch
            // 
            kryptonTextBoxSearch.Anchor = AnchorStyles.Top;
            kryptonTextBoxSearch.Location = new Point(609, 8);
            kryptonTextBoxSearch.Margin = new Padding(3, 4, 3, 4);
            kryptonTextBoxSearch.Name = "kryptonTextBoxSearch";
            kryptonTextBoxSearch.Size = new Size(171, 35);
            kryptonTextBoxSearch.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxSearch.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxSearch.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxSearch.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxSearch.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxSearch.StateCommon.Border.Width = 1;
            kryptonTextBoxSearch.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxSearch.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxSearch.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxSearch.TabIndex = 19;
            kryptonTextBoxSearch.Text = "search";
            // 
            // kryptonButtonUploadToDrive
            // 
            kryptonButtonUploadToDrive.Anchor = AnchorStyles.Bottom;
            kryptonButtonUploadToDrive.Location = new Point(595, 244);
            kryptonButtonUploadToDrive.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonUploadToDrive.Name = "kryptonButtonUploadToDrive";
            kryptonButtonUploadToDrive.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonUploadToDrive.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonUploadToDrive.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonUploadToDrive.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonUploadToDrive.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonUploadToDrive.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonUploadToDrive.OverrideDefault.Border.Width = 1;
            kryptonButtonUploadToDrive.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonUploadToDrive.Size = new Size(186, 57);
            kryptonButtonUploadToDrive.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonUploadToDrive.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonUploadToDrive.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonUploadToDrive.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonUploadToDrive.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonUploadToDrive.StateCommon.Border.Rounding = 20F;
            kryptonButtonUploadToDrive.StateCommon.Border.Width = 1;
            kryptonButtonUploadToDrive.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonUploadToDrive.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonUploadToDrive.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonUploadToDrive.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonUploadToDrive.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonUploadToDrive.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonUploadToDrive.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonUploadToDrive.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonUploadToDrive.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonUploadToDrive.StatePressed.Border.Rounding = 20F;
            kryptonButtonUploadToDrive.StatePressed.Border.Width = 1;
            kryptonButtonUploadToDrive.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonUploadToDrive.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonUploadToDrive.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonUploadToDrive.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonUploadToDrive.StateTracking.Border.Rounding = 20F;
            kryptonButtonUploadToDrive.StateTracking.Border.Width = 1;
            kryptonButtonUploadToDrive.TabIndex = 18;
            kryptonButtonUploadToDrive.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonUploadToDrive.Values.Text = "Upload to drive";
            kryptonButtonUploadToDrive.Click += kryptonButtonUploadToDrive_Click;
            // 
            // kryptonButtonDeleteBook
            // 
            kryptonButtonDeleteBook.Anchor = AnchorStyles.Bottom;
            kryptonButtonDeleteBook.Location = new Point(414, 244);
            kryptonButtonDeleteBook.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonDeleteBook.Name = "kryptonButtonDeleteBook";
            kryptonButtonDeleteBook.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteBook.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonDeleteBook.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteBook.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonDeleteBook.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteBook.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonDeleteBook.OverrideDefault.Border.Width = 1;
            kryptonButtonDeleteBook.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonDeleteBook.Size = new Size(177, 57);
            kryptonButtonDeleteBook.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteBook.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonDeleteBook.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteBook.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonDeleteBook.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteBook.StateCommon.Border.Rounding = 20F;
            kryptonButtonDeleteBook.StateCommon.Border.Width = 1;
            kryptonButtonDeleteBook.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonDeleteBook.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonDeleteBook.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonDeleteBook.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonDeleteBook.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonDeleteBook.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonDeleteBook.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonDeleteBook.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonDeleteBook.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonDeleteBook.StatePressed.Border.Rounding = 20F;
            kryptonButtonDeleteBook.StatePressed.Border.Width = 1;
            kryptonButtonDeleteBook.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteBook.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonDeleteBook.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteBook.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteBook.StateTracking.Border.Rounding = 20F;
            kryptonButtonDeleteBook.StateTracking.Border.Width = 1;
            kryptonButtonDeleteBook.TabIndex = 17;
            kryptonButtonDeleteBook.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonDeleteBook.Values.Text = "Delete Book";
            kryptonButtonDeleteBook.Click += kryptonButtonDeleteBook_Click;
            // 
            // kryptonButtonEditBook
            // 
            kryptonButtonEditBook.Anchor = AnchorStyles.Bottom;
            kryptonButtonEditBook.Location = new Point(230, 244);
            kryptonButtonEditBook.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonEditBook.Name = "kryptonButtonEditBook";
            kryptonButtonEditBook.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditBook.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditBook.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonEditBook.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditBook.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditBook.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonEditBook.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonEditBook.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonEditBook.OverrideDefault.Border.Width = 1;
            kryptonButtonEditBook.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonEditBook.Size = new Size(177, 57);
            kryptonButtonEditBook.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditBook.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditBook.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonEditBook.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditBook.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditBook.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonEditBook.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonEditBook.StateCommon.Border.Rounding = 20F;
            kryptonButtonEditBook.StateCommon.Border.Width = 1;
            kryptonButtonEditBook.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonEditBook.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonEditBook.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonEditBook.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonEditBook.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonEditBook.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonEditBook.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonEditBook.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonEditBook.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonEditBook.StatePressed.Border.Rounding = 20F;
            kryptonButtonEditBook.StatePressed.Border.Width = 1;
            kryptonButtonEditBook.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditBook.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditBook.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonEditBook.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditBook.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditBook.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonEditBook.StateTracking.Border.Rounding = 20F;
            kryptonButtonEditBook.StateTracking.Border.Width = 1;
            kryptonButtonEditBook.TabIndex = 16;
            kryptonButtonEditBook.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonEditBook.Values.Text = "Edit Book";
            kryptonButtonEditBook.Click += kryptonButtonEditBook_Click;
            // 
            // kryptonButtonAddBook
            // 
            kryptonButtonAddBook.Anchor = AnchorStyles.Bottom;
            kryptonButtonAddBook.Location = new Point(46, 244);
            kryptonButtonAddBook.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonAddBook.Name = "kryptonButtonAddBook";
            kryptonButtonAddBook.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddBook.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddBook.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonAddBook.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddBook.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddBook.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonAddBook.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonAddBook.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonAddBook.OverrideDefault.Border.Width = 1;
            kryptonButtonAddBook.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonAddBook.Size = new Size(177, 57);
            kryptonButtonAddBook.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddBook.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddBook.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonAddBook.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddBook.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddBook.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonAddBook.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonAddBook.StateCommon.Border.Rounding = 20F;
            kryptonButtonAddBook.StateCommon.Border.Width = 1;
            kryptonButtonAddBook.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonAddBook.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonAddBook.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonAddBook.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonAddBook.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonAddBook.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonAddBook.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonAddBook.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonAddBook.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonAddBook.StatePressed.Border.Rounding = 20F;
            kryptonButtonAddBook.StatePressed.Border.Width = 1;
            kryptonButtonAddBook.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddBook.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddBook.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonAddBook.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddBook.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddBook.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonAddBook.StateTracking.Border.Rounding = 20F;
            kryptonButtonAddBook.StateTracking.Border.Width = 1;
            kryptonButtonAddBook.TabIndex = 15;
            kryptonButtonAddBook.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonAddBook.Values.Text = "Add Book";
            kryptonButtonAddBook.Click += kryptonButtonAddBook_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(314, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 5;
            txtSearch.Visible = false;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnUploadToDrive
            // 
            btnUploadToDrive.Location = new Point(598, 277);
            btnUploadToDrive.Name = "btnUploadToDrive";
            btnUploadToDrive.Size = new Size(187, 35);
            btnUploadToDrive.TabIndex = 4;
            btnUploadToDrive.Text = "btnUploadToDrive";
            btnUploadToDrive.UseVisualStyleBackColor = true;
            btnUploadToDrive.Visible = false;
            btnUploadToDrive.Click += btnUploadToDrive_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(409, 277);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(187, 35);
            btnDeleteBook.TabIndex = 3;
            btnDeleteBook.Text = "btnDeleteBook";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Visible = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Location = new Point(222, 277);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(187, 35);
            btnEditBook.TabIndex = 2;
            btnEditBook.Text = "btnEditBook";
            btnEditBook.UseVisualStyleBackColor = true;
            btnEditBook.Visible = false;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(34, 277);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(187, 35);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "btnAddBook";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Visible = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(24, 57);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(752, 176);
            dgvBooks.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(kryptonButtonDeleteCategory);
            tabPage3.Controls.Add(kryptonButtonEditCategory);
            tabPage3.Controls.Add(kryptonTextBoxSearchCate);
            tabPage3.Controls.Add(kryptonButtonAddCategory);
            tabPage3.Controls.Add(SearchCate);
            tabPage3.Controls.Add(dgvCategories);
            tabPage3.Controls.Add(btnDeleteCategory);
            tabPage3.Controls.Add(btnEditCategory);
            tabPage3.Controls.Add(btnAddCategory);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(832, 347);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabCategories";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // kryptonButtonDeleteCategory
            // 
            kryptonButtonDeleteCategory.Anchor = AnchorStyles.Bottom;
            kryptonButtonDeleteCategory.Location = new Point(491, 219);
            kryptonButtonDeleteCategory.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonDeleteCategory.Name = "kryptonButtonDeleteCategory";
            kryptonButtonDeleteCategory.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteCategory.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonDeleteCategory.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteCategory.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonDeleteCategory.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteCategory.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonDeleteCategory.OverrideDefault.Border.Width = 1;
            kryptonButtonDeleteCategory.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonDeleteCategory.Size = new Size(190, 57);
            kryptonButtonDeleteCategory.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteCategory.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonDeleteCategory.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteCategory.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonDeleteCategory.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteCategory.StateCommon.Border.Rounding = 20F;
            kryptonButtonDeleteCategory.StateCommon.Border.Width = 1;
            kryptonButtonDeleteCategory.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonDeleteCategory.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonDeleteCategory.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonDeleteCategory.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonDeleteCategory.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonDeleteCategory.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonDeleteCategory.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonDeleteCategory.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonDeleteCategory.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonDeleteCategory.StatePressed.Border.Rounding = 20F;
            kryptonButtonDeleteCategory.StatePressed.Border.Width = 1;
            kryptonButtonDeleteCategory.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteCategory.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonDeleteCategory.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteCategory.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteCategory.StateTracking.Border.Rounding = 20F;
            kryptonButtonDeleteCategory.StateTracking.Border.Width = 1;
            kryptonButtonDeleteCategory.TabIndex = 19;
            kryptonButtonDeleteCategory.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonDeleteCategory.Values.Text = "Delete category";
            kryptonButtonDeleteCategory.Click += kryptonButtonDeleteCategory_Click;
            // 
            // kryptonButtonEditCategory
            // 
            kryptonButtonEditCategory.Anchor = AnchorStyles.Bottom;
            kryptonButtonEditCategory.Location = new Point(301, 219);
            kryptonButtonEditCategory.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonEditCategory.Name = "kryptonButtonEditCategory";
            kryptonButtonEditCategory.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditCategory.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditCategory.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonEditCategory.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditCategory.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditCategory.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonEditCategory.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonEditCategory.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonEditCategory.OverrideDefault.Border.Width = 1;
            kryptonButtonEditCategory.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonEditCategory.Size = new Size(177, 57);
            kryptonButtonEditCategory.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditCategory.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditCategory.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonEditCategory.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditCategory.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditCategory.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonEditCategory.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonEditCategory.StateCommon.Border.Rounding = 20F;
            kryptonButtonEditCategory.StateCommon.Border.Width = 1;
            kryptonButtonEditCategory.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonEditCategory.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonEditCategory.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonEditCategory.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonEditCategory.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonEditCategory.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonEditCategory.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonEditCategory.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonEditCategory.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonEditCategory.StatePressed.Border.Rounding = 20F;
            kryptonButtonEditCategory.StatePressed.Border.Width = 1;
            kryptonButtonEditCategory.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditCategory.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditCategory.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonEditCategory.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonEditCategory.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonEditCategory.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonEditCategory.StateTracking.Border.Rounding = 20F;
            kryptonButtonEditCategory.StateTracking.Border.Width = 1;
            kryptonButtonEditCategory.TabIndex = 18;
            kryptonButtonEditCategory.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonEditCategory.Values.Text = "Edit category";
            kryptonButtonEditCategory.Click += kryptonButtonEditCategory_Click;
            // 
            // kryptonTextBoxSearchCate
            // 
            kryptonTextBoxSearchCate.Anchor = AnchorStyles.Top;
            kryptonTextBoxSearchCate.Location = new Point(596, 4);
            kryptonTextBoxSearchCate.Margin = new Padding(3, 4, 3, 4);
            kryptonTextBoxSearchCate.Name = "kryptonTextBoxSearchCate";
            kryptonTextBoxSearchCate.Size = new Size(171, 35);
            kryptonTextBoxSearchCate.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxSearchCate.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxSearchCate.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxSearchCate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxSearchCate.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxSearchCate.StateCommon.Border.Width = 1;
            kryptonTextBoxSearchCate.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxSearchCate.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxSearchCate.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxSearchCate.TabIndex = 17;
            kryptonTextBoxSearchCate.Text = "search";
            // 
            // kryptonButtonAddCategory
            // 
            kryptonButtonAddCategory.Anchor = AnchorStyles.Bottom;
            kryptonButtonAddCategory.Location = new Point(111, 219);
            kryptonButtonAddCategory.Margin = new Padding(3, 4, 3, 4);
            kryptonButtonAddCategory.Name = "kryptonButtonAddCategory";
            kryptonButtonAddCategory.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddCategory.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddCategory.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonAddCategory.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddCategory.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddCategory.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonAddCategory.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonAddCategory.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonAddCategory.OverrideDefault.Border.Width = 1;
            kryptonButtonAddCategory.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonAddCategory.Size = new Size(177, 57);
            kryptonButtonAddCategory.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddCategory.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddCategory.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonAddCategory.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddCategory.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddCategory.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonAddCategory.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonAddCategory.StateCommon.Border.Rounding = 20F;
            kryptonButtonAddCategory.StateCommon.Border.Width = 1;
            kryptonButtonAddCategory.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButtonAddCategory.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButtonAddCategory.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonAddCategory.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonAddCategory.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonAddCategory.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonAddCategory.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonAddCategory.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonAddCategory.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonAddCategory.StatePressed.Border.Rounding = 20F;
            kryptonButtonAddCategory.StatePressed.Border.Width = 1;
            kryptonButtonAddCategory.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddCategory.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddCategory.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonAddCategory.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonAddCategory.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonAddCategory.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonAddCategory.StateTracking.Border.Rounding = 20F;
            kryptonButtonAddCategory.StateTracking.Border.Width = 1;
            kryptonButtonAddCategory.TabIndex = 16;
            kryptonButtonAddCategory.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonAddCategory.Values.Text = "Add category";
            kryptonButtonAddCategory.Click += kryptonButton1_Click;
            // 
            // SearchCate
            // 
            SearchCate.Location = new Point(458, 13);
            SearchCate.Name = "SearchCate";
            SearchCate.Size = new Size(125, 27);
            SearchCate.TabIndex = 4;
            SearchCate.Visible = false;
            SearchCate.TextChanged += SearchCate_TextChanged;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(30, 51);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(733, 155);
            dgvCategories.TabIndex = 3;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(488, 280);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(190, 32);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "btnDeleteCategory";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Visible = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(298, 280);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(190, 32);
            btnEditCategory.TabIndex = 1;
            btnEditCategory.Text = "btnEditCategory";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Visible = false;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(109, 280);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(190, 32);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "btnAddCategory";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Visible = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // ChooseTag
            // 
            ChooseTag.FormattingEnabled = true;
            ChooseTag.Location = new Point(141, 33);
            ChooseTag.Name = "ChooseTag";
            ChooseTag.Size = new Size(151, 28);
            ChooseTag.TabIndex = 2;
            ChooseTag.Visible = false;
            ChooseTag.SelectedIndexChanged += ChooseTag_SelectedIndexChanged;
            // 
            // SearchAll
            // 
            SearchAll.Location = new Point(308, 33);
            SearchAll.Name = "SearchAll";
            SearchAll.Size = new Size(125, 27);
            SearchAll.TabIndex = 3;
            SearchAll.Visible = false;
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
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Font = new Font("Segoe UI", 9F);
            kryptonToolStrip1.ImageScalingSize = new Size(20, 20);
            kryptonToolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripSplitButton2, toolStripButton1, toolStripButton2 });
            kryptonToolStrip1.Location = new Point(0, 32);
            kryptonToolStrip1.Margin = new Padding(11, 0, 11, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new Size(928, 33);
            kryptonToolStrip1.TabIndex = 5;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            kryptonToolStrip1.Visible = false;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownButtonWidth = 0;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            toolStripSplitButton1.Image = Properties.Resources.icons8_folder_24;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Margin = new Padding(10, 0, 10, 0);
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(25, 33);
            toolStripSplitButton1.Text = "File";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(115, 26);
            fileToolStripMenuItem1.Text = "File";
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton2.DropDownButtonWidth = 0;
            toolStripSplitButton2.Image = Properties.Resources.icons8_manage_24;
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Margin = new Padding(10, 0, 10, 0);
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(25, 33);
            toolStripSplitButton2.Text = "Management";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.icons8_statistic_24;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Margin = new Padding(10, 0, 10, 0);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 33);
            toolStripButton1.Text = "statistic";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.icons8_configuration_24;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Margin = new Padding(10, 0, 10, 0);
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 33);
            toolStripButton2.Text = "Configuration";
            // 
            // kryptonComboBoxChooseTag
            // 
            kryptonComboBoxChooseTag.Anchor = AnchorStyles.None;
            kryptonComboBoxChooseTag.DropDownWidth = 138;
            kryptonComboBoxChooseTag.Location = new Point(476, 34);
            kryptonComboBoxChooseTag.Margin = new Padding(3, 4, 3, 4);
            kryptonComboBoxChooseTag.Name = "kryptonComboBoxChooseTag";
            kryptonComboBoxChooseTag.Size = new Size(171, 38);
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Back.Color1 = Color.White;
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Border.Rounding = 20F;
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Border.Width = 1;
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxChooseTag.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBoxChooseTag.StateCommon.DropBack.Color1 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxChooseTag.StateCommon.DropBack.Color2 = Color.FromArgb(224, 224, 224);
            kryptonComboBoxChooseTag.StateCommon.DropBack.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonComboBoxChooseTag.StateCommon.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxChooseTag.StateCommon.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxChooseTag.StateTracking.Item.Back.Color1 = Color.Blue;
            kryptonComboBoxChooseTag.StateTracking.Item.Back.Color2 = Color.FromArgb(128, 255, 255);
            kryptonComboBoxChooseTag.StateTracking.Item.Back.ColorAngle = 10F;
            kryptonComboBoxChooseTag.StateTracking.Item.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonComboBoxChooseTag.StateTracking.Item.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonComboBoxChooseTag.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            kryptonComboBoxChooseTag.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            kryptonComboBoxChooseTag.StateTracking.Item.Content.ShortText.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonComboBoxChooseTag.TabIndex = 16;
            kryptonComboBoxChooseTag.Text = "kryptonComboBox1";
            // 
            // kryptonTextBoxSearchAll
            // 
            kryptonTextBoxSearchAll.Anchor = AnchorStyles.None;
            kryptonTextBoxSearchAll.Location = new Point(653, 37);
            kryptonTextBoxSearchAll.Name = "kryptonTextBoxSearchAll";
            kryptonTextBoxSearchAll.Size = new Size(171, 35);
            kryptonTextBoxSearchAll.StateCommon.Back.Color1 = Color.White;
            kryptonTextBoxSearchAll.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxSearchAll.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBoxSearchAll.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxSearchAll.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxSearchAll.StateCommon.Border.Width = 1;
            kryptonTextBoxSearchAll.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBoxSearchAll.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBoxSearchAll.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBoxSearchAll.TabIndex = 15;
            kryptonTextBoxSearchAll.Text = "search";
            kryptonTextBoxSearchAll.TextChanged += kryptonTextBoxSearchAll_TextChanged;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 458);
            Controls.Add(kryptonComboBoxChooseTag);
            Controls.Add(kryptonTextBoxSearchAll);
            Controls.Add(SearchAll);
            Controls.Add(ChooseTag);
            Controls.Add(tabControlAdmin);
            Controls.Add(menuStripAdmin);
            Controls.Add(kryptonToolStrip1);
            LocalCustomPalette = kryptonCustomPaletteBase1;
            MainMenuStrip = menuStripAdmin;
            Name = "AdminForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            menuStripAdmin.ResumeLayout(false);
            menuStripAdmin.PerformLayout();
            tabControlAdmin.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            kryptonToolStrip1.ResumeLayout(false);
            kryptonToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxChooseTag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripAdmin;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuLogoutToolStripMenuItem;
        private ToolStripMenuItem menuExitToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem menuManageUsersToolStripMenuItem;
        private ToolStripMenuItem menuManageBooksToolStripMenuItem;
        private ToolStripMenuItem menuManageCategoriesToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem menuStatisticsToolStripMenuItem;
        private ToolStripMenuItem cấuHìnhToolStripMenuItem;
        private ToolStripMenuItem menuSettingsToolStripMenuItem;
        private TabControl tabControlAdmin;
        private TabPage tabPage1;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private DataGridView dgvUsers;
        private TabPage tabPage2;
        private Button btnUploadToDrive;
        private Button btnDeleteBook;
        private Button btnEditBook;
        private Button btnAddBook;
        private DataGridView dgvBooks;
        private TabPage tabPage3;
        private DataGridView dgvCategories;
        private Button btnDeleteCategory;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private TextBox txtSearch;
        private TextBox txtSearchUser;
        private ComboBox ChooseTag;
        private TextBox SearchAll;
        private TextBox SearchCate;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxSearchUser;
        private Krypton.Toolkit.KryptonButton kryptonButtonDeleteUser;
        private Krypton.Toolkit.KryptonButton kryptonButtonEditUser;
        private Krypton.Toolkit.KryptonButton kryptonButtonAddUser;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBoxChooseTag;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxSearchAll;
        private Krypton.Toolkit.KryptonButton kryptonButtonAddBook;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxSearch;
        private Krypton.Toolkit.KryptonButton kryptonButtonUploadToDrive;
        private Krypton.Toolkit.KryptonButton kryptonButtonDeleteBook;
        private Krypton.Toolkit.KryptonButton kryptonButtonEditBook;
        private Krypton.Toolkit.KryptonButton kryptonButtonAddCategory;
        private Krypton.Toolkit.KryptonButton kryptonButtonDeleteCategory;
        private Krypton.Toolkit.KryptonButton kryptonButtonEditCategory;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxSearchCate;
    }
}