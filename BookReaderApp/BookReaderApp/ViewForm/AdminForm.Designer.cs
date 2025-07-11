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
            kryptonDataGridViewUsers = new Krypton.Toolkit.KryptonDataGridView();
            btnInitializeData = new Krypton.Toolkit.KryptonButton();
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
            kryptonDataGridViewBooks = new Krypton.Toolkit.KryptonDataGridView();
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
            kryptonDataGridViewCategories = new Krypton.Toolkit.KryptonDataGridView();
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
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewCategories).BeginInit();
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
<<<<<<< Updated upstream
            menuStripAdmin.Padding = new Padding(5, 2, 0, 2);
            menuStripAdmin.Size = new Size(904, 24);
=======
            menuStripAdmin.Padding = new Padding(6, 3, 0, 3);
            menuStripAdmin.Size = new Size(1095, 30);
>>>>>>> Stashed changes
            menuStripAdmin.TabIndex = 0;
            menuStripAdmin.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuLogoutToolStripMenuItem, menuExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuLogoutToolStripMenuItem
            // 
            menuLogoutToolStripMenuItem.Name = "menuLogoutToolStripMenuItem";
            menuLogoutToolStripMenuItem.Size = new Size(143, 22);
            menuLogoutToolStripMenuItem.Text = "menuLogout";
            menuLogoutToolStripMenuItem.Click += menuLogoutToolStripMenuItem_Click;
            // 
            // menuExitToolStripMenuItem
            // 
            menuExitToolStripMenuItem.Name = "menuExitToolStripMenuItem";
            menuExitToolStripMenuItem.Size = new Size(143, 22);
            menuExitToolStripMenuItem.Text = "menuExit";
            menuExitToolStripMenuItem.Click += menuExitToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuManageUsersToolStripMenuItem, menuManageBooksToolStripMenuItem, menuManageCategoriesToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(62, 20);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // menuManageUsersToolStripMenuItem
            // 
            menuManageUsersToolStripMenuItem.Name = "menuManageUsersToolStripMenuItem";
            menuManageUsersToolStripMenuItem.Size = new Size(204, 22);
            menuManageUsersToolStripMenuItem.Text = "menuManageUsers";
            // 
            // menuManageBooksToolStripMenuItem
            // 
            menuManageBooksToolStripMenuItem.Name = "menuManageBooksToolStripMenuItem";
            menuManageBooksToolStripMenuItem.Size = new Size(204, 22);
            menuManageBooksToolStripMenuItem.Text = "menuManageBooks";
            // 
            // menuManageCategoriesToolStripMenuItem
            // 
            menuManageCategoriesToolStripMenuItem.Name = "menuManageCategoriesToolStripMenuItem";
            menuManageCategoriesToolStripMenuItem.Size = new Size(204, 22);
            menuManageCategoriesToolStripMenuItem.Text = "menuManageCategories";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuStatisticsToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(68, 20);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // menuStatisticsToolStripMenuItem
            // 
            menuStatisticsToolStripMenuItem.Name = "menuStatisticsToolStripMenuItem";
            menuStatisticsToolStripMenuItem.Size = new Size(151, 22);
            menuStatisticsToolStripMenuItem.Text = "menuStatistics";
            // 
            // cấuHìnhToolStripMenuItem
            // 
            cấuHìnhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSettingsToolStripMenuItem });
            cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            cấuHìnhToolStripMenuItem.Size = new Size(67, 20);
            cấuHìnhToolStripMenuItem.Text = "Cấu hình";
            // 
            // menuSettingsToolStripMenuItem
            // 
            menuSettingsToolStripMenuItem.Name = "menuSettingsToolStripMenuItem";
            menuSettingsToolStripMenuItem.Size = new Size(147, 22);
            menuSettingsToolStripMenuItem.Text = "menuSettings";
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlAdmin.Controls.Add(tabPage1);
            tabControlAdmin.Controls.Add(tabPage2);
            tabControlAdmin.Controls.Add(tabPage3);
            tabControlAdmin.Location = new Point(12, 50);
            tabControlAdmin.Margin = new Padding(3, 2, 3, 2);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
<<<<<<< Updated upstream
            tabControlAdmin.Size = new Size(878, 347);
=======
            tabControlAdmin.Size = new Size(1033, 359);
