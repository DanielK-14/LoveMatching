using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FaceBook_Application_WForms
{
    internal partial class UserInformation : Form
    {
        private readonly User r_User;
        private List<PictureBox> m_pictureBoxes;

        internal delegate void BackButtonDelegate();

        internal event BackButtonDelegate BackButtonOperation;

        internal UserInformation(User i_User)
        {
            InitializeComponent();
            initPictureBoxes();
            r_User = i_User;
        }

        private void initPictureBoxes()
        {
            m_pictureBoxes = new List<PictureBox>();
            m_pictureBoxes.Add(pictureBox1);
            m_pictureBoxes.Add(pictureBox2);
            m_pictureBoxes.Add(pictureBox3);
            m_pictureBoxes.Add(pictureBox4);
            hidePhotos();
        }

        internal void fetchOnLoad()
        {
            fetchUserInfo();
            fetchPhotos();
        }

        private void fetchUserInfo()
        {
            profilePictureBox.LoadAsync(r_User.PictureLargeURL);
            if (r_User.Cover != null)
            {
                coverPictureBox.LoadAsync(r_User.Cover.SourceURL);
            }

            nameLabel.Text = r_User.Name;
            birthdayLabel.Text = r_User.Birthday;
            emailLabel.Text = r_User.Email;
        }

        private void fetchPhotos()
        {
            IEnumerator<Photo> PhotosEnumerator = r_User.PhotosTaggedIn.GetEnumerator();
            foreach (PictureBox pictureBox in m_pictureBoxes)
            {
                if (PhotosEnumerator.MoveNext())
                {
                    pictureBox.LoadAsync(PhotosEnumerator.Current.PictureNormalURL);
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
            foreach (PictureBox pictureBox in m_pictureBoxes)
            {
                pictureBox.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (BackButtonOperation != null)
            {
                BackButtonOperation.Invoke();
            }
        }
    }
}
