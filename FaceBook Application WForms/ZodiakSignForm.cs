using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FaceBook_Application_WForms
{
    internal partial class ZodiakSignForm : Form
    {
        internal delegate void BackButtonDelegate();
        internal event BackButtonDelegate BackButtonOperation;
        private readonly ZodiacSignMatch r_ZodiacMatch;
        private readonly User r_LoggedInUser;

        internal ZodiakSignForm(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            r_ZodiacMatch = new ZodiacSignMatch(i_LoggedInUser.Birthday);
            InitializeComponent();
            pictureBox1.LoadAsync(r_ZodiacMatch.PictureUrl);
            userSignNameLabel.Text = Enum.GetName(typeof(ZodiacSignMatch.eZodiacSign), r_ZodiacMatch.Sign);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            ZodiacSignMatch bestMatch = r_ZodiacMatch.BestMatchedWithSign;
            pictureBox2.LoadAsync(bestMatch.PictureUrl);
            matchSignNameLabel.Text = Enum.GetName(typeof(ZodiacSignMatch.eZodiacSign), bestMatch.Sign);
            findButton.Visible = false;
            pictureBox2.Visible = true;
            matchSignNameLabel.Visible = true;
            fateQuotePicture.Visible = true;
            shareButton.Visible = true;
            MessageBox.Show("Congratulations! A match was found!");
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            if (BackButtonOperation != null)
            {
                BackButtonOperation.Invoke();
            }

            findButton.Visible = true;
            pictureBox2.Visible = false;
            matchSignNameLabel.Visible = false;
            fateQuotePicture.Visible = false;
            shareButton.Visible = false;
        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            string textForPost = string.Format("Looking for {0} {1} {2} Anyone?",
                r_ZodiacMatch.MatchSignName, r_LoggedInUser.InterestedIn, Environment.NewLine);
            r_LoggedInUser.PostStatus(textForPost);
            MessageBox.Show(string.Format("Status Posted! {0}{1}", Environment.NewLine, textForPost));
        }
    }
}