>>>>>>> Stashed changes
            tabControlAdmin.TabIndex = 1;
            tabControlAdmin.SelectedIndexChanged += tabControlAdmin_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(kryptonDataGridViewUsers);
            tabPage1.Controls.Add(btnInitializeData);
            tabPage1.Controls.Add(kryptonTextBoxSearchUser);
            tabPage1.Controls.Add(kryptonButtonDeleteUser);
            tabPage1.Controls.Add(kryptonButtonEditUser);
            tabPage1.Controls.Add(txtSearchUser);
            tabPage1.Controls.Add(btnDeleteUser);
            tabPage1.Controls.Add(kryptonButtonAddUser);
            tabPage1.Controls.Add(btnEditUser);
            tabPage1.Controls.Add(btnAddUser);
            tabPage1.Controls.Add(dgvUsers);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
<<<<<<< Updated upstream
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(870, 319);
=======
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1025, 326);
>>>>>>> Stashed changes
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabUsers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // kryptonDataGridViewUsers
            // 
            kryptonDataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kryptonDataGridViewUsers.BorderStyle = BorderStyle.None;
            kryptonDataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridViewUsers.Location = new Point(46, 39);
            kryptonDataGridViewUsers.Margin = new Padding(3, 4, 3, 4);
            kryptonDataGridViewUsers.Name = "kryptonDataGridViewUsers";
            kryptonDataGridViewUsers.RowHeadersWidth = 51;
            kryptonDataGridViewUsers.Size = new Size(938, 160);
            kryptonDataGridViewUsers.StateCommon.Background.Color1 = Color.White;
            kryptonDataGridViewUsers.StateCommon.Background.Color2 = Color.White;
            kryptonDataGridViewUsers.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridViewUsers.StateCommon.DataCell.Border.Rounding = 20F;
            kryptonDataGridViewUsers.StateCommon.DataCell.Border.Width = 1;
            kryptonDataGridViewUsers.TabIndex = 20;
            // 
            // btnInitializeData
            // 
            btnInitializeData.Location = new Point(306, 8);
            btnInitializeData.Margin = new Padding(3, 2, 3, 2);
            btnInitializeData.Name = "btnInitializeData";
            btnInitializeData.Size = new Size(98, 23);
            btnInitializeData.TabIndex = 19;
            btnInitializeData.Values.DropDownArrowColor = Color.Empty;
            btnInitializeData.Values.Text = "Seed dữ liệu";
            btnInitializeData.Click += btnInitializeData_Click;
            // 
            // kryptonTextBoxSearchUser
            // 
            kryptonTextBoxSearchUser.Anchor = AnchorStyles.Top;
<<<<<<< Updated upstream
            kryptonTextBoxSearchUser.Location = new Point(613, 5);
=======
            kryptonTextBoxSearchUser.Location = new Point(715, 7);
            kryptonTextBoxSearchUser.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
            kryptonTextBoxSearchUser.Name = "kryptonTextBoxSearchUser";
            kryptonTextBoxSearchUser.Size = new Size(150, 30);
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
            kryptonTextBoxSearchUser.Visible = false;
            kryptonTextBoxSearchUser.TextChanged += kryptonTextBoxSearchUser_TextChanged;
            // 
            // kryptonButtonDeleteUser
            // 
            kryptonButtonDeleteUser.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
            kryptonButtonDeleteUser.Location = new Point(339, 233);
