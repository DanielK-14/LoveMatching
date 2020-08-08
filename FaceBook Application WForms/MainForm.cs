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
        LoginForm r_loginForm = new LoginForm();

        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;

            if (r_loginForm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }

            fetchUserInfo();

        }

        private void fetchUserInfo()
        {
            User loggedInUser = r_loginForm.LogInInfo.LoggedInUser;
            profilePictureBox.LoadAsync(loggedInUser.PictureNormalURL);
            fullNameUser.Text = loggedInUser.Name;
            birthdayLabel.Text = loggedInUser.Birthday;
            emailUserLabel.Text = loggedInUser.Email;
        }

        private void InitializeComponent()
        {
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.fullNameUser = new System.Windows.Forms.Label();
            this.emailUserLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
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
            this.fullNameUser.Size = new System.Drawing.Size(243, 55);
            this.fullNameUser.TabIndex = 1;
            this.fullNameUser.Text = "Full name";
            // 
            // emailUserLabel
            // 
            this.emailUserLabel.AutoSize = true;
            this.emailUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUserLabel.Location = new System.Drawing.Point(140, 88);
            this.emailUserLabel.Name = "emailUserLabel";
            this.emailUserLabel.Size = new System.Drawing.Size(74, 29);
            this.emailUserLabel.TabIndex = 2;
            this.emailUserLabel.Text = "Email";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.Location = new System.Drawing.Point(139, 62);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(134, 37);
            this.birthdayLabel.TabIndex = 3;
            this.birthdayLabel.Text = "Birthday";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.emailUserLabel);
            this.Controls.Add(this.fullNameUser);
            this.Controls.Add(this.profilePictureBox);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
