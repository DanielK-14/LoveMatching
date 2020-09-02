using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UI
{
    internal partial class ZodiacSignForm : Form
    {

        private ZodiacSignAdapter m_ZodiacMatch;

        private User m_LoggedInUser;

        private readonly AppManager r_AppManager = AppManager.GetInstance;

        internal ZodiacSignForm()
        {
            InitializeComponent();
            r_AppManager.LoginEvent += switchUser;
        }

        private void switchUser()
        {
            m_LoggedInUser = r_AppManager.LoggedInUser;
            m_ZodiacMatch = new ZodiacSignAdapter(m_LoggedInUser.Birthday);
            try
            {
                pictureBox1.LoadAsync(m_ZodiacMatch.PictureUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load picture of zodiac sign.");
                throw ex;
            }

            userSignNameLabel.Text = m_ZodiacMatch.Name;

        }
        private void findButton_Click(object sender, EventArgs e)
        {
            m_ZodiacMatch.UpdateBestMatchedSign();
            try
            {
                pictureBox2.LoadAsync(m_ZodiacMatch.BestMatchedSign.PictureUrl);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load picture of zodiac sign.");
            }

            matchSignNameLabel.Text = m_ZodiacMatch.BestMatchedSign.Name;
            findButton.Visible = false;
            pictureBox2.Visible = true;
            matchSignNameLabel.Visible = true;
            fateQuotePicture.Visible = true;
            shareButton.Visible = true;
            MessageBox.Show("Congratulations! A match was found!");
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            r_AppManager.Back();
            findButton.Visible = true;
            pictureBox2.Visible = false;
            matchSignNameLabel.Visible = false;
            fateQuotePicture.Visible = false;
            shareButton.Visible = false;
        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            try
            {
                string textForPost = string.Format(
                    "Looking for {0} {1} {2} Anyone?",
                    m_ZodiacMatch.BestMatchedSign.Name,
                    m_LoggedInUser.InterestedIn,
                    Environment.NewLine);
                m_LoggedInUser.PostStatus(textForPost);
                MessageBox.Show(string.Format("Status Posted! {0}{1}", Environment.NewLine, textForPost));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not share post.");
                throw ex;
            }
        }
    }
}