=======
            kryptonButtonDeleteUser.Location = new Point(402, 207);
            kryptonButtonDeleteUser.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
            kryptonButtonDeleteUser.Name = "kryptonButtonDeleteUser";
            kryptonButtonDeleteUser.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteUser.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteUser.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonDeleteUser.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonDeleteUser.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteUser.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonDeleteUser.OverrideDefault.Border.Width = 1;
            kryptonButtonDeleteUser.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonDeleteUser.Size = new Size(155, 43);
            kryptonButtonDeleteUser.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteUser.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteUser.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonDeleteUser.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteUser.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonDeleteUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteUser.StateCommon.Border.Rounding = 20F;
            kryptonButtonDeleteUser.StateCommon.Border.Width = 1;
            kryptonButtonDeleteUser.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonDeleteUser.StatePressed.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDeleteUser.StatePressed.Back.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDeleteUser.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonDeleteUser.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonDeleteUser.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonDeleteUser.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonDeleteUser.StatePressed.Border.Rounding = 20F;
            kryptonButtonDeleteUser.StatePressed.Border.Width = 1;
            kryptonButtonDeleteUser.StateTracking.Back.Color1 = SystemColors.ButtonFace;
            kryptonButtonDeleteUser.StateTracking.Back.Color2 = SystemColors.ButtonFace;
            kryptonButtonDeleteUser.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonDeleteUser.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteUser.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteUser.StateTracking.Border.Rounding = 20F;
            kryptonButtonDeleteUser.StateTracking.Border.Width = 1;
            kryptonButtonDeleteUser.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteUser.TabIndex = 16;
            kryptonButtonDeleteUser.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonDeleteUser.Values.Text = "Delete User";
            kryptonButtonDeleteUser.Click += kryptonButtonDeleteUser_Click;
            // 
            // kryptonButtonEditUser
            // 
            kryptonButtonEditUser.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
            kryptonButtonEditUser.Location = new Point(500, 233);
=======
            kryptonButtonEditUser.Location = new Point(586, 207);
            kryptonButtonEditUser.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
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
            kryptonButtonEditUser.Size = new Size(155, 43);
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
            txtSearchUser.Location = new Point(464, 8);
            txtSearchUser.Margin = new Padding(3, 2, 3, 2);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(110, 23);
            txtSearchUser.TabIndex = 4;
            txtSearchUser.Visible = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(422, 249);
            btnDeleteUser.Margin = new Padding(3, 2, 3, 2);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(162, 26);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "btnDeleteUser";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Visible = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // kryptonButtonAddUser
            // 
            kryptonButtonAddUser.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
            kryptonButtonAddUser.Location = new Point(179, 233);
