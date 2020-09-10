namespace UI
{
    partial class MainPageForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label updateTimeLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label privacyLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.ChooseDataTypeLabel = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.postLabel = new System.Windows.Forms.Label();
            this.fullNameUser = new System.Windows.Forms.Label();
            this.showPostsButton = new System.Windows.Forms.Button();
            this.showEventsButton = new System.Windows.Forms.Button();
            this.showFriendsButton = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.GetMatchesButton = new System.Windows.Forms.Button();
            this.ZodiakSignLink = new System.Windows.Forms.LinkLabel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeLabel1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endTimeLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.privacyLabel1 = new System.Windows.Forms.Label();
            this.startTimeLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.eventPictureBox = new System.Windows.Forms.PictureBox();
            this.postPictureBox = new System.Windows.Forms.PictureBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            privacyLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(7, 100);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(7, 137);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Location = new System.Drawing.Point(5, 245);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(71, 13);
            updateTimeLabel.TabIndex = 6;
            updateTimeLabel.Text = "Update Time:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(5, 167);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(63, 13);
            descriptionLabel1.TabIndex = 0;
            descriptionLabel1.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(1, 123);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 148);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // privacyLabel
            // 
            privacyLabel.AutoSize = true;
            privacyLabel.Location = new System.Drawing.Point(5, 250);
            privacyLabel.Name = "privacyLabel";
            privacyLabel.Size = new System.Drawing.Size(45, 13);
            privacyLabel.TabIndex = 8;
            privacyLabel.Text = "Privacy:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(2, 98);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 10;
            startTimeLabel.Text = "Start Time:";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Location = new System.Drawing.Point(23, 22);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(130, 118);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // ChooseDataTypeLabel
            // 
            this.ChooseDataTypeLabel.AutoSize = true;
            this.ChooseDataTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChooseDataTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDataTypeLabel.Location = new System.Drawing.Point(274, 192);
            this.ChooseDataTypeLabel.Name = "ChooseDataTypeLabel";
            this.ChooseDataTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChooseDataTypeLabel.Size = new System.Drawing.Size(331, 29);
            this.ChooseDataTypeLabel.TabIndex = 20;
            this.ChooseDataTypeLabel.Text = "What would you like to see:";
            // 
            // postButton
            // 
            this.postButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.Location = new System.Drawing.Point(771, 153);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(97, 32);
            this.postButton.TabIndex = 17;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(225, 161);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(540, 20);
            this.postTextBox.TabIndex = 22;
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.BackColor = System.Drawing.Color.Transparent;
            this.postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postLabel.Location = new System.Drawing.Point(18, 153);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(211, 29);
            this.postLabel.TabIndex = 16;
            this.postLabel.Text = "Write new status:";
            // 
            // fullNameUser
            // 
            this.fullNameUser.AutoSize = true;
            this.fullNameUser.BackColor = System.Drawing.Color.Transparent;
            this.fullNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameUser.Location = new System.Drawing.Point(159, 35);
            this.fullNameUser.Name = "fullNameUser";
            this.fullNameUser.Size = new System.Drawing.Size(243, 55);
            this.fullNameUser.TabIndex = 13;
            this.fullNameUser.Text = "Full name";
            // 
            // showPostsButton
            // 
            this.showPostsButton.BackColor = System.Drawing.Color.Gray;
            this.showPostsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPostsButton.Enabled = false;
            this.showPostsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPostsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showPostsButton.Location = new System.Drawing.Point(23, 225);
            this.showPostsButton.Name = "showPostsButton";
            this.showPostsButton.Size = new System.Drawing.Size(209, 43);
            this.showPostsButton.TabIndex = 25;
            this.showPostsButton.Text = "Loading Posts";
            this.showPostsButton.UseVisualStyleBackColor = false;
            this.showPostsButton.Click += new System.EventHandler(this.ShowPostsButton_Click);
            // 
            // showEventsButton
            // 
            this.showEventsButton.BackColor = System.Drawing.Color.Gray;
            this.showEventsButton.Enabled = false;
            this.showEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEventsButton.Location = new System.Drawing.Point(438, 225);
            this.showEventsButton.Name = "showEventsButton";
            this.showEventsButton.Size = new System.Drawing.Size(209, 43);
            this.showEventsButton.TabIndex = 26;
            this.showEventsButton.Text = "Loading Events";
            this.showEventsButton.UseVisualStyleBackColor = false;
            this.showEventsButton.Click += new System.EventHandler(this.ShowEventsButton_Click);
            // 
            // showFriendsButton
            // 
            this.showFriendsButton.BackColor = System.Drawing.Color.Gray;
            this.showFriendsButton.Enabled = false;
            this.showFriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFriendsButton.Location = new System.Drawing.Point(230, 225);
            this.showFriendsButton.Name = "showFriendsButton";
            this.showFriendsButton.Size = new System.Drawing.Size(209, 43);
            this.showFriendsButton.TabIndex = 30;
            this.showFriendsButton.Text = "Loading Friends";
            this.showFriendsButton.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(173, 96);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 24);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Profile";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // GetMatchesButton
            // 
            this.GetMatchesButton.BackColor = System.Drawing.Color.Gray;
            this.GetMatchesButton.Enabled = false;
            this.GetMatchesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetMatchesButton.Location = new System.Drawing.Point(645, 225);
            this.GetMatchesButton.Name = "GetMatchesButton";
            this.GetMatchesButton.Size = new System.Drawing.Size(209, 43);
            this.GetMatchesButton.TabIndex = 33;
            this.GetMatchesButton.Text = "Get Matches";
            this.GetMatchesButton.UseVisualStyleBackColor = false;
            // 
            // ZodiakSignLink
            // 
            this.ZodiakSignLink.AutoSize = true;
            this.ZodiakSignLink.BackColor = System.Drawing.Color.Transparent;
            this.ZodiakSignLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ZodiakSignLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ZodiakSignLink.Location = new System.Drawing.Point(172, 120);
            this.ZodiakSignLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ZodiakSignLink.Name = "ZodiakSignLink";
            this.ZodiakSignLink.Size = new System.Drawing.Size(114, 24);
            this.ZodiakSignLink.TabIndex = 34;
            this.ZodiakSignLink.TabStop = true;
            this.ZodiakSignLink.Text = "Find Match";
            this.ZodiakSignLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ZodiakSignLink_LinkClicked);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logoutButton.Location = new System.Drawing.Point(777, 22);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(81, 31);
            this.logoutButton.TabIndex = 35;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // postsListBox
            // 
            this.postsListBox.DataSource = this.postBindingSource;
            this.postsListBox.DisplayMember = "Message";
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.Location = new System.Drawing.Point(23, 312);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(119, 277);
            this.postsListBox.TabIndex = 36;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Your Posts:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.postPictureBox);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeLabel1);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(updateTimeLabel);
            this.panel1.Controls.Add(this.updateTimeLabel1);
            this.panel1.Location = new System.Drawing.Point(144, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 277);
            this.panel1.TabIndex = 38;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(76, 98);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(87, 23);
            this.createdTimeLabel1.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(10, 153);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(142, 84);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // updateTimeLabel1
            // 
            this.updateTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "UpdateTime", true));
            this.updateTimeLabel1.Location = new System.Drawing.Point(76, 240);
            this.updateTimeLabel1.Name = "updateTimeLabel1";
            this.updateTimeLabel1.Size = new System.Drawing.Size(87, 23);
            this.updateTimeLabel1.TabIndex = 7;
            this.updateTimeLabel1.Text = "label4";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.eventPictureBox);
            this.panel2.Controls.Add(descriptionLabel1);
            this.panel2.Controls.Add(this.descriptionTextBox1);
            this.panel2.Controls.Add(endTimeLabel);
            this.panel2.Controls.Add(this.endTimeLabel1);
            this.panel2.Controls.Add(nameLabel);
            this.panel2.Controls.Add(this.nameLabel1);
            this.panel2.Controls.Add(privacyLabel);
            this.panel2.Controls.Add(this.privacyLabel1);
            this.panel2.Controls.Add(startTimeLabel);
            this.panel2.Controls.Add(this.startTimeLabel1);
            this.panel2.Location = new System.Drawing.Point(467, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 277);
            this.panel2.TabIndex = 41;
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(9, 183);
            this.descriptionTextBox1.Multiline = true;
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(161, 62);
            this.descriptionTextBox1.TabIndex = 1;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // endTimeLabel1
            // 
            this.endTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true));
            this.endTimeLabel1.Location = new System.Drawing.Point(60, 118);
            this.endTimeLabel1.Name = "endTimeLabel1";
            this.endTimeLabel1.Size = new System.Drawing.Size(110, 23);
            this.endTimeLabel1.TabIndex = 3;
            this.endTimeLabel1.Text = "label4";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(60, 144);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(110, 23);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "label4";
            // 
            // privacyLabel1
            // 
            this.privacyLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Privacy", true));
            this.privacyLabel1.Location = new System.Drawing.Point(60, 250);
            this.privacyLabel1.Name = "privacyLabel1";
            this.privacyLabel1.Size = new System.Drawing.Size(110, 23);
            this.privacyLabel1.TabIndex = 9;
            this.privacyLabel1.Text = "label4";
            // 
            // startTimeLabel1
            // 
            this.startTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.startTimeLabel1.Location = new System.Drawing.Point(60, 95);
            this.startTimeLabel1.Name = "startTimeLabel1";
            this.startTimeLabel1.Size = new System.Drawing.Size(110, 23);
            this.startTimeLabel1.TabIndex = 11;
            this.startTimeLabel1.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Your Events:";
            // 
            // eventsListBox
            // 
            this.eventsListBox.DataSource = this.eventBindingSource;
            this.eventsListBox.DisplayMember = "Name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(325, 312);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(141, 277);
            this.eventsListBox.TabIndex = 39;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(658, 312);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(200, 134);
            this.friendsListBox.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Your Friends:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Your Matches:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(658, 466);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 48;
            this.button1.Text = "Ask to go out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // eventPictureBox
            // 
            this.eventPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.eventBindingSource, "PictureLargeURL", true));
            this.eventPictureBox.Location = new System.Drawing.Point(38, 3);
            this.eventPictureBox.Name = "eventPictureBox";
            this.eventPictureBox.Size = new System.Drawing.Size(100, 89);
            this.eventPictureBox.TabIndex = 12;
            this.eventPictureBox.TabStop = false;
            // 
            // postPictureBox
            // 
            this.postPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.postBindingSource, "PictureURL", true));
            this.postPictureBox.Location = new System.Drawing.Point(33, 3);
            this.postPictureBox.Name = "postPictureBox";
            this.postPictureBox.Size = new System.Drawing.Size(100, 89);
            this.postPictureBox.TabIndex = 8;
            this.postPictureBox.TabStop = false;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postsListBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.ZodiakSignLink);
            this.Controls.Add(this.GetMatchesButton);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.showFriendsButton);
            this.Controls.Add(this.showEventsButton);
            this.Controls.Add(this.showPostsButton);
            this.Controls.Add(this.ChooseDataTypeLabel);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.fullNameUser);
            this.Controls.Add(this.profilePictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(898, 669);
            this.Name = "MainPageForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label ChooseDataTypeLabel;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Label fullNameUser;
        private System.Windows.Forms.Button showPostsButton;
        private System.Windows.Forms.Button showEventsButton;
        private System.Windows.Forms.Button showFriendsButton;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button GetMatchesButton;
        private System.Windows.Forms.LinkLabel ZodiakSignLink;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label updateTimeLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label endTimeLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label privacyLabel1;
        private System.Windows.Forms.Label startTimeLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox postPictureBox;
        private System.Windows.Forms.PictureBox eventPictureBox;
    }
}