using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UI
{
    public partial class MainPageForm : Form
    {
        private readonly int r_MaximumNumberOfFriendsToShow = 10;
        private readonly int r_MaximumNumberOfPostsToShow = 15;
        private readonly int r_MaximumNumberOfEventsToShow = 15;

        private  User m_LoggedInUser;

        private readonly AppManager r_AppManager = AppManager.GetInstance;

        public MainPageForm()
        {
            InitializeComponent();
            r_AppManager.LoginEvent += switchUser;
        }

        private void switchUser()
        {
            m_LoggedInUser = r_AppManager.LoggedInUser;
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureLargeURL);
            fullNameUser.Text = m_LoggedInUser.Name;
        }

        private void fetchEvents()
        {
            /*
            int counter = 0;
            foreach (Event eventFSB in m_LoggedInUser.Events)
            {
                if (counter == r_MaximumNumberOfEventsToShow)
                {
                    break;
                }
                else
                {
                    comboBoxDecisionData.Items.Add(eventFSB.Name);
                }

                counter++;
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No events to retrieve!");
            }
            */

            var allEvents = m_LoggedInUser.Events.Take(15).ToList();

            if (eventsListBox.InvokeRequired == false)
            {
                eventBindingSource.DataSource = allEvents;
            }
            else
            {
                eventsListBox.Invoke(new Action(() => eventBindingSource.DataSource = allEvents));
            }
        }

        /*private void fetchPosts()
        {
            int counter = 0;
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (counter == r_MaximumNumberOfPostsToShow)
                {
                    break;
                }
                else if (post.Message != null)
                {
                    comboBoxDecisionData.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    comboBoxDecisionData.Items.Add(post.Caption);
                }
                else
                {
                    comboBoxDecisionData.Items.Add(string.Format("[{0}]", post.Type));
                }

                counter++;
            }

            if (m_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No posts to retrieve!");
            }
        }
        */
        private void fetchPosts()
        {
            var allPosts = m_LoggedInUser.Posts.Take(15).ToList();

            if(postsListBox.InvokeRequired == false)
            {
                postBindingSource.DataSource = allPosts;
            }
            else
            {
                postsListBox.Invoke(new Action(() => postBindingSource.DataSource = allPosts));
            }
        }

        private void fetchFriends()
        {
            comboBoxDecisionData.Items.Clear();
            comboBoxDecisionData.DisplayMember = "Name";
            int counter = 0;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (counter == r_MaximumNumberOfFriendsToShow)
                {
                    break;
                }

                comboBoxDecisionData.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                counter++;
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve!");
            }
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoggedInUser.PostStatus(postTextBox.Text);
                MessageBox.Show(string.Format("Status Posted! {0}{1}", Environment.NewLine, postTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not post.");
                throw ex;
            }
        }

        private void ShowEventsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Events;
            fetchEvents();
        }

        private void ShowPostsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Posts;
            fetchPosts();
        }

        private void ShowFriendsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Friends;
            fetchFriends();
        }

        private void GetMatchesButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Friends;

            List<User> friendsToMatchWith = AvailableFriends.GetAvailabeFriends(m_LoggedInUser);
            int counter = 0;
            foreach (User friend in friendsToMatchWith)
            {
                if (counter == r_MaximumNumberOfFriendsToShow)
                {
                    break;
                }

                comboBoxDecisionData.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                counter++;
            }

            if (friendsToMatchWith.Count == 0)
            {
                MessageBox.Show("Could not find anyone for you.");
            }
        }

        private void cleanDataSelcetedComboBoxAndAnalyst()
        {
            comboBoxDecisionData.Items.Clear();
            dataAnalystRichBox.Text = string.Empty;
            dataAnalystRichBox.Visible = false;

            resetDataAnalyst();
        }

        private void comboBoxDecisionData_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetDataAnalyst();
            showAnalayzeResults(DataAnalyst.AnalyzeData(comboBoxDecisionData.SelectedIndex, m_LoggedInUser));
        }

        private void resetDataAnalyst()
        {
            dataAnalystRichBox.Clear();
            dataAnalystRichBox.Visible = false;

            dataSelectedPictureBox.Image = null;
            dataSelectedPictureBox.Visible = false;
        }

        private void showAnalayzeResults(List<string> i_Data)
        {
            string imageUrl = i_Data[1];
            string dataAnalyzed = i_Data[0];
            dataAnalystRichBox.Visible = true;

            if (string.IsNullOrEmpty(imageUrl) == false)
            {
                dataSelectedPictureBox.Visible = true;
                dataSelectedPictureBox.LoadAsync(imageUrl);
            }

            dataAnalystRichBox.Text = dataAnalyzed;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            r_AppManager.NextPage("UserInformation");
        }

        private void ZodiakSignLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            r_AppManager.NextPage("ZodiacSignForm");
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            r_AppManager.Logout();
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
