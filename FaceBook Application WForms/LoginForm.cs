using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace UI
{
    internal partial class LoginForm : Form
    {
        internal LoginForm()
        {
            InitializeComponent();
        }

        internal LoginResult LogInInfo { get; private set; }

        private void loginAndInit(object sender, EventArgs e)
        {
            LogInInfo = FacebookService.Login(
                "1206785753020262",
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_tagged_places",
                "user_videos",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts");

            if (string.IsNullOrEmpty(LogInInfo.AccessToken) == true)
            {
                MessageBox.Show(LogInInfo.ErrorMessage);
                DialogResult = DialogResult.Abort;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
