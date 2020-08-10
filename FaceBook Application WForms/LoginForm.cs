using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;

namespace FaceBook_Application_WForms
{
    public partial class LoginForm : Form
    {
        private LoginResult m_Result;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginResult LogInInfo
        {
            get { return m_Result; }
        }

        private void loginAndInit(object sender, EventArgs e)
        {
            m_Result = FacebookService.Login("1206785753020262",
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

            if (string.IsNullOrEmpty(m_Result.AccessToken) == true)
            {
                MessageBox.Show(m_Result.ErrorMessage);
                DialogResult = DialogResult.Abort;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
