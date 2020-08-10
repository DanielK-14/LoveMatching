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
            InitializeComponent();
            r_User = i_User;
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
            IEnumerator<Photo> PhotosEnumerator = r_User.PhotosTaggedIn.GetEnumerator();
            if (PhotosEnumerator.MoveNext())
            {
                PictureBox1.LoadAsync(PhotosEnumerator.Current.PictureNormalURL);
            }

            if (PhotosEnumerator.MoveNext())
            {
                PictureBox2.LoadAsync(PhotosEnumerator.Current.PictureNormalURL);
            }

            if (PhotosEnumerator.MoveNext())
            {
                PictureBox3.LoadAsync(PhotosEnumerator.Current.PictureNormalURL);
            }

            if (PhotosEnumerator.MoveNext())
            {
                PictureBox4.LoadAsync(PhotosEnumerator.Current.PictureNormalURL);
            }
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
