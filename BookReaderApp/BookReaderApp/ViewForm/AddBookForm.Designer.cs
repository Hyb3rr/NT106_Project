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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            dtpUploadDate = new DateTimePicker();
            chkIsDisplayed = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(332, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(332, 149);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(332, 214);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(107, 27);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 3;
            // 
            // dtpUploadDate
            // 
            dtpUploadDate.Location = new Point(55, 106);
            dtpUploadDate.Name = "dtpUploadDate";
            dtpUploadDate.Size = new Size(250, 27);
            dtpUploadDate.TabIndex = 4;
            // 
            // chkIsDisplayed
            // 
            chkIsDisplayed.AutoSize = true;
            chkIsDisplayed.Location = new Point(114, 185);
            chkIsDisplayed.Name = "chkIsDisplayed";
            chkIsDisplayed.Size = new Size(129, 24);
            chkIsDisplayed.TabIndex = 5;
            chkIsDisplayed.Text = "chkIsDisplayed";
            chkIsDisplayed.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(211, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(325, 302);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkIsDisplayed);
            Controls.Add(dtpUploadDate);
            Controls.Add(cmbCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "AddBookForm";
            Text = "AddBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private ComboBox cmbCategory;
        private DateTimePicker dtpUploadDate;
        private CheckBox chkIsDisplayed;
        private Button btnSave;
        private Button btnCancel;
    }
}