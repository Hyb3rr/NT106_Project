namespace BookReaderApp.ViewForm
{
    partial class ChatMainForm
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
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            btnCreateRoom = new Button();
            btnRefreshRooms = new Button();
            listBoxChatRooms = new ListBox();
            splitContainer2 = new SplitContainer();
            groupBox2 = new GroupBox();
            richTextBoxMessages = new RichTextBox();
            lblCurrentRoom = new Label();
            pictureBoxBook = new PictureBox();
            panel1 = new Panel();
            btnSend = new Button();
            textBoxMessage = new TextBox();
            groupBox3 = new GroupBox();
            listBoxMembers = new ListBox();
            btnLeaveRoom = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1143, 800);
            splitContainer1.SplitterDistance = 285;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreateRoom);
            groupBox1.Controls.Add(btnRefreshRooms);
            groupBox1.Controls.Add(listBoxChatRooms);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(285, 800);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phòng Chat";
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreateRoom.Location = new Point(7, 721);
            btnCreateRoom.Margin = new Padding(3, 4, 3, 4);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(271, 31);
            btnCreateRoom.TabIndex = 2;
            btnCreateRoom.Text = "Tạo phòng mới";
            btnCreateRoom.UseVisualStyleBackColor = true;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // btnRefreshRooms
            // 
            btnRefreshRooms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRefreshRooms.Location = new Point(7, 760);
            btnRefreshRooms.Margin = new Padding(3, 4, 3, 4);
            btnRefreshRooms.Name = "btnRefreshRooms";
            btnRefreshRooms.Size = new Size(271, 31);
            btnRefreshRooms.TabIndex = 1;
            btnRefreshRooms.Text = "Làm mới";
            btnRefreshRooms.UseVisualStyleBackColor = true;
            btnRefreshRooms.Click += btnRefreshRooms_Click;
            // 
            // listBoxChatRooms
            // 
            listBoxChatRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxChatRooms.FormattingEnabled = true;
            listBoxChatRooms.Location = new Point(7, 29);
            listBoxChatRooms.Margin = new Padding(3, 4, 3, 4);
            listBoxChatRooms.Name = "listBoxChatRooms";
            listBoxChatRooms.Size = new Size(270, 684);
            listBoxChatRooms.TabIndex = 0;
            listBoxChatRooms.SelectedIndexChanged += listBoxChatRooms_SelectedIndexChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox3);
            splitContainer2.Size = new Size(853, 800);
            splitContainer2.SplitterDistance = 628;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxMessages);
            groupBox2.Controls.Add(lblCurrentRoom);
            groupBox2.Controls.Add(pictureBoxBook);
            groupBox2.Controls.Add(panel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(628, 800);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tin nhắn";
            // 
            // richTextBoxMessages
            // 
            richTextBoxMessages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxMessages.Location = new Point(7, 120);
            richTextBoxMessages.Margin = new Padding(3, 4, 3, 4);
            richTextBoxMessages.Name = "richTextBoxMessages";
            richTextBoxMessages.ReadOnly = true;
            richTextBoxMessages.Size = new Size(613, 592);
            richTextBoxMessages.TabIndex = 2;
            richTextBoxMessages.Text = "";
            // 
            // lblCurrentRoom
            // 
            lblCurrentRoom.AutoSize = true;
            lblCurrentRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCurrentRoom.Location = new Point(7, 33);
            lblCurrentRoom.Name = "lblCurrentRoom";
            lblCurrentRoom.Size = new Size(149, 20);
            lblCurrentRoom.TabIndex = 1;
            lblCurrentRoom.Text = "Chọn phòng để chat";
            // 
            // pictureBoxBook
            // 
            pictureBoxBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxBook.BackColor = SystemColors.Control;
            pictureBoxBook.Location = new Point(517, 13);
            pictureBoxBook.Margin = new Padding(3, 4, 3, 4);
            pictureBoxBook.Name = "pictureBoxBook";
            pictureBoxBook.Size = new Size(103, 110);
            pictureBoxBook.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBook.TabIndex = 3;
            pictureBoxBook.TabStop = false;
            pictureBoxBook.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(textBoxMessage);
            panel1.Location = new Point(7, 721);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 71);
            panel1.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.Location = new Point(525, 20);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(86, 31);
            btnSend.TabIndex = 1;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMessage.Location = new Point(3, 20);
            textBoxMessage.Margin = new Padding(3, 4, 3, 4);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(514, 27);
            textBoxMessage.TabIndex = 0;
            textBoxMessage.KeyDown += textBoxMessage_KeyDown;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBoxMembers);
            groupBox3.Controls.Add(btnLeaveRoom);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(220, 800);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thành viên";
            // 
            // listBoxMembers
            // 
            listBoxMembers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxMembers.FormattingEnabled = true;
            listBoxMembers.Location = new Point(7, 29);
            listBoxMembers.Margin = new Padding(3, 4, 3, 4);
            listBoxMembers.Name = "listBoxMembers";
            listBoxMembers.Size = new Size(206, 724);
            listBoxMembers.TabIndex = 1;
            // 
            // btnLeaveRoom
            // 
            btnLeaveRoom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLeaveRoom.Location = new Point(7, 760);
            btnLeaveRoom.Margin = new Padding(3, 4, 3, 4);
            btnLeaveRoom.Name = "btnLeaveRoom";
            btnLeaveRoom.Size = new Size(207, 31);
            btnLeaveRoom.TabIndex = 0;
            btnLeaveRoom.Text = "Rời phòng";
            btnLeaveRoom.UseVisualStyleBackColor = true;
            btnLeaveRoom.Click += btnLeaveRoom_Click;
            // 
            // ChatMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 800);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChatMainForm";
            Text = "Phòng Chat - Book Reader";
            Load += ChatMainForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Button btnRefreshRooms;
        private System.Windows.Forms.ListBox listBoxChatRooms;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
        private System.Windows.Forms.Label lblCurrentRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxMembers;
        private System.Windows.Forms.Button btnLeaveRoom;
        private System.Windows.Forms.PictureBox pictureBoxBook;
    }
}
