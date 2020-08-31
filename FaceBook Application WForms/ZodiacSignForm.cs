using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UI
{
    internal partial class ZodiacSignForm : Form
    {
        internal delegate void BackButtonEventHandler();

        internal event BackButtonEventHandler BackButtonClicked;

        private readonly ZodiacSignAdapter r_ZodiacMatch;

        private readonly User r_LoggedInUser;

        internal ZodiacSignForm(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            r_ZodiacMatch = new ZodiacSignAdapter(i_LoggedInUser.Birthday);
            InitializeComponent();
            try
            {
                pictureBox1.LoadAsync(r_ZodiacMatch.PictureUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load picture of zodiac sign.");
                throw ex;
            }

            userSignNameLabel.Text = r_ZodiacMatch.Name;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            r_ZodiacMatch.UpdateBestMatchedSign();
            try
            {
                pictureBox2.LoadAsync(r_ZodiacMatch.BestMatchedSign.PictureUrl);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load picture of zodiac sign.");
            }

            matchSignNameLabel.Text = r_ZodiacMatch.BestMatchedSign.Name;
            findButton.Visible = false;
            pictureBox2.Visible = true;
            matchSignNameLabel.Visible = true;
            fateQuotePicture.Visible = true;
            shareButton.Visible = true;
            MessageBox.Show("Congratulations! A match was found!");
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            if (BackButtonClicked != null)
            {
                BackButtonClicked.Invoke();
            }

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
                    r_ZodiacMatch.BestMatchedSign.Name,
                    r_LoggedInUser.InterestedIn,
                    Environment.NewLine);
                r_LoggedInUser.PostStatus(textForPost);
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
