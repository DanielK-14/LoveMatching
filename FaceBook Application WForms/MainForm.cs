using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FaceBook_Application_WForms
{
    public partial class MainForm: Form
    {
        private PictureBox profilePictureBox;
        private Label fullNameUser;
        private Label emailUserLabel;
        private Label birthdayLabel;
        private Label postLabel;
        private TextBox postTextBox;
        private Button postButton;
        private LoginForm r_loginForm = new LoginForm();
        private User m_LoggedInUser;

        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;

            if (r_loginForm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }

            m_LoggedInUser = r_loginForm.LogInInfo.LoggedInUser;
            fetchUserInfo();
            
        }

        private void fetchUserInfo()
        {
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            fullNameUser.Text = m_LoggedInUser.Name;
            birthdayLabel.Text = m_LoggedInUser.Birthday;
            emailUserLabel.Text = m_LoggedInUser.Email;
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            Status postNewStatus = m_LoggedInUser.PostStatus(postTextBox.Text);
            MessageBox.Show(string.Format("Status Posted! {0}{1}" ,Environment.NewLine, postTextBox.Text));
        }

        private void InitializeComponent()
        {
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.fullNameUser = new System.Windows.Forms.Label();
            this.emailUserLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(12, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // fullNameUser
            // 
            this.fullNameUser.AutoSize = true;
            this.fullNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameUser.Location = new System.Drawing.Point(136, 25);
            this.fullNameUser.Name = "fullNameUser";
            this.fullNameUser.Size = new System.Drawing.Size(167, 37);
            this.fullNameUser.TabIndex = 1;
            this.fullNameUser.Text = "Full name";
            // 
            // emailUserLabel
            // 
            this.emailUserLabel.AutoSize = true;
            this.emailUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUserLabel.Location = new System.Drawing.Point(140, 88);
            this.emailUserLabel.Name = "emailUserLabel";
            this.emailUserLabel.Size = new System.Drawing.Size(48, 20);
            this.emailUserLabel.TabIndex = 2;
            this.emailUserLabel.Text = "Email";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.Location = new System.Drawing.Point(139, 62);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(92, 26);
            this.birthdayLabel.TabIndex = 3;
            this.birthdayLabel.Text = "Birthday";
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postLabel.Location = new System.Drawing.Point(12, 135);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(211, 29);
            this.postLabel.TabIndex = 4;
            this.postLabel.Text = "Write new status:";
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(220, 144);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(548, 20);
            this.postTextBox.TabIndex = 5;
            // 
            // postButton
            // 
            this.postButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.Location = new System.Drawing.Point(775, 135);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(97, 32);
            this.postButton.TabIndex = 6;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.emailUserLabel);
            this.Controls.Add(this.fullNameUser);
            this.Controls.Add(this.profilePictureBox);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
