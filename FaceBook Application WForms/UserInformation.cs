using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FaceBook_Application_WForms
{
    public partial class UserInformation : Form
    {
        private readonly User r_User;
        public delegate void BackButtonDelegate();
        public event BackButtonDelegate BackButtonOperation;

        public UserInformation(User i_User)
        {
            r_User = i_User;
            InitializeComponent();
            fetchUserInfo();
            fetchPhotos();
        }

        private void fetchUserInfo()
        {
            ProfilePictureBox.LoadAsync(r_User.PictureNormalURL);
            if (r_User.Cover != null)
            {
                CoverPictureBox.LoadAsync(r_User.Cover.SourceURL);
            }

            NameLabel.Text = r_User.Name;
            BirthdayLabel.Text = r_User.Birthday;
            EmailLabel.Text = r_User.Email;
        }

        private void fetchPhotos()
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (BackButtonOperation != null)
            {
                BackButtonOperation.Invoke();
            }
        }
    }
}
