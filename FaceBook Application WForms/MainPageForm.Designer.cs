namespace FaceBook_Application_WForms
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
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.ChooseDataTypeLabel = new System.Windows.Forms.Label();
            this.comboBoxDecisionData = new System.Windows.Forms.ListBox();
            this.SelectedOptionDataLable = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.postLabel = new System.Windows.Forms.Label();
            this.fullNameUser = new System.Windows.Forms.Label();
            this.dataAnalystRichBox = new System.Windows.Forms.RichTextBox();
            this.showPostsButton = new System.Windows.Forms.Button();
            this.showEventsButton = new System.Windows.Forms.Button();
            this.dataSelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.friendFirstNameLabel = new System.Windows.Forms.Label();
            this.friendLastNameLabel = new System.Windows.Forms.Label();
            this.showFriendsButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(34, 34);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(195, 182);
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // ChooseDataTypeLabel
            // 
            this.ChooseDataTypeLabel.AutoSize = true;
            this.ChooseDataTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDataTypeLabel.Location = new System.Drawing.Point(30, 322);
            this.ChooseDataTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseDataTypeLabel.Name = "ChooseDataTypeLabel";
            this.ChooseDataTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChooseDataTypeLabel.Size = new System.Drawing.Size(836, 40);
            this.ChooseDataTypeLabel.TabIndex = 20;
            this.ChooseDataTypeLabel.Text = "Please choose which data would you like to see:";
            // 
            // comboBoxDecisionData
            // 
            this.comboBoxDecisionData.FormattingEnabled = true;
            this.comboBoxDecisionData.ItemHeight = 20;
            this.comboBoxDecisionData.Location = new System.Drawing.Point(34, 446);
            this.comboBoxDecisionData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDecisionData.Name = "comboBoxDecisionData";
            this.comboBoxDecisionData.Size = new System.Drawing.Size(252, 424);
            this.comboBoxDecisionData.TabIndex = 19;
            this.comboBoxDecisionData.SelectedIndexChanged += new System.EventHandler(this.comboBoxDecisionData_SelectedIndexChanged);
            // 
            // SelectedOptionDataLable
            // 
            this.SelectedOptionDataLable.AutoSize = true;
            this.SelectedOptionDataLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedOptionDataLable.Location = new System.Drawing.Point(28, 411);
            this.SelectedOptionDataLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedOptionDataLable.Name = "SelectedOptionDataLable";
            this.SelectedOptionDataLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectedOptionDataLable.Size = new System.Drawing.Size(132, 29);
            this.SelectedOptionDataLable.TabIndex = 18;
            this.SelectedOptionDataLable.Text = "Your data:";
            // 
            // postButton
            // 
            this.postButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.Location = new System.Drawing.Point(1156, 235);
            this.postButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(146, 49);
            this.postButton.TabIndex = 17;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(338, 248);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(808, 26);
            this.postTextBox.TabIndex = 22;
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postLabel.Location = new System.Drawing.Point(27, 235);
            this.postLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(310, 40);
            this.postLabel.TabIndex = 16;
            this.postLabel.Text = "Write new status:";
            // 
            // fullNameUser
            // 
            this.fullNameUser.AutoSize = true;
            this.fullNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameUser.Location = new System.Drawing.Point(238, 54);
            this.fullNameUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullNameUser.Name = "fullNameUser";
            this.fullNameUser.Size = new System.Drawing.Size(361, 82);
            this.fullNameUser.TabIndex = 13;
            this.fullNameUser.Text = "Full name";
            // 
            // dataAnalystRichBox
            // 
            this.dataAnalystRichBox.Location = new System.Drawing.Point(338, 446);
            this.dataAnalystRichBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataAnalystRichBox.Name = "dataAnalystRichBox";
            this.dataAnalystRichBox.ReadOnly = true;
            this.dataAnalystRichBox.Size = new System.Drawing.Size(452, 424);
            this.dataAnalystRichBox.TabIndex = 24;
            this.dataAnalystRichBox.Text = "";
            this.dataAnalystRichBox.Visible = false;
            // 
            // showPostsButton
            // 
            this.showPostsButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.showPostsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPostsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPostsButton.Location = new System.Drawing.Point(897, 302);
            this.showPostsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showPostsButton.Name = "showPostsButton";
            this.showPostsButton.Size = new System.Drawing.Size(198, 51);
            this.showPostsButton.TabIndex = 25;
            this.showPostsButton.Text = "Show Posts";
            this.showPostsButton.UseVisualStyleBackColor = false;
            this.showPostsButton.Click += new System.EventHandler(this.showPostsButton_Click);
            // 
            // showEventsButton
            // 
            this.showEventsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.showEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEventsButton.Location = new System.Drawing.Point(1104, 302);
            this.showEventsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showEventsButton.Name = "showEventsButton";
            this.showEventsButton.Size = new System.Drawing.Size(198, 51);
            this.showEventsButton.TabIndex = 26;
            this.showEventsButton.Text = "Show Events";
            this.showEventsButton.UseVisualStyleBackColor = false;
            this.showEventsButton.Click += new System.EventHandler(this.showEventsButton_Click);
            // 
            // dataSelectedPictureBox
            // 
            this.dataSelectedPictureBox.Location = new System.Drawing.Point(801, 446);
            this.dataSelectedPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataSelectedPictureBox.Name = "dataSelectedPictureBox";
            this.dataSelectedPictureBox.Size = new System.Drawing.Size(346, 308);
            this.dataSelectedPictureBox.TabIndex = 27;
            this.dataSelectedPictureBox.TabStop = false;
            this.dataSelectedPictureBox.Visible = false;
            // 
            // friendFirstNameLabel
            // 
            this.friendFirstNameLabel.AutoSize = true;
            this.friendFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendFirstNameLabel.Location = new System.Drawing.Point(802, 765);
            this.friendFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.friendFirstNameLabel.Name = "friendFirstNameLabel";
            this.friendFirstNameLabel.Size = new System.Drawing.Size(203, 40);
            this.friendFirstNameLabel.TabIndex = 28;
            this.friendFirstNameLabel.Text = "First Name";
            this.friendFirstNameLabel.Visible = false;
            // 
            // friendLastNameLabel
            // 
            this.friendLastNameLabel.AutoSize = true;
            this.friendLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendLastNameLabel.Location = new System.Drawing.Point(802, 809);
            this.friendLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.friendLastNameLabel.Name = "friendLastNameLabel";
            this.friendLastNameLabel.Size = new System.Drawing.Size(191, 40);
            this.friendLastNameLabel.TabIndex = 29;
            this.friendLastNameLabel.Text = "Last Name";
            this.friendLastNameLabel.Visible = false;
            // 
            // showFriendsButton
            // 
            this.showFriendsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.showFriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFriendsButton.Location = new System.Drawing.Point(1000, 362);
            this.showFriendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showFriendsButton.Name = "showFriendsButton";
            this.showFriendsButton.Size = new System.Drawing.Size(198, 51);
            this.showFriendsButton.TabIndex = 30;
            this.showFriendsButton.Text = "Show Friends";
            this.showFriendsButton.UseVisualStyleBackColor = false;
            this.showFriendsButton.Click += new System.EventHandler(this.showFriendsButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 20);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(260, 148);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(104, 32);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Profile";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 1017);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.showFriendsButton);
            this.Controls.Add(this.friendLastNameLabel);
            this.Controls.Add(this.friendFirstNameLabel);
            this.Controls.Add(this.dataSelectedPictureBox);
            this.Controls.Add(this.showEventsButton);
            this.Controls.Add(this.showPostsButton);
            this.Controls.Add(this.dataAnalystRichBox);
            this.Controls.Add(this.ChooseDataTypeLabel);
            this.Controls.Add(this.comboBoxDecisionData);
            this.Controls.Add(this.SelectedOptionDataLable);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.fullNameUser);
            this.Controls.Add(this.profilePictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label ChooseDataTypeLabel;
        private System.Windows.Forms.ListBox comboBoxDecisionData;
        private System.Windows.Forms.Label SelectedOptionDataLable;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Label fullNameUser;
        private System.Windows.Forms.RichTextBox dataAnalystRichBox;
        private System.Windows.Forms.Button showPostsButton;
        private System.Windows.Forms.Button showEventsButton;
        private System.Windows.Forms.PictureBox dataSelectedPictureBox;
        private System.Windows.Forms.Label friendFirstNameLabel;
        private System.Windows.Forms.Label friendLastNameLabel;
        private System.Windows.Forms.Button showFriendsButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}