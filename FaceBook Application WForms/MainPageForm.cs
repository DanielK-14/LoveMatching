using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
        private List<Post> m_Posts;
        private List<User> m_Friends;
        private List<Event> m_Events;

        public MainPageForm()
        {
            InitializeComponent();
            r_AppManager.LoginEvent += switchUser;
        }

        private void switchUser()
        {
            disableButtons();
            m_LoggedInUser = r_AppManager.LoggedInUser;
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureLargeURL);
            fullNameUser.Text = m_LoggedInUser.Name;
            new Thread(loadEvents).Start();
            new Thread(loadPosts).Start();
            new Thread(loadFriends).Start();
        }

        private void loadEvents()
        {
            m_Events = m_LoggedInUser.Events.Take(15).ToList();
            showEventsButton.Enabled = m_Events.Count > 0;
            showEventsButton.Text = m_Events.Count > 0 ? "Show Events" : "No Events";
            showEventsButton.BackColor = m_Events.Count > 0 ? System.Drawing.Color.Orange : showEventsButton.BackColor;
        }

        private void loadPosts()
        {
            m_Posts = m_LoggedInUser.Posts.Take(15).ToList();
            showPostsButton.Enabled = m_Posts.Count > 0;
            showPostsButton.Text = m_Posts.Count > 0 ? "Show Posts" : "No Posts";
            showPostsButton.BackColor = m_Posts.Count > 0 ? System.Drawing.Color.Blue : showPostsButton.BackColor;
        }

        private void loadFriends()
        {
            m_Friends = m_LoggedInUser.Friends.Take(15).ToList();
            showFriendsButton.Enabled = m_Friends.Count > 0;
            showFriendsButton.Text = m_Friends.Count > 0 ? "Show Friends" : "No Friends";
            showFriendsButton.BackColor = m_Friends.Count > 0 ? System.Drawing.Color.Green : showFriendsButton.BackColor;
            GetMatchesButton.Enabled = m_Friends.Count > 0;
            GetMatchesButton.BackColor = m_Friends.Count > 0 ? System.Drawing.Color.Purple : GetMatchesButton.BackColor;
        }

        private void disableButtons()
        {
            showFriendsButton.Enabled = false;
            showFriendsButton.Text = "Loading Friends";
            showFriendsButton.BackColor = System.Drawing.Color.Gray;
            GetMatchesButton.Enabled =false;
            GetMatchesButton.BackColor =System.Drawing.Color.Gray;
            showPostsButton.Enabled = false;
            showPostsButton.Text = "Loading Posts";
            showPostsButton.BackColor = System.Drawing.Color.Gray;
            showEventsButton.Enabled = false;
            showEventsButton.Text = "Loading Events";
            showEventsButton.BackColor = System.Drawing.Color.Gray;
        }
        private void fetchEvents()
        {
            if (eventsListBox.InvokeRequired == false)
            {
                eventBindingSource.DataSource = m_Events;
            }
            else
            {
                eventsListBox.Invoke(new Action(() => eventBindingSource.DataSource = m_Events));
            }
        }

        private void fetchPosts()
        {
            if(postsListBox.InvokeRequired == false)
            {
                postBindingSource.DataSource = m_Posts;
            }
            else
            {
                postsListBox.Invoke(new Action(() => postBindingSource.DataSource = m_Posts));
            }
        }


        /*
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
        */

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
            //cleanDataSelcetedComboBoxAndAnalyst();
            //DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Events;
            fetchEvents();
        }

        private void ShowPostsButton_Click(object sender, EventArgs e)
        {
            //cleanDataSelcetedComboBoxAndAnalyst();
            //DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Posts;
            fetchPosts();
        }

        /*
        private void ShowFriendsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Friends;
            fetchFriends();
        }
        */

        /*
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
        */

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
