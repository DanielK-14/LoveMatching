using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FaceBook_Application_WForms
{

    public partial class MainPageForm : Form
    {
        public delegate void ProfileLinkDelegate();
        public event ProfileLinkDelegate ProfileLinkOperation;
        internal User m_LoggedInUser;
        private LastButtonClicked m_LastButtonClicked;

        public enum LastButtonClicked
        {
            Posts,
            Events,
            Friends
        }

        public LastButtonClicked ButtonClicked
        {
            get { return m_LastButtonClicked; }
            set { m_LastButtonClicked = value; }
        }

        public MainPageForm(User i_User)
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;

            m_LoggedInUser = i_User;
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            fullNameUser.Text = m_LoggedInUser.Name;;
        }

        private void fetchEvents()
        {

            int counter = 0;
            foreach(Event eventFSB in m_LoggedInUser.Events)
            {
                if(counter == 15)
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
        }

        private void fetchPosts()
        {
            int counter = 0;
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if(counter == 15)
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

        private void fetchFriends()
        {
            comboBoxDecisionData.Items.Clear();
            comboBoxDecisionData.DisplayMember = "Name";
            int counter = 0;
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if(counter == 10)
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

        private void postButton_Click(object sender, EventArgs e)
        {
            Status postNewStatus = m_LoggedInUser.PostStatus(postTextBox.Text);
            MessageBox.Show(string.Format("Status Posted! {0}{1}", Environment.NewLine, postTextBox.Text));
        }

        private void showEventsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            ButtonClicked = LastButtonClicked.Events;
            fetchEvents();
        }

        private void showPostsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            ButtonClicked = LastButtonClicked.Posts;
            fetchPosts();
        }

        private void showFriendsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            ButtonClicked = LastButtonClicked.Friends;
            fetchFriends();
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
            if (comboBoxDecisionData.SelectedItems.Count == 1)
            {
                if (ButtonClicked == LastButtonClicked.Posts)
                {
                    analyzePost();
                }
                else if (ButtonClicked == LastButtonClicked.Events)
                {
                    analyzeEvent();
                }
                else
                {
                    analyzeFriend();
                }
            }
        }

        private void resetDataAnalyst()
        {
            dataAnalystRichBox.Clear();
            dataAnalystRichBox.Visible = false;

            dataSelectedPictureBox.Image = null;
            dataSelectedPictureBox.Visible = false;
        }

        private void analyzeFriend()
        {
            User friend = m_LoggedInUser.Friends[comboBoxDecisionData.SelectedIndex];
            StringBuilder friendInfo = new StringBuilder();
            friendInfo.AppendLine(string.Format("Your friend {0} has some intresting facts:", friend.FirstName));
            friendInfo.AppendLine(string.Format("{0} Is {1}", friend.FirstName, friend.Gender.ToString()));
            friendInfo.AppendLine(string.Format("{0} Is {1}", friend.FirstName, friend.RelationshipStatus.ToString()));
            friendInfo.AppendLine(string.Format("Has {0} wallposts.", friend.WallPosts.Count.ToString()));
            friendInfo.AppendLine(string.Format("Has {0} Subscribers.", friend.Subscribers.Count.ToString()));
            showAnalayzeResults(friendInfo, friend.PictureNormalURL);
        }

        private void analyzeEvent()
        {
            Event eventFSB = m_LoggedInUser.Events[comboBoxDecisionData.SelectedIndex];
            StringBuilder eventInfo = new StringBuilder();
            eventInfo.AppendLine(string.Format("Event {0}{1} Starts in: {2}{1} Ends in: {3}", 
                eventFSB.Name, Environment.NewLine, eventFSB.StartTime.ToString(), eventFSB.EndTime.ToString()));
            eventInfo.AppendLine(string.Format("Description:{0}{1}", Environment.NewLine, eventFSB.Description));
            showAnalayzeResults(eventInfo, eventFSB.PictureNormalURL);
        }

        private void analyzePost()
        {
            Post post = m_LoggedInUser.Posts[comboBoxDecisionData.SelectedIndex];
            StringBuilder postInfo = new StringBuilder();
            postInfo.AppendLine(string.Format("Post: {0}.{1} Has {2} comments.{1} Was posted on {3}.",
                post.Message, Environment.NewLine, post.Comments.Count, post.CreatedTime));
            showAnalayzeResults(postInfo, post.PictureURL);
        }

        private void showAnalayzeResults(StringBuilder dataInfo, string imageURL = "")
        {
            dataAnalystRichBox.Visible = true;
            if (string.IsNullOrEmpty(imageURL) == false)
            {
                dataSelectedPictureBox.Visible = true;
                dataSelectedPictureBox.LoadAsync(imageURL);
            }

            dataAnalystRichBox.Text = dataInfo.ToString();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ProfileLinkOperation != null)
            {
                ProfileLinkOperation.Invoke();
            }
        }
    }
}
