using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UI
{
    internal partial class UserInformation : Form
    {
        private readonly User r_User;
        private List<PictureBox> m_PictureBoxes;

        internal delegate void BackButtonEventHandler();

        internal event BackButtonEventHandler BackButtonClicked;

        internal UserInformation(User i_User)
        {
            InitializeComponent();
            initPictureBoxes();
            r_User = i_User;
        }

        private void initPictureBoxes()
        {
            m_PictureBoxes = new List<PictureBox>();
            m_PictureBoxes.Add(pictureBox1);
            m_PictureBoxes.Add(pictureBox2);
            m_PictureBoxes.Add(pictureBox3);
            m_PictureBoxes.Add(pictureBox4);
            hidePhotos();
        }

        internal void fetchOnLoad()
        {
            fetchUserInfo();
            fetchPhotos();
        }

        private void fetchUserInfo()
        {
            nameLabel.Text = r_User.Name;
            birthdayLabel.Text = r_User.Birthday;
            emailLabel.Text = r_User.Email;
            profilePictureBox.LoadAsync(r_User.PictureLargeURL);
            try
            {
                if (r_User.Cover != null)
                {
                    coverPictureBox.LoadAsync(r_User.Cover.SourceURL);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Could not get cover photo.");
            }
        }

        private void fetchPhotos()
        {
            IEnumerator<Photo> photosEnumerator = r_User.PhotosTaggedIn.GetEnumerator();
            foreach (PictureBox pictureBox in m_PictureBoxes)
            {
                if (photosEnumerator.MoveNext())
                {
                    pictureBox.LoadAsync(photosEnumerator.Current.PictureNormalURL);
                    pictureBox.Visible = true;
                }
                else
                {
                    break;
                }
            }
        }

        private void hidePhotos()
        {
            foreach (PictureBox pictureBox in m_PictureBoxes)
            {
                pictureBox.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (BackButtonClicked != null)
            {
                BackButtonClicked.Invoke();
            }
        }
    }
}
