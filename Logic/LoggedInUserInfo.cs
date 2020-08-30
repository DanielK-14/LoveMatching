using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    /// Proxy class
    public class LoggedInUserInfo
    {
        private readonly User r_User;
        private string m_Name;
        private string m_PictureURL;
        private string m_Email;
        private string m_Birthday;
        private List<Photo> m_PhotosTaggedIn;
        private List<Post> m_Posts;
        private List<Event> m_Events;
        private List<User> m_Friends;

        public LoggedInUserInfo(User i_User)
        {
            r_User = i_User;
            updateValues();
        }

        public LoggedInUserInfo(string i_AccessToken)
        {
            r_User = FacebookService.Connect(i_AccessToken).LoggedInUser;
            updateValues();
        }

        public string Name 
        {
            get
            {
                updateValuesIfNeeded();
                return m_Name;
            } 
            private set
            {
                m_Name = value;
            }
        }

        public List<Post> Posts 
        { 
            get
            {
                updateValuesIfNeeded();
                return m_Posts;
            }
            private set
            {
                m_Posts = value;
            }
        }

        public Cover Cover
        {
            get
            {
                return r_User.Cover;
            }
        }

        public string Birthday
        {
            get
            {
                updateValuesIfNeeded();
                return m_Birthday;
            }
            private set
            {
                m_Birthday = value;
            }
        }

        public string Email
        {
            get
            {
                updateValuesIfNeeded();
                return m_Email;
            }
            private set
            {
                m_Email = value;
            }
        }

        public List<Event> Events
        {
            get
            {
                updateValuesIfNeeded();
                return m_Events;
            }
            private set
            {
                m_Events = value;
            }
        }

        public List<User> Friends
        {
            get
            {
                updateValuesIfNeeded();
                return m_Friends;
            }
            private set
            {
                m_Friends = value;
            }
        }

        public List<Photo> PhotosTaggedIn
        {
            get
            {
                updateValuesIfNeeded();
                return m_PhotosTaggedIn;
            }
            private set
            {
                m_PhotosTaggedIn = value;
            }
        }

        public User.eGender? Gender 
        { 
            get
            {
                return r_User.Gender;
            }
        }

        public User.eGender[] InterestedIn
        {
            get
            {
                return r_User.InterestedIn;
            }
        } 

        private DateTime? LastUpdate { get; set; }

        public string PictureLargeURL
        {
            get
            {
                updateValuesIfNeeded();
                return m_PictureURL;
            }
            private set
            {
                m_PictureURL = value;
            }
        }

        public User LoggedUser
        {
            get { return r_User; }
        }

        public Status PostStatus(string i_Text)
        {
            return r_User.PostStatus(i_Text);
        }

        private void updateValues()
        {
            Posts = r_User.Posts.Take(10).ToList();
            Events = r_User.Events.Take(10).ToList();
            Friends = r_User.Friends.Take(10).ToList();
            PhotosTaggedIn = r_User.PhotosTaggedIn.Take(10).ToList();
            Email = r_User.Email;
            Birthday = r_User.Birthday;
            PictureLargeURL = r_User.PictureLargeURL;
            Name = r_User.Name;
            LastUpdate = r_User.UpdateTime;
        }

        private void updateValuesIfNeeded()
        {
            if(LastUpdate != r_User.UpdateTime)
            {
                updateValues();
            }
        }
    }
}