=======
            kryptonButtonAddUser.Location = new Point(219, 207);
            kryptonButtonAddUser.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
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
            kryptonButtonAddUser.Size = new Size(155, 43);
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
            btnEditUser.Location = new Point(254, 249);
            btnEditUser.Margin = new Padding(3, 2, 3, 2);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(162, 26);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "btnEditUser";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Visible = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(40, 249);
            btnAddUser.Margin = new Padding(3, 2, 3, 2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(162, 26);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "btnAddUser";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Visible = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(40, 32);
            dgvUsers.Margin = new Padding(3, 2, 3, 2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
<<<<<<< Updated upstream
            dgvUsers.Size = new Size(795, 196);
=======
            dgvUsers.Size = new Size(938, 157);
>>>>>>> Stashed changes
            dgvUsers.TabIndex = 0;
            dgvUsers.Visible = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(kryptonDataGridViewBooks);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
<<<<<<< Updated upstream
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(870, 319);
=======
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1025, 326);
>>>>>>> Stashed changes
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabBooks";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // kryptonDataGridViewBooks
            // 
            kryptonDataGridViewBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kryptonDataGridViewBooks.BorderStyle = BorderStyle.None;
            kryptonDataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridViewBooks.Location = new Point(34, 47);
            kryptonDataGridViewBooks.Margin = new Padding(3, 4, 3, 4);
            kryptonDataGridViewBooks.Name = "kryptonDataGridViewBooks";
            kryptonDataGridViewBooks.RowHeadersWidth = 51;
            kryptonDataGridViewBooks.Size = new Size(938, 160);
            kryptonDataGridViewBooks.StateCommon.Background.Color1 = Color.White;
            kryptonDataGridViewBooks.StateCommon.Background.Color2 = Color.White;
            kryptonDataGridViewBooks.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridViewBooks.StateCommon.DataCell.Border.Rounding = 20F;
            kryptonDataGridViewBooks.StateCommon.DataCell.Border.Width = 1;
            kryptonDataGridViewBooks.TabIndex = 21;
            // 
            // kryptonTextBoxSearch
            // 
            kryptonTextBoxSearch.Anchor = AnchorStyles.Top;
<<<<<<< Updated upstream
            kryptonTextBoxSearch.Location = new Point(593, 6);
=======
            kryptonTextBoxSearch.Location = new Point(686, 8);
            kryptonTextBoxSearch.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
            kryptonTextBoxSearch.Name = "kryptonTextBoxSearch";
            kryptonTextBoxSearch.Size = new Size(150, 30);
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
            kryptonTextBoxSearch.Visible = false;
            // 
            // kryptonButtonUploadToDrive
            // 
            kryptonButtonUploadToDrive.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
            kryptonButtonUploadToDrive.Location = new Point(546, 185);
=======
            kryptonButtonUploadToDrive.Location = new Point(631, 213);
            kryptonButtonUploadToDrive.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
            kryptonButtonUploadToDrive.Name = "kryptonButtonUploadToDrive";
            kryptonButtonUploadToDrive.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonButtonUploadToDrive.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonButtonUploadToDrive.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonUploadToDrive.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonUploadToDrive.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonUploadToDrive.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonUploadToDrive.OverrideDefault.Border.Width = 1;
            kryptonButtonUploadToDrive.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonUploadToDrive.Size = new Size(163, 43);
            kryptonButtonUploadToDrive.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonButtonUploadToDrive.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonButtonUploadToDrive.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonUploadToDrive.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonUploadToDrive.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonUploadToDrive.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonUploadToDrive.StateCommon.Border.Rounding = 20F;
            kryptonButtonUploadToDrive.StateCommon.Border.Width = 1;
            kryptonButtonUploadToDrive.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonUploadToDrive.StatePressed.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonUploadToDrive.StatePressed.Back.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonUploadToDrive.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonUploadToDrive.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonUploadToDrive.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonUploadToDrive.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonUploadToDrive.StatePressed.Border.Rounding = 20F;
            kryptonButtonUploadToDrive.StatePressed.Border.Width = 1;
            kryptonButtonUploadToDrive.StateTracking.Back.Color1 = SystemColors.ButtonFace;
            kryptonButtonUploadToDrive.StateTracking.Back.Color2 = SystemColors.ButtonFace;
            kryptonButtonUploadToDrive.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonUploadToDrive.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonUploadToDrive.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonUploadToDrive.StateTracking.Border.Rounding = 20F;
            kryptonButtonUploadToDrive.StateTracking.Border.Width = 1;
            kryptonButtonUploadToDrive.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonUploadToDrive.TabIndex = 18;
            kryptonButtonUploadToDrive.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonUploadToDrive.Values.Text = "Upload to drive";
            kryptonButtonUploadToDrive.Click += kryptonButtonUploadToDrive_Click;
            // 
            // kryptonButtonDeleteBook
            // 
            kryptonButtonDeleteBook.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
            kryptonButtonDeleteBook.Location = new Point(224, 185);
=======
            kryptonButtonDeleteBook.Location = new Point(265, 213);
            kryptonButtonDeleteBook.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
            kryptonButtonDeleteBook.Name = "kryptonButtonDeleteBook";
            kryptonButtonDeleteBook.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteBook.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteBook.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonDeleteBook.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonDeleteBook.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteBook.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonDeleteBook.OverrideDefault.Border.Width = 1;
            kryptonButtonDeleteBook.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonDeleteBook.Size = new Size(155, 43);
            kryptonButtonDeleteBook.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteBook.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteBook.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonDeleteBook.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteBook.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonDeleteBook.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteBook.StateCommon.Border.Rounding = 20F;
            kryptonButtonDeleteBook.StateCommon.Border.Width = 1;
            kryptonButtonDeleteBook.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonDeleteBook.StatePressed.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDeleteBook.StatePressed.Back.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDeleteBook.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonDeleteBook.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonDeleteBook.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonDeleteBook.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonDeleteBook.StatePressed.Border.Rounding = 20F;
            kryptonButtonDeleteBook.StatePressed.Border.Width = 1;
            kryptonButtonDeleteBook.StateTracking.Back.Color1 = SystemColors.ButtonFace;
            kryptonButtonDeleteBook.StateTracking.Back.Color2 = SystemColors.ButtonFace;
            kryptonButtonDeleteBook.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonDeleteBook.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteBook.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteBook.StateTracking.Border.Rounding = 20F;
            kryptonButtonDeleteBook.StateTracking.Border.Width = 1;
            kryptonButtonDeleteBook.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteBook.TabIndex = 17;
            kryptonButtonDeleteBook.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonDeleteBook.Values.Text = "Delete Book";
            kryptonButtonDeleteBook.Click += kryptonButtonDeleteBook_Click;
            // 
            // kryptonButtonEditBook
            // 
            kryptonButtonEditBook.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
            kryptonButtonEditBook.Location = new Point(386, 185);
=======
            kryptonButtonEditBook.Location = new Point(448, 213);
            kryptonButtonEditBook.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
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
            kryptonButtonEditBook.Size = new Size(155, 43);
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
<<<<<<< Updated upstream
            kryptonButtonAddBook.Location = new Point(64, 185);
=======
            kryptonButtonAddBook.Location = new Point(82, 215);
            kryptonButtonAddBook.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
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
            kryptonButtonAddBook.Size = new Size(155, 43);
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
            txtSearch.Location = new Point(452, 11);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(110, 23);
            txtSearch.TabIndex = 5;
            txtSearch.Visible = false;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnUploadToDrive
            // 
            btnUploadToDrive.Location = new Point(523, 208);
            btnUploadToDrive.Margin = new Padding(3, 2, 3, 2);
            btnUploadToDrive.Name = "btnUploadToDrive";
            btnUploadToDrive.Size = new Size(164, 26);
            btnUploadToDrive.TabIndex = 4;
            btnUploadToDrive.Text = "btnUploadToDrive";
            btnUploadToDrive.UseVisualStyleBackColor = true;
            btnUploadToDrive.Visible = false;
            btnUploadToDrive.Click += btnUploadToDrive_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(358, 208);
            btnDeleteBook.Margin = new Padding(3, 2, 3, 2);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(164, 26);
            btnDeleteBook.TabIndex = 3;
            btnDeleteBook.Text = "btnDeleteBook";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Visible = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Location = new Point(194, 208);
            btnEditBook.Margin = new Padding(3, 2, 3, 2);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(164, 26);
            btnEditBook.TabIndex = 2;
            btnEditBook.Text = "btnEditBook";
            btnEditBook.UseVisualStyleBackColor = true;
            btnEditBook.Visible = false;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(30, 208);
            btnAddBook.Margin = new Padding(3, 2, 3, 2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(164, 26);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "btnAddBook";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Visible = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(30, 36);
            dgvBooks.Margin = new Padding(3, 2, 3, 2);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
<<<<<<< Updated upstream
            dgvBooks.Size = new Size(740, 144);
=======
            dgvBooks.Size = new Size(863, 130);
>>>>>>> Stashed changes
            dgvBooks.TabIndex = 0;
            dgvBooks.Visible = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(kryptonDataGridViewCategories);
            tabPage3.Controls.Add(kryptonButtonDeleteCategory);
            tabPage3.Controls.Add(kryptonButtonEditCategory);
            tabPage3.Controls.Add(kryptonTextBoxSearchCate);
            tabPage3.Controls.Add(kryptonButtonAddCategory);
            tabPage3.Controls.Add(SearchCate);
            tabPage3.Controls.Add(dgvCategories);
            tabPage3.Controls.Add(btnDeleteCategory);
            tabPage3.Controls.Add(btnEditCategory);
            tabPage3.Controls.Add(btnAddCategory);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
<<<<<<< Updated upstream
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(870, 319);
=======
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1025, 326);
>>>>>>> Stashed changes
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabCategories";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // kryptonDataGridViewCategories
            // 
            kryptonDataGridViewCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kryptonDataGridViewCategories.BorderStyle = BorderStyle.None;
            kryptonDataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridViewCategories.Location = new Point(26, 48);
            kryptonDataGridViewCategories.Margin = new Padding(3, 4, 3, 4);
            kryptonDataGridViewCategories.Name = "kryptonDataGridViewCategories";
            kryptonDataGridViewCategories.RowHeadersWidth = 51;
            kryptonDataGridViewCategories.Size = new Size(938, 160);
            kryptonDataGridViewCategories.StateCommon.Background.Color1 = Color.White;
            kryptonDataGridViewCategories.StateCommon.Background.Color2 = Color.White;
            kryptonDataGridViewCategories.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridViewCategories.StateCommon.DataCell.Border.Rounding = 20F;
            kryptonDataGridViewCategories.StateCommon.DataCell.Border.Width = 1;
            kryptonDataGridViewCategories.TabIndex = 21;
            // 
            // kryptonButtonDeleteCategory
            // 
            kryptonButtonDeleteCategory.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
            kryptonButtonDeleteCategory.Location = new Point(302, 229);
=======
            kryptonButtonDeleteCategory.Location = new Point(389, 216);
            kryptonButtonDeleteCategory.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
            kryptonButtonDeleteCategory.Name = "kryptonButtonDeleteCategory";
            kryptonButtonDeleteCategory.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteCategory.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteCategory.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButtonDeleteCategory.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButtonDeleteCategory.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteCategory.OverrideDefault.Border.Rounding = 20F;
            kryptonButtonDeleteCategory.OverrideDefault.Border.Width = 1;
            kryptonButtonDeleteCategory.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButtonDeleteCategory.Size = new Size(166, 43);
            kryptonButtonDeleteCategory.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteCategory.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonButtonDeleteCategory.StateCommon.Back.ColorAngle = 45F;
            kryptonButtonDeleteCategory.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteCategory.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.StateCommon.Border.ColorAngle = 45F;
            kryptonButtonDeleteCategory.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteCategory.StateCommon.Border.Rounding = 20F;
            kryptonButtonDeleteCategory.StateCommon.Border.Width = 1;
            kryptonButtonDeleteCategory.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.StateCommon.Content.ShortText.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonDeleteCategory.StatePressed.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDeleteCategory.StatePressed.Back.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDeleteCategory.StatePressed.Back.ColorAngle = 135F;
            kryptonButtonDeleteCategory.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButtonDeleteCategory.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButtonDeleteCategory.StatePressed.Border.ColorAngle = 135F;
            kryptonButtonDeleteCategory.StatePressed.Border.Rounding = 20F;
            kryptonButtonDeleteCategory.StatePressed.Border.Width = 1;
            kryptonButtonDeleteCategory.StateTracking.Back.Color1 = SystemColors.ButtonFace;
            kryptonButtonDeleteCategory.StateTracking.Back.Color2 = SystemColors.ButtonFace;
            kryptonButtonDeleteCategory.StateTracking.Back.ColorAngle = 45F;
            kryptonButtonDeleteCategory.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButtonDeleteCategory.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonDeleteCategory.StateTracking.Border.Rounding = 20F;
            kryptonButtonDeleteCategory.StateTracking.Border.Width = 1;
            kryptonButtonDeleteCategory.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButtonDeleteCategory.TabIndex = 19;
            kryptonButtonDeleteCategory.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonDeleteCategory.Values.Text = "Delete category";
            kryptonButtonDeleteCategory.Click += kryptonButtonDeleteCategory_Click;
            // 
            // kryptonButtonEditCategory
            // 
            kryptonButtonEditCategory.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
            kryptonButtonEditCategory.Location = new Point(473, 229);
=======
            kryptonButtonEditCategory.Location = new Point(603, 216);
            kryptonButtonEditCategory.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
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
            kryptonButtonEditCategory.Size = new Size(155, 43);
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
<<<<<<< Updated upstream
            kryptonTextBoxSearchCate.Location = new Point(563, 8);
=======
            kryptonTextBoxSearchCate.Location = new Point(646, 11);
            kryptonTextBoxSearchCate.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
            kryptonTextBoxSearchCate.Name = "kryptonTextBoxSearchCate";
            kryptonTextBoxSearchCate.Size = new Size(150, 30);
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
            kryptonTextBoxSearchCate.Visible = false;
            // 
            // kryptonButtonAddCategory
            // 
            kryptonButtonAddCategory.Anchor = AnchorStyles.Bottom;
<<<<<<< Updated upstream
            kryptonButtonAddCategory.Location = new Point(141, 229);
=======
            kryptonButtonAddCategory.Location = new Point(191, 216);
            kryptonButtonAddCategory.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
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
            kryptonButtonAddCategory.Size = new Size(155, 43);
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
            SearchCate.Location = new Point(419, 14);
            SearchCate.Margin = new Padding(3, 2, 3, 2);
            SearchCate.Name = "SearchCate";
            SearchCate.Size = new Size(110, 23);
            SearchCate.TabIndex = 4;
            SearchCate.Visible = false;
            SearchCate.TextChanged += SearchCate_TextChanged;
            // 
            // dgvCategories
            // 
            dgvCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(23, 38);
            dgvCategories.Margin = new Padding(3, 2, 3, 2);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
<<<<<<< Updated upstream
            dgvCategories.Size = new Size(720, 173);
=======
            dgvCategories.Size = new Size(828, 211);
>>>>>>> Stashed changes
            dgvCategories.TabIndex = 3;
            dgvCategories.Visible = false;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(427, 210);
            btnDeleteCategory.Margin = new Padding(3, 2, 3, 2);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(166, 24);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "btnDeleteCategory";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Visible = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(261, 210);
            btnEditCategory.Margin = new Padding(3, 2, 3, 2);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(166, 24);
            btnEditCategory.TabIndex = 1;
            btnEditCategory.Text = "btnEditCategory";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Visible = false;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(95, 210);
            btnAddCategory.Margin = new Padding(3, 2, 3, 2);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(166, 24);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "btnAddCategory";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Visible = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // ChooseTag
            // 
            ChooseTag.FormattingEnabled = true;
            ChooseTag.Location = new Point(123, 25);
            ChooseTag.Margin = new Padding(3, 2, 3, 2);
            ChooseTag.Name = "ChooseTag";
            ChooseTag.Size = new Size(133, 23);
            ChooseTag.TabIndex = 2;
            ChooseTag.Visible = false;
            ChooseTag.SelectedIndexChanged += ChooseTag_SelectedIndexChanged;
            // 
            // SearchAll
            // 
            SearchAll.Location = new Point(270, 25);
            SearchAll.Margin = new Padding(3, 2, 3, 2);
            SearchAll.Name = "SearchAll";
            SearchAll.Size = new Size(110, 23);
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
            kryptonToolStrip1.Location = new Point(0, 24);
            kryptonToolStrip1.Margin = new Padding(10, 0, 10, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new Size(812, 25);
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
            toolStripSplitButton1.Size = new Size(25, 25);
            toolStripSplitButton1.Text = "File";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(92, 22);
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
            toolStripSplitButton2.Size = new Size(25, 25);
            toolStripSplitButton2.Text = "Management";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.icons8_statistic_24;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Margin = new Padding(10, 0, 10, 0);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(24, 25);
            toolStripButton1.Text = "statistic";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.icons8_configuration_24;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Margin = new Padding(10, 0, 10, 0);
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(24, 25);
            toolStripButton2.Text = "Configuration";
            // 
            // kryptonComboBoxChooseTag
            // 
            kryptonComboBoxChooseTag.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonComboBoxChooseTag.DropDownWidth = 138;
<<<<<<< Updated upstream
            kryptonComboBoxChooseTag.Location = new Point(517, 32);
=======
            kryptonComboBoxChooseTag.Location = new Point(621, 43);
            kryptonComboBoxChooseTag.Margin = new Padding(3, 4, 3, 4);
>>>>>>> Stashed changes
            kryptonComboBoxChooseTag.Name = "kryptonComboBoxChooseTag";
            kryptonComboBoxChooseTag.Size = new Size(150, 34);
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
            kryptonComboBoxChooseTag.Visible = false;
            // 
            // kryptonTextBoxSearchAll
            // 
            kryptonTextBoxSearchAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
<<<<<<< Updated upstream
            kryptonTextBoxSearchAll.Location = new Point(671, 34);
            kryptonTextBoxSearchAll.Margin = new Padding(3, 2, 3, 2);
=======
            kryptonTextBoxSearchAll.Location = new Point(797, 45);
>>>>>>> Stashed changes
            kryptonTextBoxSearchAll.Name = "kryptonTextBoxSearchAll";
            kryptonTextBoxSearchAll.Size = new Size(150, 30);
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
            kryptonTextBoxSearchAll.TextChanged += kryptonTextBoxSearchAll_TextChanged;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(904, 382);
=======
            ClientSize = new Size(1095, 414);
>>>>>>> Stashed changes
            Controls.Add(kryptonComboBoxChooseTag);
            Controls.Add(kryptonTextBoxSearchAll);
            Controls.Add(SearchAll);
            Controls.Add(ChooseTag);
            Controls.Add(tabControlAdmin);
            Controls.Add(menuStripAdmin);
            Controls.Add(kryptonToolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            LocalCustomPalette = kryptonCustomPaletteBase1;
            MainMenuStrip = menuStripAdmin;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            menuStripAdmin.ResumeLayout(false);
            menuStripAdmin.PerformLayout();
            tabControlAdmin.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridViewCategories).EndInit();
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
        private Krypton.Toolkit.KryptonButton btnInitializeData;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewUsers;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewBooks;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewCategories;
    }
}