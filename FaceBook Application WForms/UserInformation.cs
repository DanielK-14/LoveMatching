using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UI
{
    internal partial class UserInformation : Form
    {
        private User m_LoggedInUser;
        private List<PictureBox> m_PictureBoxes;
        private readonly AppManager r_AppManager = AppManager.GetInstance;

        internal UserInformation()
        {
            InitializeComponent();
            r_AppManager.LoginEvent += switchUser;
        }

        private void switchUser()
        {
            m_LoggedInUser = r_AppManager.LoggedInUser;
            initPictureBoxes();
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

        internal new void Show()
        {
            fetchUserInfo();
            fetchPhotos();
            base.Show();
        }

        private void fetchUserInfo()
        {
            nameLabel.Text = m_LoggedInUser.Name;
            birthdayLabel.Text = m_LoggedInUser.Birthday;
            emailLabel.Text = m_LoggedInUser.Email;
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureLargeURL);
            try
            {
                if (m_LoggedInUser.Cover != null)
                {
                    coverPictureBox.LoadAsync(m_LoggedInUser.Cover.SourceURL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not get cover photo.");
                throw ex;
            }
        }

        private void fetchPhotos()
        {
            IEnumerator<Photo> photosEnumerator = m_LoggedInUser.PhotosTaggedIn.GetEnumerator();
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
            r_AppManager.Back();
        }
    }
}
