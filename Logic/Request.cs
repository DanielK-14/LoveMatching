using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Request
    {
        public int Score { get; set; }

        public User MainUser { get; private set; }

        public User Friend { get; private set; }

        public bool isScoreHighEnough { get; set; }

        public Request(User i_MainUser, User i_Friend)
        {
            MainUser = i_MainUser;
            Friend = i_Friend;
            isScoreHighEnough = false;
            Score = 0;
        }
    }
}
