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
        private List<PictureBox> m_pictureBoxes;

        public delegate void BackButtonDelegate();
        public event BackButtonDelegate BackButtonOperation;
        public UserInformation(User i_User)
        {
            InitializeComponent();
            initPictureBoxes();
            r_User = i_User;
        }

        private void initPictureBoxes()
        {
            m_pictureBoxes = new List<PictureBox>();
            m_pictureBoxes.Add(PictureBox1);
            m_pictureBoxes.Add(PictureBox2);
            m_pictureBoxes.Add(PictureBox3);
            m_pictureBoxes.Add(PictureBox4);
        }

        internal void fetchOnLoad()
        {
            fetchUserInfo();
            fetchPhotos();
        }

        private void fetchUserInfo()
        {
            ProfilePictureBox.LoadAsync(r_User.PictureLargeURL);
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
            try 
            {
                IEnumerator<Photo> PhotosEnumerator = r_User.PhotosTaggedIn.GetEnumerator();
                foreach (PictureBox pictureBox in m_pictureBoxes)
                {
                    if (PhotosEnumerator.MoveNext())
                    {
                        pictureBox.LoadAsync(PhotosEnumerator.Current.PictureNormalURL);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                hidePhotos();
                MessageBox.Show(string.Format("{0}{1}PHOTOS NOT LOADED!", ex.Message, Environment.NewLine));
            }
        }

        private void hidePhotos()
        {
            foreach (PictureBox pictureBox in m_pictureBoxes)
            {
                pictureBox.Visible = false;
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
